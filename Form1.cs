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
            newFile.createFile(fileName);
        }

        // Shows data produced from InputFile class
        private void ShowData(InputFile file)
        {
            lbl_record_num_data.Text = file.numberOfRecords.ToString();
            lbl_min_entry_time_data.Text = (file.findMinEntryTime()).ToString(@"mm\:ss");
            lbl_max_entry_time_data.Text = (file.findMaxEntryTime()).ToString(@"mm\:ss");
            lbl_average_entry_time_data.Text = (file.findAverageEntryTime()).ToString(@"mm\:ss");

            lbl_total_time_data.Text = (file.findTotalEntryTime()).ToString(@"mm\:ss");
            lbl_backspace_count_data.Text = (file.findTotalBackspaces()).ToString();
        }
    }

    // Opens the user defined input file and evaluates the data.
    class InputFile {
        public int numberOfRecords;
        private string[,] data;

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
        public TimeSpan findMinEntryTime()
        {
            TimeSpan minTime = TimeSpan.Parse(data[0,13]);
            for (int i = 0; i < numberOfRecords; i++)
            {
                TimeSpan temp = TimeSpan.Parse(data[i, 13]);
                if(temp < minTime)
                {
                    minTime = temp;
                }
            }
            return minTime;
        }

        // Finds the maxiumum entry time for all records
        public TimeSpan findMaxEntryTime()
        {
            TimeSpan maxTime = TimeSpan.Parse(data[0, 13]);
            for (int i = 0; i < numberOfRecords; i++)
            {
                TimeSpan temp = TimeSpan.Parse(data[i, 13]);
                if (temp > maxTime)
                {
                    maxTime = temp;
                }
            }
            return maxTime;
        }

        // Averages the entry time for all records
        public TimeSpan findAverageEntryTime()
        {
            TimeSpan averageTime = TimeSpan.Zero;
            for(int i = 0; i < numberOfRecords; i++)
            {
                averageTime += TimeSpan.Parse(data[i, 13]);
            }
            int time = (int)averageTime.TotalSeconds;
            time = time / numberOfRecords;
            averageTime = TimeSpan.FromSeconds(time);
            return averageTime;
        }

        // Finds total time spent entering all records
        public TimeSpan findTotalEntryTime()
        {
            // Take first submission time and subtract the time taken to complete it
            DateTime dateStartTime = DateTime.Parse(data[0, 14]);
            TimeSpan firstElementTime = TimeSpan.Parse(data[0, 13]);

            // Time first entry was began
            dateStartTime = dateStartTime.Subtract(firstElementTime);

            // Take time last submission was made
            DateTime dateEndTime = DateTime.Parse(data[numberOfRecords - 1, 14]);

            // Subtract the start time from the end time
            TimeSpan totalTime = dateEndTime - dateStartTime;

            return totalTime;
        }

        // Finds total backspaces used
        public int findTotalBackspaces()
        {
            int backspaces = 0;
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
        public void createFile(string fileName)
        {
            // Removes ".txt" from fileName to add new ending for output file
            string newFileName = fileName.Remove(fileName.Length -4, 4); 
            newFileName += "_output.txt";
            Console.WriteLine(newFileName);

            // Create a file to write to and enters data
            using (StreamWriter sw = File.CreateText(newFileName))
            {
                sw.WriteLine("Number of records: ");
                sw.WriteLine("Minimum entry time: ");
                sw.WriteLine("Maximum entry time: ");
                sw.WriteLine("Average entry time: ");
                sw.WriteLine("Minimum inter-record time: ");
                sw.WriteLine("Maximum inter-record time: ");
                sw.WriteLine("Average inter-record time: ");
                sw.WriteLine("Total time: ");
                sw.WriteLine("Backspace count: ");
            }
        }
    }
}
