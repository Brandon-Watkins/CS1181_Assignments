using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmRandomNumberDistribution
{
    public partial class frmStatsTable : Form
    {
        frmRandomNumberDistribution formRND;

        public frmStatsTable(frmRandomNumberDistribution formRND) // argument requests the variables from main form
        {
            InitializeComponent();
            this.formRND = formRND;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Owner.Show();// shows main form
            this.Close();
        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            formRND.SaveResults();
        }

        private void frmStatsTable_Load(object sender, EventArgs e)
        {
            formRND.DisplayStatsTable(((frmStatsTable)this).lbPrintedResults, formRND.statsTable);
        }
        
    }
}
