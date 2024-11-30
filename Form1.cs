//Name: Ahmed Benyusuf
//Class and Section (CS 313 01)
//Assignment (Program 02 Chapter 07)
//Description of the Program: This program reads a file that contains the answers to a test and compares them to the correct answers. It then displays the results of the test.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C07_P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadTest(List<string> TestList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("Test.txt");
                //  Open the file
                while (!inputFile.EndOfStream)
                //  Continue processing until the end of the file is reached
                {
                    string Line = inputFile.ReadLine();
                    if (string.IsNullOrEmpty(Line))
                    {
                        continue;
                    }
                    // Add the line to the list
                    TestList.Add(Line);
                }
                inputFile.Close();
                // Close the file
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file 'Correct.txt' was not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Display an error message if the file is not found
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Display an error message if an exception occurs
            }
        }

        private void CorrectTest(List<string> Answerlist)
        {
            //creat an array to hold the correct answers
            string[] CorrectAnswers = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
            //clear the list
            Answerlist.Clear();
            //add the correct answers to the list
            Answerlist.AddRange(CorrectAnswers);

        }

        private void CompareAnswers(List<string> AnswerList, List<string> TestList)
        {
            //  Initialize variables
            int correctCount = 0;
                List<int> incorrectQuestions = new List<int>();

                for (int i = 0; i < AnswerList.Count; i++)
                //loop through the list of answers
                {
                    if (i < TestList.Count && AnswerList[i] == TestList[i])
                //  Compare the answers
                {
                    correctCount++;
                    //  Increment the correct count
                }
                else
                    {
                        incorrectQuestions.Add(i + 1);
                    //  Add the question number to the list of incorrect questions
                }
            }

                // Determine pass or fail
                bool passed = correctCount >= 15;
                string resultMessage = passed ? "Passed" : "Failed";

                // Display results
                LabelResults.Text = ($@"
            Result: {resultMessage}
            Correct Answers: {correctCount}
            Incorrect Answers: {incorrectQuestions.Count}
            Incorrect Questions: {string.Join(", ", incorrectQuestions)}
            ");
            }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //  Close the form
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            
                List<string> AnswerList = new List<string>();
            //  Create a list to hold the answers
            List<string> TestList = new List<string>();
            //  Create a list to hold the test answers
            CorrectTest(AnswerList);
            //  Get the correct answers
            ReadTest(TestList);
            //  Read the test answers
            CompareAnswers(AnswerList, TestList);
            //  Compare the answers
        }
    }
}
