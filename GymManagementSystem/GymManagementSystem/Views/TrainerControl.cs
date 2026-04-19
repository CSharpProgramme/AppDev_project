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
    public partial class TrainerControl : UserControl
    {
        public TrainerControl()
        {
            InitializeComponent();
        }

        private void trainerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trainerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymManagementDBDataSet);

        }
    }
}
