using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem.Views
{
    public partial class PTSessionUpsertForm : Form
    {
        public PTSessionUpsertForm()
        {
            InitializeComponent();
        }

        private void PTSessionUpsertForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymManagementDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.gymManagementDBDataSet.Member);

        }
    }
}
