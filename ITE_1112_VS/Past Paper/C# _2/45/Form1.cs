using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45
{
    public partial class Form1 : Form
    {
        int count;
        public Form1()
        {
            InitializeComponent();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count > 0)
            {
                foreach (string Sentence in listBox1.Items)
                {


                    //string Sentence = listBox1.Text;
                    string ReplacedConsonentAndVowel = ReplacingConsonentAndVowel(Sentence);
                    string ReplacedPunctuationMarked = ReplacingPunctuationMarked(ReplacedConsonentAndVowel);

                    MatchEvaluator nfEvaluator = new MatchEvaluator(NumberFlip);
                    ReplacedPunctuationMarked = Regex.Replace(ReplacedPunctuationMarked, numbersFP, nfEvaluator);
                    listBox2.Items.Add(ReplacedPunctuationMarked);
                }
            }
        }
            public bool IsVowel(char character)
            {
                if (character != 'A' && character != 'E' && character != 'I' && character != 'O' && character != 'U' && character != 'a' && character != 'e' && character != 'i' && character != 'o' && character != 'u')
                {
                    return false;
                }

                return true;
            }



            public bool IsConsonent(char character)
            {
                if (character != 'B' && character != 'C' && character != 'D' && character != 'F' && character != 'G' && character != 'H' && character != 'J' && character != 'K' && character != 'L' && character != 'M'
                    && character != 'N' && character != 'P' && character != 'Q' && character != 'R' && character != 'S' && character != 'T' && character != 'V' && character != 'W' && character != 'X' && character != 'Y' && character != 'Z'
                    && character != 'b' && character != 'c' && character != 'd' && character != 'f' && character != 'g' && character != 'h' && character != 'j' && character != 'k' && character != 'l' && character != 'm'
                    && character != 'n' && character != 'p' && character != 'q' && character != 'r' && character != 's' && character != 't' && character != 'v' && character != 'w' && character != 'x' && character != 'y' && character != 'z')
                {
                    return false;
                }

                return true;
            }


            public string ReplacingConsonentAndVowel(string s)
            {
                char[] allCharcterInSentence = s.ToCharArray();
                for (int i = 0; i < allCharcterInSentence.Length; i++)
                {
                    if (IsConsonent(allCharcterInSentence[i]))
                    {
                        if (allCharcterInSentence[i] == 'b')
                        {
                            allCharcterInSentence[i] = 'f';
                        }
                        else if (allCharcterInSentence[i] == 'B')
                        {
                            allCharcterInSentence[i] = 'F';
                        }
                        else if (allCharcterInSentence[i] == 'c')
                        {
                            allCharcterInSentence[i] = 'g';
                        }
                        else if (allCharcterInSentence[i] == 'C')
                        {
                            allCharcterInSentence[i] = 'G';
                        }
                        else if (allCharcterInSentence[i] == 'd')
                        {
                            allCharcterInSentence[i] = 'h';
                        }
                        else if (allCharcterInSentence[i] == 'D')
                        {
                            allCharcterInSentence[i] = 'H';
                        }
                        else if (allCharcterInSentence[i] == 'f')
                        {
                            allCharcterInSentence[i] = 'j';
                        }
                        else if (allCharcterInSentence[i] == 'F')
                        {
                            allCharcterInSentence[i] = 'J';
                        }
                        else if (allCharcterInSentence[i] == 'g')
                        {
                            allCharcterInSentence[i] = 'k';
                        }
                        else if (allCharcterInSentence[i] == 'G')
                        {
                            allCharcterInSentence[i] = 'K';
                        }
                        else if (allCharcterInSentence[i] == 'h')
                        {
                            allCharcterInSentence[i] = 'l';
                        }
                        else if (allCharcterInSentence[i] == 'H')
                        {
                            allCharcterInSentence[i] = 'L';
                        }
                        else if (allCharcterInSentence[i] == 'j')
                        {
                            allCharcterInSentence[i] = 'm';
                        }
                        else if (allCharcterInSentence[i] == 'J')
                        {
                            allCharcterInSentence[i] = 'M';
                        }
                        else if (allCharcterInSentence[i] == 'k')
                        {
                            allCharcterInSentence[i] = 'n';
                        }
                        else if (allCharcterInSentence[i] == 'K')
                        {
                            allCharcterInSentence[i] = 'N';
                        }
                        else if (allCharcterInSentence[i] == 'l')
                        {
                            allCharcterInSentence[i] = 'p';
                        }
                        else if (allCharcterInSentence[i] == 'L')
                        {
                            allCharcterInSentence[i] = 'P';
                        }
                        else if (allCharcterInSentence[i] == 'm')
                        {
                            allCharcterInSentence[i] = 'q';
                        }
                        else if (allCharcterInSentence[i] == 'M')
                        {
                            allCharcterInSentence[i] = 'Q';
                        }
                        else if (allCharcterInSentence[i] == 'n')
                        {
                            allCharcterInSentence[i] = 'r';
                        }
                        else if (allCharcterInSentence[i] == 'N')
                        {
                            allCharcterInSentence[i] = 'R';
                        }
                        else if (allCharcterInSentence[i] == 'p')
                        {
                            allCharcterInSentence[i] = 's';
                        }
                        else if (allCharcterInSentence[i] == 'P')
                        {
                            allCharcterInSentence[i] = 'S';
                        }
                        else if (allCharcterInSentence[i] == 'q')
                        {
                            allCharcterInSentence[i] = 't';
                        }
                        else if (allCharcterInSentence[i] == 'Q')
                        {
                            allCharcterInSentence[i] = 'T';
                        }
                        else if (allCharcterInSentence[i] == 'r')
                        {
                        allCharcterInSentence[i] = 'v';
                        }
                        else if (allCharcterInSentence[i] == 'R')
                        {
                            allCharcterInSentence[i] = 'V';
                        }
                        else if (allCharcterInSentence[i] == 's')
                        {
                            allCharcterInSentence[i] = 'w';
                        }
                        else if (allCharcterInSentence[i] == 'S')
                        {
                            allCharcterInSentence[i] = 'W';
                        }
                        else if (allCharcterInSentence[i] == 't')
                        {
                            allCharcterInSentence[i] = 'x';
                        }
                        else if (allCharcterInSentence[i] == 'T')
                        {
                            allCharcterInSentence[i] = 'X';
                        }
                        else if (allCharcterInSentence[i] == 'v')
                        {
                            allCharcterInSentence[i] = 'y';
                        }
                        else if (allCharcterInSentence[i] == 'V')
                        {
                            allCharcterInSentence[i] = 'Y';
                        }
                        else if (allCharcterInSentence[i] == 'w')
                        {
                            allCharcterInSentence[i] = 'z';
                        }
                        else if (allCharcterInSentence[i] == 'W')
                        {
                            allCharcterInSentence[i] = 'Z';
                        }
                        else if (allCharcterInSentence[i] == 'x')
                        {
                            allCharcterInSentence[i] = 'b';
                        }
                        else if (allCharcterInSentence[i] == 'X')
                        {
                            allCharcterInSentence[i] = 'B';
                        }
                        else if (allCharcterInSentence[i] == 'y')
                        {
                            allCharcterInSentence[i] = 'c';
                        }
                        else if (allCharcterInSentence[i] == 'Y')
                        {
                            allCharcterInSentence[i] = 'C';
                        }
                        else if (allCharcterInSentence[i] == 'z')
                        {
                            allCharcterInSentence[i] = 'd';
                        }
                        else
                        {
                            allCharcterInSentence[i] = 'D';
                        }

                    }
                    else if (IsVowel(allCharcterInSentence[i]))
                    {
                        if (allCharcterInSentence[i] == 'a')
                        {
                            allCharcterInSentence[i] = 'o';
                        }
                        else if (allCharcterInSentence[i] == 'A')
                        {
                            allCharcterInSentence[i] = 'O';
                        }
                        else if (allCharcterInSentence[i] == 'e')
                        {
                            allCharcterInSentence[i] = 'u';
                        }
                        else if (allCharcterInSentence[i] == 'E')
                        {
                            allCharcterInSentence[i] = 'U';
                        }
                        else if (allCharcterInSentence[i] == 'i')
                        {
                            allCharcterInSentence[i] = 'a';
                        }
                        else if (allCharcterInSentence[i] == 'I')
                        {
                            allCharcterInSentence[i] = 'A';
                        }
                        else if (allCharcterInSentence[i] == 'o')
                        {
                            allCharcterInSentence[i] = 'e';
                        }
                        else if (allCharcterInSentence[i] == 'O')
                        {
                            allCharcterInSentence[i] = 'E';
                        }
                        else if (allCharcterInSentence[i] == 'u')
                        {
                            allCharcterInSentence[i] = 'i';
                        }
                        else
                        {
                            allCharcterInSentence[i] = 'I';
                        }
                    }
                    else if (IsPunctuationMark(allCharcterInSentence[i]))
                    {
                        allCharcterInSentence[i] = '#';
                    }

                }
                string Output = new string(allCharcterInSentence);
                return Output;


            }







            public bool IsPunctuationMark(char character)
            {
                if (character != '.' && character != '!' && character != '?')
                {
                    return false;
                }

                return true;
            }

            public static string ReplacingPunctuationMarked(string input2)
            {
                input2 = Regex.Replace(input2, "[\"',)(;:[-]", "");
                return input2;
            }

            public static string numbersFP = @"\d+";

            public static string NumberFlip(Match match)
            {
                char[] Nb = match.Value.ToString().ToCharArray();
                Array.Reverse(Nb);
                return (int.Parse(string.Join("", Nb)) * 2).ToString();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count < 5)
            { 

                if (!(string.IsNullOrEmpty(textBox1.Text)))
                {
                    listBox1.Items.Add(textBox1.Text);

                    textBox1.Text = "";
                    textBox1.Focus();

                }
                else
                {
                    MessageBox.Show("Please enter a valid string");
                }
                count++;
            }
            else
            {
                MessageBox.Show("Please enter a sentence");
            }
        }
    }
}
   

