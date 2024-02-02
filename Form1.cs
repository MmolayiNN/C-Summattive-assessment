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

namespace C___Summattive_assessment
{
    public partial class Form1 : Form
    {

        private List<string> wordList = new List<string>();

        ArrayList wordsList = new ArrayList();
        ArrayList concatenatedWordsList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                string newWord = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(newWord))
                {
                    MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (label4.Text.Contains(newWord))
                {
                    MessageBox.Show("The word has already been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (label4.Text.Contains(newWord) || label4.Text == newWord)
                {
                    MessageBox.Show("Please enter a different word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrEmpty(label4.Text))
                {
                    label4.Text += " ";
                }

                label4.Text += newWord;

                MessageBox.Show("New word has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void Form1_Load(object sender, EventArgs e)
        {
             // Populate ComboBox controls with initial values
                comboBox1.Items.AddRange(new object[] { "Good", "Day", "Spanish", "Nelca", "Korea" });
                comboBox2.Items.AddRange(new object[] { "Morning", "Grey", "German","Africa","Korea" });            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                RemoveWord();
            }
            else if (radioButton2.Checked)
            {
                RemoveWord();
            }

        }
            private void ConcatenateWords()
            {
                string selectedWord1 = comboBox1.SelectedItem?.ToString();
                string selectedWord2 = comboBox2.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedWord1) || string.IsNullOrEmpty(selectedWord2))
                {
                    MessageBox.Show("Please select a word from both ComboBox controls.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedWord1 == selectedWord2)
                {
                    MessageBox.Show("Please select different words from each ComboBox control.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string concatenatedWord = selectedWord1 + " " + selectedWord2;
                label4.Text = concatenatedWord;
                concatenatedWordsList.Add(concatenatedWord);

                MessageBox.Show("Concatenated word: " + concatenatedWord, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void RemoveWord()
            {
                ComboBox comboBoxToRemoveFrom = radioButton1.Checked ? comboBox1 : comboBox2;

                if (comboBoxToRemoveFrom.SelectedItem == null)
                {
                    MessageBox.Show("Please select a word from the selected ComboBox control.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string wordToRemove = comboBoxToRemoveFrom.SelectedItem.ToString();
                comboBoxToRemoveFrom.Items.Remove(wordToRemove);
                MessageBox.Show("Word removed: " + wordToRemove, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        
    }
}

