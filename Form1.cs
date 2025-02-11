using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int GetStr) && int.TryParse(textBox2.Text, out int nMP) && int.TryParse(comboBox1.Text, out int dwSkillLevel))
            {
                int[] nAddDmgValues = { 0, 20, 30, 40, 50, 60, 70, 80, 90, 100, 150 };
                if (dwSkillLevel >= 1 && dwSkillLevel <= 10)
                {
                    int nAddDmg = nAddDmgValues[dwSkillLevel];
                    int result = (((GetStr / 10) * dwSkillLevel) * (5 + nMP / 10) + nAddDmg);
                    label4.Text = "Damage Output: " + result.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please ensure all fields are filled out.");
            }
        }
    }
}
