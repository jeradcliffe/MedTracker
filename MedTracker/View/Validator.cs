using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedTracker.View
{
    /// <summary>
    /// Class taken from chapter 7 section 1 of
    /// Murach's ADO.Net 4 Database Programming with C# 2010.
    /// </summary>
    class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>
        /// Checks to see if there is text present in a text box
        /// or a combo box control.
        /// </summary>
        /// <param name="control">Control to be validated.</param>
        /// <returns>True if proper text present of value selected.</returns>
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show(textBox.Tag.ToString() + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", Title);
                    comboBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks to see if there is proper length of input text in order
        /// to avoid truncation by our DB.
        /// </summary>
        /// <param name="control">Control that we are focused on checking.</param>
        /// <returns>True if text is too long for DB.</returns>
        public static bool IsTooLong(Control control, int maxTextLength)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text.Length > maxTextLength)
                {
                    MessageBox.Show(textBox.Tag.ToString() + " may only be " +
                        maxTextLength + " characters long.", Title);
                    textBox.Focus();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Keep this else statement in the case that we need to check controls
            // other than just a text box. 
            else
                MessageBox.Show("Invalid control type entered.\n Can't validate length of text", Title);
            return true;
        }

        /// <summary>
        /// Checks to see if value input to a text box is a decimal.
        /// </summary>
        /// <param name="textBox">Textbox that holds the value.</param>
        /// <returns>True if value is a decimal. False otherwise.</returns>
        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks to see value input to if value input to a text box is an integer.
        /// </summary>
        /// <param name="textBox">Textbox that holds the value.</param>
        /// <returns>True if value is an integer. False otherwise</returns>
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be an integer value.", Title);
                textBox.Focus();
                return false;
            }
        }
    }
}
