using System;
using System.Collections;

namespace Roman_numerals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public static string Translit(string Temp)
        {
            int number = Convert.ToInt32(Temp);
            Numbers[] RN = new Numbers[] { new(1, "I"), new(4, "IV"), new(5, "V"), new(9, "IX"), new(10, "X"), new(40, "XV"), new(50, "L"), new(90, "LC"),
            new(100, "C"), new(400, "CD"), new(500, "D"), new(900, "DM"), new(1000, "M")};
            string RES = "";

            return increaser(RN, number, RES);

            static string increaser(Numbers[] Roman, int n, string res)
            {
                while (n > 0)
                {
                    int i = Roman.Length;
                    while (Roman[i - 1].Numb > n)
                    {
                        i--;
                    }
                    res += Roman[i - 1].Roman;
                    n -=Roman[i - 1].Numb;
                }
                return res;
            }
        }

        public bool Check(string Number)
        {
            int n;
            if (!int.TryParse(Number, out n))
            {
                MessageBox.Show("¬ведите положительное число, больше 0", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (n < 1)
            {
                MessageBox.Show("¬ведите положительное число, больше 0", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            string[] SplitedText = Text.Split(' ');
            for (int i = 0; i < SplitedText.Length; i++)
            {
                if (Check(SplitedText[i]))
                {
                    textBox2.AppendText(Translit(SplitedText[i]) + " ");
                }
            }
            
        }
    }
}