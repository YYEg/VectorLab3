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

                var sumVectorX = firstVectorCoordinateX + secondVectorCoordinateX;
                var sumVectorY = firstVectorCoordinateY + secondVectorCoordinateY;
                var sumVectorZ = firstVectorCoordinateZ + secondVectorCoordinateZ;

                txtXResult.Text = Convert.ToString(sumVectorX.Verbose());
                txtYResult.Text = Convert.ToString(sumVectorY.Verbose());
                txtZResult.Text = Convert.ToString(sumVectorZ.Verbose());
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
    }
}
