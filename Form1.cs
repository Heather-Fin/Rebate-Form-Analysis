using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Author: Heather Finnegan
// Class: CS 6326 - Human Computer Interaction
// Date: 09/25/2019
// Description: Analyzes a text file produced by assignment 2 to allow users to evaluate
// the effectiveness of the user interface for the rebate form.

namespace Asg3_HXF180007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Shows data produced from InputFile class
        private void ShowData(InputFile file)
        {
            lbl_record_num_data.Text = file.GetNumberOfRecords().ToString();
            lbl_min_entry_time_data.Text = file.GetMinTime();
            lbl_max_entry_time_data.Text = file.GetMaxTime();
            lbl_average_entry_time_data.Text = file.GetAverageTime();
            lbl_min_inter_time_data.Text = file.GetMinInterTime();
            lbl_max_inter_time_data.Text = file.GetMaxInterTime();
            lbl_average_inter_time_data.Text = file.GetAverageInterTime();
            lbl_total_time_data.Text = file.GetTotalTime();
            lbl_backspace_count_data.Text = file.GetBackspaces().ToString();
        }

        // Opens file based on user selection and analyzes it
        private void Btn_open_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("File selected: " + openFileDialog1.FileName);
                string fileName = openFileDialog1.FileName;

                InputFile file = new InputFile();
                file.LoadFile(fileName);
                ShowData(file);

                OutputFile newFile = new OutputFile();
                newFile.createFile(file, fileName);
            } 
        }
    }

    // Opens the user defined input file and evaluates the data.
    class InputFile {

        // Analysis data variables
        private int numberOfRecords;
        private string minTime;
        private string maxTime;
        private string averageTime;
        private string minInterTime;
        private string maxInterTime;
        private string averageInterTime;
        private string totalTime;
        private int backspaces;

        private string[,] data;

        // Get methods for analysis data variables
        public int GetNumberOfRecords()
        {
            return numberOfRecords;
        }
        public string GetMinTime()
        {
            return minTime;
        }
        public string GetMaxTime()
        {
            return maxTime;
        }
        public string GetAverageTime()
        {
            return averageTime;
        }
        public string GetMinInterTime()
        {
            return minInterTime;
        }
        public string GetMaxInterTime()
        {
            return maxInterTime;
        }
        public string GetAverageInterTime()
        {
            return averageInterTime;
        }
        public string GetTotalTime()
        {
            return totalTime;
        }
        public int GetBackspaces()
        {
            return backspaces;
        }

        // Handles opening and reading the user defined input file.
        public void LoadFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            numberOfRecords = lines.Length;
            data = new string[numberOfRecords, 17];

            for(int i = 0; i < numberOfRecords; i++)
            {
                string line = lines[i];
                string[] element = line.Split('\t');
                for (int j = 0; j < element.Length; j++)
                {
                    data[i, j] = element[j];
                }
            }
            findMinEntryTime();
            findInterTimes();
            findTotalEntryTime();
            findTotalBackspaces();
        }

        // Finds the minimum, maximum, and average entry time for all records
        private void findMinEntryTime()
        {
            TimeSpan tempMinTime = TimeSpan.Parse(data[0,13]);
            TimeSpan tempMaxTime = TimeSpan.Parse(data[0, 13]);
            TimeSpan tempAverageTime = TimeSpan.Zero;

            for (int i = 0; i < numberOfRecords; i++)
            {
                TimeSpan current = TimeSpan.Parse(data[i, 13]);
                tempAverageTime += current;

                if (current < tempMinTime)
                {
                    tempMinTime = current;
                }
                if (current > tempMaxTime)
                {
                    tempMaxTime = current;
                }
            }
            minTime = tempMinTime.ToString(@"mm\:ss");
            maxTime = tempMaxTime.ToString(@"mm\:ss");

            int time = (int)tempAverageTime.TotalSeconds;
            time = time / numberOfRecords;
            tempAverageTime = TimeSpan.FromSeconds(time);
            averageTime = tempAverageTime.ToString(@"mm\:ss");

            return;
        }

        // Find minimum, maximum, and average amount of time spent between records
        private void findInterTimes()
        {
            minInterTime = "0";
            maxInterTime = "0";
            averageInterTime = "0";
            return;
        }

        // Finds total time spent entering all records
        private void findTotalEntryTime()
        {
            // Take first submission time and subtract the time taken to complete it
            DateTime dateStartTime = DateTime.Parse(data[0, 14]);
            TimeSpan firstElementTime = TimeSpan.Parse(data[0, 13]);

            // Time first entry was began
            dateStartTime = dateStartTime.Subtract(firstElementTime);

            // Take time last submission was made
            DateTime dateEndTime = DateTime.Parse(data[numberOfRecords - 1, 14]);

            // Subtract the start time from the end time
            TimeSpan tempTotalTime = dateEndTime - dateStartTime;
            totalTime = tempTotalTime.ToString(@"mm\:ss");

            return;
        }

        // Finds total backspaces used
        private void findTotalBackspaces()
        {
            backspaces = 0;
            for (int i = 0; i < numberOfRecords; i++)
            {
                backspaces += Int32.Parse(data[i, 15]);
            }
            return;
        }
    }

    // Creates a new file and stores the analysis data
    class OutputFile
    {
        public void createFile(InputFile file, string fileName)
        {
            // Removes ".txt" from fileName to add new ending for output file
            string newFileName = fileName.Remove(fileName.Length -4, 4); 
            newFileName += "_output.txt";

            // Create a file to write to and enters data
            using (StreamWriter sw = File.CreateText(newFileName))
            {
                sw.WriteLine("Number of records: " + file.GetNumberOfRecords());
                sw.WriteLine("Minimum entry time: " + file.GetMinTime());
                sw.WriteLine("Maximum entry time: " + file.GetMaxTime());
                sw.WriteLine("Average entry time: " + file.GetAverageTime());
                sw.WriteLine("Minimum inter-record time: " + file.GetMinInterTime());
                sw.WriteLine("Maximum inter-record time: " + file.GetMinInterTime());
                sw.WriteLine("Average inter-record time: " + file.GetAverageInterTime());
                sw.WriteLine("Total time: " + file.GetTotalTime());
                sw.WriteLine("Backspace count: " + file.GetBackspaces());
            }
        }
    }
}
