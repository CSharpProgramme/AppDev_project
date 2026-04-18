using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aDMINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aDMINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymManagementDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymManagementDataSet.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter.Fill(this.gymManagementDataSet.ADMIN);

        }
    }
}
