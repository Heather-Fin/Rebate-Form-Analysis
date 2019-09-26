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
            string fileName = "CS6326Asg2.txt";

            InputFile file = new InputFile();
            file.LoadFile(fileName);
            ShowData(file);

            OutputFile newFile = new OutputFile();
            newFile.createFile(file, fileName);
        }

        // Shows data produced from InputFile class
        private void ShowData(InputFile file)
        {
            lbl_record_num_data.Text = (file.getNumberOfRecords()).ToString();
            lbl_min_entry_time_data.Text = file.findMinEntryTime();
            lbl_max_entry_time_data.Text = file.findMaxEntryTime();
            lbl_average_entry_time_data.Text = file.findAverageEntryTime();

            lbl_total_time_data.Text = file.findTotalEntryTime();
            lbl_backspace_count_data.Text = (file.findTotalBackspaces()).ToString();
        }

        private void Btn_open_file_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button clicked");
            openFileDialog1.ShowDialog();
            /*
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("File selected");
            } */
        }
    }

    // Opens the user defined input file and evaluates the data.
    class InputFile {
        // Analysis data variables
        private int numberOfRecords;
        private string minTime;
        private string maxTime;
        private string averageTime;
        private string totalTime;
        private int backspaces;

        private string[,] data;

        public int getNumberOfRecords()
        {
            return numberOfRecords;
        }
        public string getMinTime()
        {
            return minTime;
        }
        public string getMaxTime()
        {
            return maxTime;
        }
        public string getAverageTime()
        {
            return averageTime;
        }
        public string getTotalTime()
        {
            return totalTime;
        }
        public int getBackspaces()
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
        }

        // Finds the minimum entry time for all records
        public string findMinEntryTime()
        {
            TimeSpan tempMinTime = TimeSpan.Parse(data[0,13]);
            for (int i = 0; i < numberOfRecords; i++)
            {
                TimeSpan current = TimeSpan.Parse(data[i, 13]);
                if(current < tempMinTime)
                {
                    tempMinTime = current;
                }
            }
            minTime = tempMinTime.ToString(@"mm\:ss");
            return minTime;
        }

        // Finds the maxiumum entry time for all records
        public string findMaxEntryTime()
        {
            TimeSpan tempMaxTime = TimeSpan.Parse(data[0, 13]);
            for (int i = 0; i < numberOfRecords; i++)
            {
                TimeSpan current = TimeSpan.Parse(data[i, 13]);
                if (current > tempMaxTime)
                {
                    tempMaxTime = current;
                }
            }
            maxTime = tempMaxTime.ToString(@"mm\:ss");
            return maxTime;
        }

        // Averages the entry time for all records
        public string findAverageEntryTime()
        {
            TimeSpan tempAverageTime = TimeSpan.Zero;
            for(int i = 0; i < numberOfRecords; i++)
            {
                tempAverageTime += TimeSpan.Parse(data[i, 13]);
            }
            int time = (int)tempAverageTime.TotalSeconds;
            time = time / numberOfRecords;
            tempAverageTime = TimeSpan.FromSeconds(time);
            averageTime = tempAverageTime.ToString(@"mm\:ss");
            return averageTime;
        }

        // Finds total time spent entering all records
        public string findTotalEntryTime()
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

            return totalTime;
        }

        // Finds total backspaces used
        public int findTotalBackspaces()
        {
            backspaces = 0;
            for (int i = 0; i < numberOfRecords; i++)
            {
                backspaces += Int32.Parse(data[i, 15]);
            }
            return backspaces;
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
                sw.WriteLine("Number of records: " + file.getNumberOfRecords());
                sw.WriteLine("Minimum entry time: " + file.getMinTime());
                sw.WriteLine("Maximum entry time: " + file.getMaxTime());
                sw.WriteLine("Average entry time: " + file.getAverageTime());
                sw.WriteLine("Minimum inter-record time: ");
                sw.WriteLine("Maximum inter-record time: ");
                sw.WriteLine("Average inter-record time: ");
                sw.WriteLine("Total time: " + file.getTotalTime());
                sw.WriteLine("Backspace count: " + file.getBackspaces());
            }
        }
    }
}
