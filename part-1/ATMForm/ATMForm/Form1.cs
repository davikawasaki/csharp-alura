using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int accountNumber = 1;
            double balance = 100.0;
            double value = 10.0;
            double valueAfterWithdrawl = balance - value;

            MessageBox.Show("Actual balance: " + valueAfterWithdrawl);
        }
    }
}
