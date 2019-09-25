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
            ShowData(file.numberOfRecords);
        }

        // Shows data produced from InputFile class
        private void ShowData(int numberOfRecords)
        {
            lbl_record_num_data.Text = numberOfRecords.ToString();
            lbl_min_entry_time_data.Text = "filler";
            lbl_max_entry_time_data.Text = "filler";
        }
    }

    // Opens the user defined input file and evaluates the data.
    class InputFile {
        public int numberOfRecords { get; set; } = 0;
        public string minEntryTime { get; set; };

        // Handles opening and reading the user defined input file.
        public void LoadFile()
        {
            string fileName = "CS6326Asg2.txt";

            string[] lines = File.ReadAllLines(fileName);
            numberOfRecords = lines.Length;
            string[,] data = new string[numberOfRecords, 17];

            for(int i = 0; i < numberOfRecords; i++)
            {
                string line = lines[i];
                string[] element = line.Split('\t');
                for (int j = 0; j < element.Length; j++)
                {
                    data[i, j] = element[j];
                }
                Console.WriteLine(line);
            }
        }
        private void findMinEntryTime()
        {

        }
    }
}
