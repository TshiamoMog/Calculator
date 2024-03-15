using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// A Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor for Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text and will clear the memory as well in later iterations 
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;

            // Focuses the user input text
            FocusInputText();
        }

        /// <summary>
        /// Clears the user input text, without clearing the memory 
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void CButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;

            // Focuses the user input text
            FocusInputText();
        }

        /// <summary>
        /// Deletes a character from the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete only when the text box has a value
            if (this.UserInputText.Text.Length > 0)
            {
                // Delete the character to the left of the selection if there is one
                if (selectionStart == 0)
                {
                    this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

                    // Restore the selection start
                    this.UserInputText.SelectionStart = selectionStart;
                }
                // Delete the character to the right of the selection if there is no character on the left
                else
                {
                    this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart - 1, 1);

                    // Restore the selection start
                    this.UserInputText.SelectionStart = selectionStart - 1;
                }
            }

            // Focuses the user input text
            FocusInputText();
        }

        #endregion

        #region Operator Methods
        /// <summary>
        /// Handles the click event for the division button and adds the character to the user input field
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(" / ");
        }

        /// <summary>
        /// Handles the click event for the multiplication button and adds the character to the user input field
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void TimesButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(" * ");
        }

        /// <summary>
        /// Handles the click event for the subtraction button and adds the character to the user input field
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(" - ");
        }

        /// <summary>
        /// Handles the click event for the addition button and adds the character to the user input field
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(" + ");
        }

        /// <summary>
        /// Handles the click event for the equals button andn calculates the given equation
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

        /// <summary>
        /// Handles the click event for the percent button
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void PercentButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("%");
        }
        #endregion

        #region Number Methods

        /// <summary>
        /// Handles the click event for the decimal button and adds the character to the user input field
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }

        /// <summary>
        /// Inserts the number 0 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
        }

        /// <summary>
        /// Inserts the number 1 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        /// <summary>
        /// Inserts the number 2 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        /// <summary>
        /// Inserts the number 3 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }

        /// <summary>
        /// Inserts the number 4 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
        }

        /// <summary>
        /// Inserts the number 5 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }

        /// <summary>
        /// Inserts the number 6 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        /// <summary>
        /// Inserts the number 7 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
        }

        /// <summary>
        /// Inserts the number 8 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }

        /// <summary>
        /// Inserts the number 9 into the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
        }

        #endregion

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            // Sets the result of the calculation to the designated text field
            this.CalculationResultText.Text = ParseOperation();

            // Focuses the user input text for further input
            FocusInputText();
        }

        /// <summary>
        /// Parses the user's equation input and calculates the result.
        /// </summary>
        /// <returns>The calculated result or an error message if the equation is invalid.</returns>
        private string ParseOperation()
        {
            try
            {
                // Retrieve the equation input provided by the user
                var userInput = this.UserInputText.Text;

                // Remove any spaces from the user's equation input
                userInput = userInput.Replace(" ", "");

                // Create a new top-level operation object to hold the parsed components
                var operation = new Operation();

                // Variable 'leftSide' tracks whether the current object is positioned to the left side of the equation
                var leftSide = true;

                // Iterate through each character of the input text, parsing from left to right
                for (int i = 0; i < userInput.Length; i++)
                {
                    // Define valid characters for numbers
                    var numbers = "0123456789.";

                    // Define valid characters for operators
                    var operators = "+-*/";

                    // Check if the current character is a number
                    if (numbers.Any(cter => userInput[i] == cter))
                    {
                        // If the current object is positioned on the left side of the equation, add the character to the left side of the operation
                        if (leftSide)   
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, userInput[i]);
                        }
                        else
                        {
                            operation.RightSide = AddNumberPart(operation.RightSide, userInput[i]);
                        }
                    }
                    // Check if the current character is an operator
                    else if (operators.Any(cter => userInput[i] == cter))
                    {
                        if (!leftSide)
                        {
                            // Get the operator type
                            var operatorType = GetOperationType(userInput[i]);

                            // Check if there is a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                // Check if the operator is not a minus, for negetive values
                                if (operatorType != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator for {operatorType} expression specified without a right side number");
                                }

                                // Adding the negetive to the left side term
                                operation.RightSide += userInput[i];
                            }
                            else
                            {
                                // Calculate previous expression and set new left side
                                operation.LeftSide = CalculateOperation(operation);

                                // Set new operator
                                operation.OperationType = operatorType;

                                // Clear the previous right side
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            // Get the operator type
                            var operatorType = GetOperationType(userInput[i]);

                            // Check if there is a left side number
                            if (operation.LeftSide.Length == 0)
                            {
                                // Check if the operator is not a minus, for negetive values
                                if (operatorType != OperationType.Minus)
                                {
                                    throw new InvalidOperationException($"Operator for {operatorType} expression specified without a left side number");
                                }

                                // Adding the negetive to the left side term
                                operation.LeftSide += userInput[i];
                            }
                            else
                            {
                                // Moving to the right side

                                // Set the operation type
                                operation.OperationType = operatorType;

                                // Move to the right side
                                leftSide = false;
                            }
                        }
                    }


                }

                // Calculate current operation
                return CalculateOperation(operation);
            }
            catch (Exception ex)
            {
                // Return an error message if an exception occurs during parsing
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculate a <see cref="Operation"/> and returns a result
        /// </summary>
        /// <param name="operation">The operation to calculate</param>
        /// <exception cref="NotImplementedException"></exception>
        private string CalculateOperation(Operation operation)
        {
            // Store the number values of the string representations
            decimal left, right;

            // Check for a valid left side
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
            {
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");
            }
            // Check for a valid right side
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
            {
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.LeftSide}");
            }

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Addition:
                        return (left  + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Division:
                        return (left / right).ToString();
                    case OperationType.Multiplication:
                        return (left * right).ToString();
                    default: 
                        throw new InvalidOperationException($"Unknown operator type when calculating opertion. {operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }
        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+' :
                    return OperationType.Addition;
                case '-' :
                    return OperationType.Minus;
                case '*' :
                    return OperationType.Multiplication;
                case '/' :
                    return OperationType.Division;
                default:
                    throw new InvalidOperationException($"Unknown operator type { character }");
            }
        }

        /// <summary>
        /// Adds a new character to the current number, ensuring validity.
        /// </summary>
        /// <param name="currentNumber">The current number string to which the new character is appended.</param>
        /// <param name="newCharacter">The new character to append.</param>
        /// <returns>The updated number string.</returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // Check if there is already a decimal in the number, throwing an exception if attempting to add another
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a decimal(.) and another cannot be added.");

            // Return the updated number string with the new character appended
            return currentNumber + newCharacter;
        }

        #region Private Helper Methods

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();

            // Set selection length to 0
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // Focuses on the user input text box
            FocusInputText();
        }

        #endregion
    }
}
