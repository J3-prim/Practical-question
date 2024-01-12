using System.Collections;

namespace Practical_question
{
    public partial class Form1 : Form
    {
        ArrayList enteredWords = new ArrayList();
        ArrayList concatenatedWords = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected1 = "";
            string selected2 ="";

            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked)
                {
                    if (comboBox1.SelectedIndex==-1)
                    {
                        MessageBox.Show("Please select item to remove");
                    }
                    else
                    {
                        comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    }
                }
                if (radioButton2.Checked)
                {
                    if (comboBox2.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select item to remove");
                    }
                    else
                    {
                        comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
                    }
                }
                return;
            }
            else
            {
                if (comboBox2.SelectedItem == null||comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a wrod from both combo boxes");
                    return;

                } else {
                     selected1 = comboBox1.SelectedItem.ToString();
                     selected2 = comboBox2.SelectedItem.ToString();
                }
                if (selected1 == selected2)
                {
                    MessageBox.Show("Cannot combine the same word");
                    return;
                }
                else
                {
                    concatenatedWords.Add(selected1+selected2);
                    label1.Text = selected1+selected2;
                    MessageBox.Show("Word " +selected1+selected2+" added to concatenated list");
                    return;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string words in enteredWords)
            {
                if (textBox1.Text == words)
                {
                    MessageBox.Show("Word has already been entered");
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("No word entered");
                return;
            }
            enteredWords.Add(textBox1.Text);
            comboBox1.Items.Add(textBox1.Text);
            comboBox2.Items.Add(textBox1.Text);
            MessageBox.Show("New word successfully entered");
            textBox1.Text = ""; 

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
   
            if (radioButton1.Checked)
            {
                button2.Text = "Remove item";
            }
            else
            {
                button2.Text = "Concatenate";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button2.Text = "Remove item";
            }
            else
            {
                button2.Text = "Concatenate";
            }
        }
    }
}
