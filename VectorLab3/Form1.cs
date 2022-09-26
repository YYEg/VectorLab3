using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            try
            {
                var firstX = double.Parse(txtFirstX.Text);
                var secondX = double.Parse(txtSecondX.Text);
                var firstY = double.Parse(txtFirstY.Text);
                var secondY = double.Parse(txtSecondY.Text);
                var firstZ = double.Parse(txtFirstZ.Text);
                var secondZ = double.Parse(txtSecondZ.Text);

                var firstVector = new Vector(firstX, firstY, firstZ);
                var secondVector = new Vector(secondX, secondY, secondZ);

                Vector resultVector;
                switch (cmbOperation.Text)
                {
                    case "+":
                        resultVector = Vector.VectorSum(firstVector, secondVector);
                        txtResultX.Text = resultVector.VerboseX();
                        txtResultY.Text = resultVector.VerboseY();
                        txtResultZ.Text = resultVector.VerboseZ();
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondZ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
