using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_1_Assignment.ProgramCommands
{
  

    // Implement the while command as a class that implements the ICommand interface
    public class WhileCommand : Icommands
    {
        private string condition;
        private string[] commands;
        private Dictionary<string, int> variables;
        private Graphics graphics;

        public WhileCommand(string condition, string[] commands, Dictionary<string, int> variables, Graphics g)
        {
            this.condition = condition;
            this.commands = commands;
            this.variables = variables;
            this.graphics = g;
        }

        public void execute()
        {
            string[] conditionParts = condition.Split(' ');
            if (conditionParts.Length == 3)
            {
                string leftOperand = conditionParts[0];
                string comparisonOperator = conditionParts[1];
                string rightOperand = conditionParts[2];

                int currentIndex = 0; // Keep track of the current command index

                while (EvaluateCondition(leftOperand, comparisonOperator, rightOperand))
                {
                    // Execute the commands inside the while loop
                    while (currentIndex < commands.Length && !commands[currentIndex].Trim().ToLower().Equals("endloop"))
                    {
                        string innerCommand = commands[currentIndex].Trim();
                        new CommandParser(innerCommand, graphics);
                        MessageBox.Show($"while yestai ho {currentIndex}. Please enter an integer or valid addition operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        currentIndex++; // Move to the next command inside the while loop
                    }

                    // Reevaluate the condition to continue or exit the loop
                }
            }
        }

        private bool EvaluateCondition(string leftOperand, string comparisonOperator, string rightOperand)
        {
            if (variables.ContainsKey(leftOperand) && variables.ContainsKey(rightOperand))
            {
                int leftValue = variables[leftOperand];
                int rightValue = variables[rightOperand];

                switch (comparisonOperator)
                {
                    case "<":
                        return leftValue < rightValue;
                    case ">":
                        return leftValue > rightValue;
                    case "==":
                        return leftValue == rightValue;
                    // Add more cases for other comparison operators as needed
                    default:
                        return false;
                }
            }

            return false;
        }

        private void ProcessCommand(string command)
        {
            // Process the individual commands within the while loop
            // Implement the logic to handle different commands as per your language specifications
            // ...
        }
    }

}
