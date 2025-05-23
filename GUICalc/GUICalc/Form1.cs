using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GuiCalc numbers = new GuiCalc();
            numbers.Number1 = Convert.ToInt32(txtNumber1.Text);
            numbers.Number2 = Convert.ToInt32(txtNumber2.Text);
            lblResult.Text = Convert.ToString(numbers.Add());
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            GuiCalc numbers = new GuiCalc();
            numbers.Number1 = Convert.ToInt32(txtNumber1.Text);
            numbers.Number2 = Convert.ToInt32(txtNumber2.Text);
            lblResult.Text = Convert.ToString(numbers.Sub());
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            GuiCalc numbers = new GuiCalc();
            numbers.Number1 = Convert.ToInt32(txtNumber1.Text);
            numbers.Number2 = Convert.ToInt32(txtNumber2.Text);
            lblResult.Text = Convert.ToString(numbers.Divide());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GuiCalc numbers = new GuiCalc();
            numbers.Number1 = Convert.ToInt32(txtNumber1.Text);
            numbers.Number2 = Convert.ToInt32(txtNumber2.Text);
            lblResult.Text = Convert.ToString(numbers.Multiply());
        }
    }
}
