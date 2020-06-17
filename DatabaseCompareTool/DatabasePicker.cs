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
    public partial class DatabasePicker : Form
    {
        public DatabasePicker(List<string> databases)
        {
            InitializeComponent();
            databaseList.DataSource = databases;
        }
    }
}
