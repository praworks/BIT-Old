using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SentenceEncoder
{
    public partial class MainForm : Form
    {
        private const string Vowels = "AEIOUaeiou";
        private const string Consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
        private const string Punctuation = ".,;:?!";

        private int encodedSentenceCount = 0; // Track the number of encoded sentences
        private bool isConfirmationShown = false; // Flag to track if confirmation dialog has been shown

        public MainForm()
        {
            InitializeComponent();
            btnClear.Click += btnClear_56_Click; // Wire up btnClear_Click event handler
            AddSuffixToControlNames(this, "_56"); // Add suffix "_56" to all control names recursively
        }

        private void btnEncode_56_Click(object sender, EventArgs e)
        {
            if (!isConfirmationShown)
            {
                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Do you agree to the rules and regulations?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    return; // Do not encode if user does not agree
                }

                isConfirmationShown = true; // Set the flag to true after showing the confirmation dialog once
            }

            string sentence = txtSentence_56.Text;
            string encodedSentence = EncodeSentence(sentence);
            DisplayEncodedSentence(encodedSentence);
        }

        private string EncodeSentence(string sentence)
        {
            StringBuilder encodedBuilder = new StringBuilder();

            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    if (Vowels.Contains(c))
                    {
                        char encodedChar = GetNextVowel(c);
                        encodedBuilder.Append(encodedChar);
                    }
                    else if (Consonants.Contains(c))
                    {
                        char encodedChar = GetPreviousConsonant(c);
                        encodedBuilder.Append(encodedChar);
                    }
                }
                else if (char.IsDigit(c))
                {
                    char encodedChar = FlipAndDoubleDigit(c);
                    encodedBuilder.Append(encodedChar);
                }
                else if (Punctuation.Contains(c))
                {
                    encodedBuilder.Append('&');
                }
            }

            return encodedBuilder.ToString();
        }

        private char GetNextVowel(char vowel)
        {
            int index = Vowels.IndexOf(vowel);
            int nextIndex = (index + 2) % Vowels.Length;
            return Vowels[nextIndex];
        }

        private char GetPreviousConsonant(char consonant)
        {
            int index = Consonants.IndexOf(consonant);
            int previousIndex = (index - 1 + Consonants.Length) % Consonants.Length;
            return Consonants[previousIndex];
        }

        private char FlipAndDoubleDigit(char digit)
        {
            int number = int.Parse(digit.ToString());
            int flippedNumber = FlipNumber(number);
            int doubledNumber = DoubleNumber(flippedNumber);
            return (char)(doubledNumber + '0');
        }

        private int FlipNumber(int number)
        {
            string numberString = number.ToString();
            string flippedString = new string(numberString.Reverse().ToArray());
            return int.Parse(flippedString);
        }

        private int DoubleNumber(int number)
        {
            return number * 2;
        }

        private void DisplayEncodedSentence(string encodedSentence)
        {
            encodedSentenceCount++;
            txtEncodedSentences_56.AppendText(encodedSentence);

            if (encodedSentenceCount % 5 == 0)
            {
                txtEncodedSentences_56.AppendText(Environment.NewLine + Environment.NewLine);
            }
            else
            {
                txtEncodedSentences_56.AppendText(" ");
            }
        }

        private void btnClear_56_Click(object sender, EventArgs e)
        {
            txtSentence_56.Clear();
            txtEncodedSentences_56.Clear();
            encodedSentenceCount = 0; // Reset the encoded sentence count
            isConfirmationShown = false; // Reset the confirmation shown flag
        }

        // Recursive method to add suffix to all control names on the form
        private void AddSuffixToControlNames(Control control, string suffix)
        {
            control.Name += suffix;

            foreach (Control childControl in control.Controls)
            {
                AddSuffixToControlNames(childControl, suffix);
            }
        }
    }
}
