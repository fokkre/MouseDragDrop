using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MouseDrag
{
    public partial class Form1 : Form
    {
        MouseDragDrop dragDrop = new MouseDragDrop();

        public Form1()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            int selectedValue = (int)newDragNum.Value;
            dragDrop.SetDragValues(selectedValue);
            dragHeightCurrent.Text = MouseDragDrop.CurrentDrag().Item1;
            dragWidthCurrent.Text = MouseDragDrop.CurrentDrag().Item2;
        }
    }
}
