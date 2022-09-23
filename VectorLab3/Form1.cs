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

        private void txtXFirst_TextChanged(object sender, EventArgs e)
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
                
                var sumVectorZ = firstCoordinateZ + secondCoordinateZ;

                txtXResult.Text = sumVectorX.Verbose();
            }
            catch
            {

            }
        }
    }
}
