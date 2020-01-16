using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParamsToFamily
{
    public partial class ParamsDialog : Form
    {
        public string parParentName;
        public string parNestedName;
        public bool ParIsInst;

        public ParamsDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            parParentName = txtbxParParentName.Text;
            parNestedName = txtbxParNestedName.Text;
            if(rbInst.Checked)
            {
                ParIsInst = true;
            }
            else
            {
                ParIsInst = false;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ParamsDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
