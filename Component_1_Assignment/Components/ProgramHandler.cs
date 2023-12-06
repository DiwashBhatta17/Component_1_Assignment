using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Component_1_Assignment.ProgramCommands;

namespace Component_1_Assignment.Components
{
    internal class ProgramHandler
    {
        private Dictionary<string, int> variables = new Dictionary<string, int>();
        private Graphics outputGraphics;

        public ProgramHandler(Graphics g)
        {
            this.outputGraphics = g;
        }

        public void Execute(string line)
        {
            string[] commands = line.Split('\n');

            int currentIndex = 0; // Keep track of the current command index
            WhileCommand whileCommand = null;

            while (currentIndex < commands.Length)
            {
                string command = commands[currentIndex];
                string trimmedCommand = command.Trim();
                MessageBox.Show($"Processing command: {trimmedCommand}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int indexOfEquals = trimmedCommand.IndexOf('=');
                if (indexOfEquals != -1)
                {
                    string[] strings = trimmedCommand.Split('=');
                    string variableName = strings[0].Trim();
                    MessageBox.Show($"Variable name: {variableName}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (variableName.ToLower() == "if")
                    {
                        MessageBox.Show("Processing 'if' statement", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Implement logic for 'if' control structure
                    }
                    else if (variableName.ToLower() == "while")
                    {
                        MessageBox.Show("Processing 'while' statement", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Implement logic for 'while' control structure
                    }
                    else
                    {
                        if (strings.Length >= 2)
                        {
                            string valueString = strings[1].Trim();
                            int value;
                            if (int.TryParse(valueString, out value))
                            {
                                variables[variableName] = value;
                                MessageBox.Show($"Variable '{variableName}' set to {value}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                // C
                                string[] operands = valueString.Split('+');
                                if (operands.Length == 2 && variables.ContainsKey(operands[0].Trim()) && variables.ContainsKey(operands[1].Trim()))
                                {
                                    int result = variables[operands[0].Trim()] + variables[operands[1].Trim()];
                                    variables[variableName] = result;
                                    MessageBox.Show($"Variable '{variableName}' set to {result} (from addition operation)", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show($"Invalid value for {variableName}. Please enter an integer or valid addition operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else if (trimmedCommand.ToLower().StartsWith("print "))
                {
                    string varToPrint = trimmedCommand.Substring(6).Trim(); // Remove "print " from the command
                    MessageBox.Show($"Printing variable: {varToPrint}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (variables.ContainsKey(varToPrint))
                    {
                        MessageBox.Show($" {variables[varToPrint].ToString()}..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DisplayOutput(variables[varToPrint].ToString());
                    }
                    else
                    {
                        DisplayOutput($"Variable '{varToPrint}' not found.");
                    }
                }
                else if (trimmedCommand.ToLower().StartsWith("while "))
                {
                    string condition = trimmedCommand.Substring(6).Trim(); // Remove "print " from the command
                    MessageBox.Show($"Processing 'while' statement: {condition}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Split the condition into parts
                    string[] conditionParts = condition.Split(' ');
                    if (conditionParts.Length == 3)
                    {
                      

                        string[] whileCommands = commands.Skip(currentIndex + 1).ToArray(); // Extract while loop commands

                        whileCommand = new WhileCommand(condition, whileCommands, variables, outputGraphics);
                        whileCommand.execute();
                        currentIndex += whileCommands.Length;


                        // Skip the commands within the while loop and the endloop command
                    }
                    

                }
                currentIndex++;
            }
        }

        private void DisplayOutput(string outputText)
        {
            outputGraphics.DrawString(outputText, new Font("Arial", 12), Brushes.Black, new PointF(10, 10));
        }
    }
}
