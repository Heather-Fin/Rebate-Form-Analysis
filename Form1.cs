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
            InputFile.loadFile();
        }
    }

    // Opens the user defined input file and evaluates the data.
    public class InputFile{

        // Handles opening and reading the user defined input file.
        public static void loadFile()
        {
            string fileName = "CS6326Asg2.txt";

            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName);

                while (sr.Peek() > -1)
                {
                    string line = sr.ReadLine();
                    string[] element = line.Split('\t');

                    for (int i = 0; i < 12; i++)
                    {
                        Console.WriteLine(element[i]);
                    }
                }
                sr.Close();
            }
        }
    }
}
