using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlConnector;

namespace DatabaseCompareTool
{
    public partial class DatabasePicker : Form
    {
        public string SelectedDatabase;
        private string selectionFromAlternateTextBox;
        public DatabasePicker(string selectionFromAlternateTextBox)
        {
            InitializeComponent();
            this.selectionFromAlternateTextBox = selectionFromAlternateTextBox;
        }

        private void DatabasePicker_Load(object sender, EventArgs e)
        {
            var database = Database.GetDatabaseList();
            if (database.Contains(selectionFromAlternateTextBox))
            {
                database.Remove(selectionFromAlternateTextBox);
            }

            databaseList.DataSource = database;
        }

        private void chooseDataBase_Click(object sender, EventArgs e)
        {
            if(databaseList.SelectedItem != null)
            {
                DialogResult = DialogResult.OK;
                SelectedDatabase = (string) databaseList.Items[databaseList.SelectedIndex];
                Close();
            }
        }
    }
}
