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
            InputFile file = new InputFile();
            file.LoadFile();
            ShowData(file);
        }

        // Shows data produced from InputFile class
        private void ShowData(InputFile file)
        {
            lbl_record_num_data.Text = file.numberOfRecords.ToString();
            lbl_min_entry_time_data.Text = (file.findMinEntryTime()).ToString();
            lbl_max_entry_time_data.Text = (file.findMaxEntryTime()).ToString();
            lbl_average_entry_time_data.Text = (file.findAverageEntryTime()).ToString();
        }
    }

    // Opens the user defined input file and evaluates the data.
    class InputFile {
        public int numberOfRecords;
        private string[,] data;

        // Handles opening and reading the user defined input file.
        public void LoadFile()
        {
            string fileName = "CS6326Asg2.txt";

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
            Console.WriteLine(minTime);
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
            Console.WriteLine(maxTime);
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
            return averageTime;
        }
    }
}
