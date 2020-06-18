using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseCompareTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void browseForFirstDB_Click(object sender, EventArgs e)
        {
            using (var picker = new DatabasePicker(secondDBTextBox.Text))
            {
                var result = picker.ShowDialog();
                if (result == DialogResult.OK)
                {
                    firstDBTextBox.Text = picker.SelectedDatabase;
                }
            }
        }

        private void browseForSecondDB_Click(object sender, EventArgs e)
        {
            using (var picker = new DatabasePicker(firstDBTextBox.Text))
            {
                var result = picker.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Console.WriteLine("Hello World!");
                    secondDBTextBox.Text = picker.SelectedDatabase;
                }
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstDBTextBox.Text = null;
            secondDBTextBox.Text = null;
        }
    }
}
