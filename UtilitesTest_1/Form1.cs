using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSpace_1
{
    public partial class MainForm1 : Form
    {
        int count = 0;
        Random rnd;
        int n;
        char[] spec_chars = new char[] { '%', '*', ')', '?', '#', '$', '&', '~', '^' };
        Dictionary<string, double> metrica;

        public MainForm1()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Утилитки", "О программе");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = count.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            count--;
            labelCount.Text = count.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            count=0;
            labelCount.Text = Convert.ToString(count);
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
            labelRandom.Text = n.ToString();
            if (checkBoxRandom.Checked)
            {
                int i = 0;

                while (textBoxRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
                    i++;
                    if (i > 1000) break;
                }
                if (i<=1000) textBoxRandom.AppendText(n + "\n");
            }
            else textBoxRandom.AppendText(n + "\n");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRandom.Clear();
        }

        private void buttonRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxRandom.Text);
        }

        private void InsertDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.AppendText(DateTime.Now.ToShortDateString());
        }

        private void InsertTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxNotepad.AppendText(DateTime.Now.ToShortTimeString());
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка записи.", "Ошибка");
            }
        }


        void LoadNotepad()
        {
            try
            {
                richTextBoxNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка чтения.", "Ошибка");
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            LoadNotepad();
            checkedListBoxPass.SetItemChecked(0, true);
        }

        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            if (checkedListBoxPass.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < numericUpDownPassLenght.Value; i++)
            {
                int n = rnd.Next(0, checkedListBoxPass.CheckedItems.Count);
                string s = checkedListBoxPass.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры": password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_chars[rnd.Next(rnd.Next(spec_chars.Length))];
                        break;
                }
                textBoxPass.Text = password;
                Clipboard.SetText(password);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[comboBoxFrom.Text];
            double m2 = metrica[comboBoxTo.Text];
            double n = Convert.ToDouble(textBoxFrom.Text);
            textBoxTo.Text = (n * m1 / m2).ToString();
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            string t = comboBoxFrom.Text;
            comboBoxFrom.Text = comboBoxTo.Text;
            comboBoxTo.Text = t;
        }

        private void comboBoxMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMetric.Text)
            {
                case "длина":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 1609344);
                    comboBoxFrom.Items.Clear();
                    comboBoxFrom.Items.Add("mm");
                    comboBoxFrom.Items.Add("cm");
                    comboBoxFrom.Items.Add("dm");
                    comboBoxFrom.Items.Add("m");
                    comboBoxFrom.Items.Add("km");
                    comboBoxFrom.Items.Add("mile");
                    comboBoxTo.Items.Clear();
                    comboBoxTo.Items.Add("mm");
                    comboBoxTo.Items.Add("cm");
                    comboBoxTo.Items.Add("dm");
                    comboBoxTo.Items.Add("m");
                    comboBoxTo.Items.Add("km");
                    comboBoxTo.Items.Add("mile");
                    comboBoxFrom.Text = "mm";
                    comboBoxTo.Text = "mm";
                    break;
                case "вес":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 28.3);

                    comboBoxFrom.Items.Clear();
                    comboBoxFrom.Items.Add("g");
                    comboBoxFrom.Items.Add("kg");
                    comboBoxFrom.Items.Add("t");
                    comboBoxFrom.Items.Add("lb");
                    comboBoxFrom.Items.Add("oz");

                    comboBoxTo.Items.Clear();
                    comboBoxTo.Items.Add("g");
                    comboBoxTo.Items.Add("kg");
                    comboBoxTo.Items.Add("t");
                    comboBoxTo.Items.Add("lb");
                    comboBoxTo.Items.Add("oz");

                    comboBoxFrom.Text = "g";
                    comboBoxTo.Text = "g";
                    break;
                default:
                    break;
            }
        }
    }
}
