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
                Vector multiVector;
                switch(cmbOperation.Text)
                {
                    case "+":
                        sumVectorX = firstVectorCoordinateX + secondVectorCoordinateX;
                        sumVectorY = firstVectorCoordinateY + secondVectorCoordinateY;
                        sumVectorZ = firstVectorCoordinateZ + secondVectorCoordinateZ;
                        multiVector = new Vector(0);
                        break;
                    case "-":
                        sumVectorX = firstVectorCoordinateX - secondVectorCoordinateX;
                        sumVectorY = firstVectorCoordinateY - secondVectorCoordinateY;
                        sumVectorZ = firstVectorCoordinateZ - secondVectorCoordinateZ;
                        multiVector = new Vector(0);
                        break;
                    case "Скалярное произведение":
                        sumVectorX = firstVectorCoordinateX * secondVectorCoordinateX;
                        sumVectorY = firstVectorCoordinateY * secondVectorCoordinateY;
                        sumVectorZ = firstVectorCoordinateZ * secondVectorCoordinateZ;
                        multiVector = sumVectorX + sumVectorY + sumVectorZ;
                        sumVectorX = new Vector(0);
                        sumVectorY = new Vector(0);
                        sumVectorZ = new Vector(0);
                        break;
                    case "Векторное произведение":
                        sumVectorX = (firstVectorCoordinateY * secondVectorCoordinateZ) - (firstVectorCoordinateZ * secondVectorCoordinateY);
                        sumVectorY = (firstVectorCoordinateZ * secondVectorCoordinateX) - (firstVectorCoordinateX * secondVectorCoordinateZ);
                        sumVectorZ = (firstVectorCoordinateX * secondVectorCoordinateY) - (firstVectorCoordinateY * secondVectorCoordinateX);
                        multiVector = new Vector(0);
                        break;
                    default:
                        sumVectorX = new Vector(0);
                        sumVectorY = new Vector(0);
                        sumVectorZ = new Vector(0);
                        multiVector = new Vector(0);
                        break;
                }

                txtXResult.Text = Convert.ToString(sumVectorX.Verbose());
                txtYResult.Text = Convert.ToString(sumVectorY.Verbose());
                txtZResult.Text = Convert.ToString(sumVectorZ.Verbose());
                txtMulti.Text = Convert.ToString(multiVector.Verbose());
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
