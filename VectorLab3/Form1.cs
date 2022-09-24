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
                var firstCoordinateX = double.Parse(txtXFirst.Text);
                var firstCoordinateY = double.Parse(txtYFirst.Text);
                var firstCoordinateZ = double.Parse(txtZFirst.Text);
                var secondCoordinateX = double.Parse(txtXSecond.Text);
                var secondCoordinateY = double.Parse(txtYSecond.Text);
                var secondCoordinateZ = double.Parse(txtZSecond.Text);
                             
                var firstVectorCoordinateX = new Vector(firstCoordinateX);
                var firstVectorCoordinateY = new Vector(firstCoordinateY);
                var firstVectorCoordinateZ = new Vector(firstCoordinateZ);
                var secondVectorCoordinateX = new Vector(secondCoordinateX);
                var secondVectorCoordinateY = new Vector(secondCoordinateY);
                var secondVectorCoordinateZ = new Vector(secondCoordinateZ);

                Vector sumVectorX;
                Vector sumVectorY;
                Vector sumVectorZ;
                Vector multiVectorX;
                Vector multiVectorY;
                Vector multiVectorZ;
                Vector multiVector;
                Vector lengthOfVectorFirst;
                Vector lengthOfVectorSecond;
                Vector lengthOfVectorResult;
                switch (cmbOperation.Text)
                {
                    case "+":
                        sumVectorX = firstVectorCoordinateX + secondVectorCoordinateX;
                        sumVectorY = firstVectorCoordinateY + secondVectorCoordinateY;
                        sumVectorZ = firstVectorCoordinateZ + secondVectorCoordinateZ;
                        multiVector = sumVectorX + sumVectorY + sumVectorZ;
                        multiVectorX = firstVectorCoordinateX * secondVectorCoordinateX;
                        multiVectorY = firstVectorCoordinateY * secondVectorCoordinateY;
                        multiVectorZ = firstVectorCoordinateZ * secondVectorCoordinateZ;
                        multiVector = multiVectorX + multiVectorY + multiVectorZ;
                        lengthOfVectorFirst = new Vector(Math.Sqrt(Math.Pow(firstCoordinateX, 2)
                        + Math.Pow(firstCoordinateY, 2) + Math.Pow(firstCoordinateZ, 2)));
                        lengthOfVectorSecond = new Vector(Math.Sqrt(Math.Pow(secondCoordinateX, 2)
                        + Math.Pow(secondCoordinateY, 2) + Math.Pow(secondCoordinateZ, 2)));
                        lengthOfVectorResult = new Vector(Math.Sqrt(Math.Pow(firstCoordinateX + secondCoordinateX, 2)
                        + Math.Pow(firstCoordinateY + secondCoordinateY, 2) + Math.Pow(firstCoordinateZ + secondCoordinateZ, 2)));

                        break;
                    case "-":
                        sumVectorX = firstVectorCoordinateX - secondVectorCoordinateX;
                        sumVectorY = firstVectorCoordinateY - secondVectorCoordinateY;
                        sumVectorZ = firstVectorCoordinateZ - secondVectorCoordinateZ;
                        multiVectorX = firstVectorCoordinateX * secondVectorCoordinateX;
                        multiVectorY = firstVectorCoordinateY * secondVectorCoordinateY;
                        multiVectorZ = firstVectorCoordinateZ * secondVectorCoordinateZ;
                        multiVector = multiVectorX + multiVectorY + multiVectorZ;
                        lengthOfVectorFirst = new Vector(Math.Sqrt(Math.Pow(firstCoordinateX, 2)
                        + Math.Pow(firstCoordinateY, 2) + Math.Pow(firstCoordinateZ, 2)));
                        lengthOfVectorSecond = new Vector(Math.Sqrt(Math.Pow(secondCoordinateX, 2)
                        + Math.Pow(secondCoordinateY, 2) + Math.Pow(secondCoordinateZ, 2)));
                        lengthOfVectorResult = new Vector(Math.Sqrt(Math.Pow(firstCoordinateX - secondCoordinateX, 2)
                        + Math.Pow(firstCoordinateY - secondCoordinateY, 2) + Math.Pow(firstCoordinateZ - secondCoordinateZ, 2)));
                        break;
                    case "Векторное произведение":
                        sumVectorX = (firstVectorCoordinateY * secondVectorCoordinateZ) - (firstVectorCoordinateZ * secondVectorCoordinateY);
                        sumVectorY = (firstVectorCoordinateZ * secondVectorCoordinateX) - (firstVectorCoordinateX * secondVectorCoordinateZ);
                        sumVectorZ = (firstVectorCoordinateX * secondVectorCoordinateY) - (firstVectorCoordinateY * secondVectorCoordinateX);
                        multiVectorX = firstVectorCoordinateX * secondVectorCoordinateX;
                        multiVectorY = firstVectorCoordinateY * secondVectorCoordinateY;
                        multiVectorZ = firstVectorCoordinateZ * secondVectorCoordinateZ;
                        multiVector = multiVectorX + multiVectorY + multiVectorZ;
                        lengthOfVectorFirst = new Vector(Math.Sqrt(Math.Pow(firstCoordinateX, 2)
                        + Math.Pow(firstCoordinateY, 2) + Math.Pow(firstCoordinateZ, 2)));
                        lengthOfVectorSecond = new Vector(Math.Sqrt(Math.Pow(secondCoordinateX, 2)
                        + Math.Pow(secondCoordinateY, 2) + Math.Pow(secondCoordinateZ, 2)));
                        lengthOfVectorResult = Vector.Radical(Vector.Extent(sumVectorX, 2)
                        + Vector.Extent(sumVectorY, 2) + Vector.Extent(sumVectorZ, 2));
                        break;
                    default:
                        sumVectorX = new Vector(0);
                        sumVectorY = new Vector(0);
                        sumVectorZ = new Vector(0);
                        multiVector = new Vector(0);
                        lengthOfVectorFirst = new Vector(0);
                        lengthOfVectorSecond = new Vector(0);
                        lengthOfVectorResult = new Vector(0);
                        break;
                }

                txtXResult.Text = Convert.ToString(sumVectorX.Verbose());
                txtYResult.Text = Convert.ToString(sumVectorY.Verbose());
                txtZResult.Text = Convert.ToString(sumVectorZ.Verbose());
                txtMulti.Text = Convert.ToString(multiVector.Verbose());
                txtLenghtFirst.Text = Convert.ToString(lengthOfVectorFirst.Verbose());
                textLenghtSecond.Text = Convert.ToString(lengthOfVectorSecond.Verbose());
                txtLengtResult.Text = Convert.ToString(lengthOfVectorResult.Verbose());
            }
            catch (FormatException)
            {

            }
        }

        private void txtXFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtXSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtYFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtYSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtZFirst_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtZSecond_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
