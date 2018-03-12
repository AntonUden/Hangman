using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Hangman
{
    public partial class gameStart : Form
    {
        public Random rand = new Random();
        public ArrayList words = new ArrayList();
        public string theWord = "";
        public string allUsed = "";

        public gameStart()
        {
            InitializeComponent();
            startGame.Enabled = false;
            stopGame.Enabled = false;
            livesSelector.Value = 10;
            lifeBar.Maximum = int.Parse(livesSelector.Value.ToString());
            guess.Enabled = false;
            lifeBar.Value = 0;
            fileStatus.Text = "No file loaded";
            result.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void oWordList_Click(object sender, EventArgs e)
        {
            wordListFileDialog.ShowDialog();
            if (File.Exists(wordListFileDialog.FileName))
            {
                words.Clear();
                try
                {
                    fileStatus.Text = "Reading file...";
                    string[] lines = File.ReadAllLines(wordListFileDialog.FileName, Encoding.GetEncoding("iso-8859-1"));
                    foreach (string line in lines)
                    {
                        //Console.WriteLine(line);
                        words.Add(line);
                    }
                    Console.WriteLine("Loaded " + words.Count + " words.");
                    fileStatus.Text = words.Count + " words loaded";
                }
                catch (Exception ex)
                {
                    fileStatus.Text = "Error reading file";
                    Console.WriteLine(ex.Message);
                }
                if (words.Count > 0)
                {
                    startGame.Enabled = true;
                    noWordlistError.Visible = false;
                }
                else
                {
                    startGame.Enabled = false;
                    noWordlistError.Visible = true;
                }
            }
            else
            {
                fileStatus.Text = "File not found";
            }
        }

        private void stopGame_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void stop()
        {
            lifeBar.Value = 0;
            livesSelector.Enabled = true;
            startGame.Enabled = true;
            stopGame.Enabled = false;
            oWordList.Enabled = true;
            loadDefault.Enabled = true;
            guess.Enabled = false;
            godmode.Enabled = true;
            startGame.Focus();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            theWord = words[rand.Next(0, words.Count)].ToString().ToLower();
            lifeBar.Maximum = int.Parse(livesSelector.Value.ToString());
            lifeBar.Value = int.Parse(livesSelector.Value.ToString());
            livesSelector.Enabled = false;
            startGame.Enabled = false;
            stopGame.Enabled = true;
            oWordList.Enabled = false;
            loadDefault.Enabled = false;
            guess.Enabled = true;
            godmode.Enabled = false;
            allUsed = "";
            usedLetters.Text = "";
            wordOutput.Text = "";
            result.Text = "";
            updateState();
            guess.Focus();
        }

        private void loadDefault_Click(object sender, EventArgs e)
        {
            words.Clear();
            try
            {
                fileStatus.Text = "Reading file...";
                String lines = Properties.Resources.en_wordlist;

                StringReader reader = new StringReader(lines);
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        words.Add(line);
                    }

                } while (line != null);


                Console.WriteLine("Loaded " + words.Count + " words.");
                fileStatus.Text = words.Count + " words loaded";
            }
            catch (Exception ex)
            {
                fileStatus.Text = "Error reading file";
                Console.WriteLine(ex.Message);
            }
            if (words.Count > 0)
            {
                startGame.Enabled = true;
                noWordlistError.Visible = false;
            }
            else
            {
                startGame.Enabled = false;
                noWordlistError.Visible = true;
            }
        }

        public void updateState()
        {
            if (lifeBar.Value > 0)
            {
                wordOutput.Text = "";
                for (int i = 0; i < theWord.Length; i++)
                {
                    if (allUsed.ToLower().Contains(theWord.ToLower()[i]))
                    {
                        wordOutput.Text += theWord.ToLower()[i] + " ";
                    }
                    else
                    {
                        wordOutput.Text += "_ ";
                    }
                }
                bool win = true;
                for(int j = 0; j < theWord.Length; j++)
                    if (!allUsed.ToLower().Contains(theWord[j]))
                        win = false;
                if(win)
                {
                    result.ForeColor = Color.Green;
                    result.Text = "You won. The word was " + theWord;
                    stop();
                }
            }
            else
            {
                result.ForeColor = Color.Red;
                result.Text = "You lost. The word was " + theWord;
                stop();
            }
        }

        private void guess_TextChanged(object sender, EventArgs e)
        {
            if(guess.Text.Length > 0)
            {
                if(!allUsed.ToLower().Contains(guess.Text.ToLower()[0]))
                {
                    if(theWord.Contains(guess.Text.ToLower()[0]))
                    {
                        allUsed += guess.Text.ToLower()[0];
                    }
                    else
                    {
                        allUsed += guess.Text.ToLower()[0];
                        usedLetters.Text += guess.Text.ToLower()[0] + " ";
                        if(lifeBar.Value > 0 && !godmode.Checked)
                            lifeBar.Value--;
                    }
                }
                updateState();
                guess.Text = "";
            }
        }

        private void godmode_CheckedChanged(object sender, EventArgs e)
        {
            if(godmode.Checked)
            {
                livesSelector.Enabled = false;
            }
            else
            {
                livesSelector.Enabled = true;
            }
        }
    }
}
