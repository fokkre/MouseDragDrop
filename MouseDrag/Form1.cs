using System;
using System.Windows.Forms;


namespace MouseDrag
{
    public partial class Form1 : Form
    {
        MouseDragDrop dragDrop = new MouseDragDrop();
        const int resetValue = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void updateCurrentDrag()
        {
            dragHeightCurrent.Text = MouseDragDrop.CurrentDrag().Item1;
            dragWidthCurrent.Text = MouseDragDrop.CurrentDrag().Item2;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            int selectedValue = (int)newDragNum.Value;
            dragDrop.SetDragValues(selectedValue);
            updateCurrentDrag();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dragDrop.SetDragValues(resetValue);
            updateCurrentDrag();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
