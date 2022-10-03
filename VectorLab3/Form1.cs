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
                Vector dotSum = new Vector(0, 0, 0);
                double multiVector;
                switch (cmbOperation.Text)
                {
                    case "+":
                        resultVector = firstVector + secondVector;
                        txtResultX.Text = resultVector.VerboseX();
                        txtResultY.Text = resultVector.VerboseY();
                        txtResultZ.Text = resultVector.VerboseZ();
                        txtDotMulti.Text = Convert.ToString(multiVector = secondVector.DotProductOfVector(firstVector));
                        txtLengthFirst.Text = Convert.ToString(multiVector = firstVector.VectorLength());
                        txtLengthSecond.Text = Convert.ToString(multiVector = secondVector.VectorLength());
                        txtLengthResult.Text = Convert.ToString(multiVector = resultVector.VectorLength());
                        break;
                    case "-":
                        resultVector = firstVector - secondVector;
                        txtResultX.Text = resultVector.VerboseX();
                        txtResultY.Text = resultVector.VerboseY();
                        txtResultZ.Text = resultVector.VerboseZ();
                        txtDotMulti.Text = Convert.ToString(multiVector = secondVector.DotProductOfVector(firstVector));
                        txtLengthFirst.Text = Convert.ToString(multiVector = firstVector.VectorLength());
                        txtLengthSecond.Text = Convert.ToString(multiVector = secondVector.VectorLength());
                        txtLengthResult.Text = Convert.ToString(multiVector = resultVector.VectorLength());
                        break;
                    case "Векторное произведение":
                        resultVector = firstVector * secondVector;
                        txtResultX.Text = resultVector.VerboseX();
                        txtResultY.Text = resultVector.VerboseY();
                        txtResultZ.Text = resultVector.VerboseZ();
                        txtDotMulti.Text = Convert.ToString(multiVector = secondVector.DotProductOfVector(firstVector));
                        txtLengthFirst.Text = Convert.ToString(multiVector = firstVector.VectorLength());
                        txtLengthSecond.Text = Convert.ToString(multiVector = secondVector.VectorLength());
                        txtLengthResult.Text = Convert.ToString(multiVector = resultVector.VectorLength());
                        break;
                    default:
                        firstVector = new Vector(0, 0, 0);
                        secondVector = new Vector(0, 0, 0);
                        break;
                }
            }
            catch (FormatException)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtFirstY_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtFirstZ_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtSecondX_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtSecondY_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtSecondZ_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
