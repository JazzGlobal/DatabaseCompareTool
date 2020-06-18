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
            firstDBTextBox.Text = GetSelectedDatabase(secondDBTextBox.Text);
        }

        private void browseForSecondDB_Click(object sender, EventArgs e)
        {
            secondDBTextBox.Text = GetSelectedDatabase(firstDBTextBox.Text);
        }
        private String GetSelectedDatabase(string textBoxText)
        {
            using(var picker = new DatabasePicker(textBoxText))
            {
                var result = picker.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return picker.SelectedDatabase;
                }
            }
            return null;
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
