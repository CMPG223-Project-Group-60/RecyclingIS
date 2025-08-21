using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecyclingIS
{
    public partial class frmUpdateItem : Form
    {
        public string ItemName => txtItemName.Text;
        public int ItemQty => int.Parse(dudQty.Text);
        public string ItemDescription => txtDescription.Text;

        public frmUpdateItem()
        {
            InitializeComponent();
        }

        public frmUpdateItem(string name, int quantity, string description)
        {
            InitializeComponent();
            txtItemName.Text = name;
            dudQty.Text = quantity.ToString();
            txtDescription.Text = description;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmUpdateItem_Load(object sender, EventArgs e)
        {

        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }
    }
}
