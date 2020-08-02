using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BIndGrid();
        }
        private void BIndGrid()
        {
            using (MvcShopEntities db = new MvcShopEntities())
            {
                dgContacts.AutoGenerateColumns = false;
                dgContacts.Columns[0].Visible = false;
                dgContacts.DataSource = db.MyContacts.ToList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BIndGrid();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frm = new frmAddOrEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BIndGrid ();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frm = new frmAddOrEdit();
                frm.contactId = contactId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BIndGrid();
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (MvcShopEntities  db = new MvcShopEntities())
            {
                dgContacts.DataSource = db.MyContacts
                    .Where(c => c.Name.Contains(txtSearch.Text) || c.Family.Contains(txtSearch.Text)).ToList();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                string name = dgContacts.CurrentRow.Cells[1].Value.ToString();
                string family = dgContacts.CurrentRow.Cells[2].Value.ToString();
                string fullName = name + " " + family;
                if (MessageBox.Show($"آیا از حذف {fullName} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                    using (MvcShopEntities db = new MvcShopEntities())
                    {
                        MyContacts cotact = db.MyContacts.SingleOrDefault(c => c.ContactID==contactId);
                     db.SaveChanges();
                   }
                    BIndGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک شخص را از لیست انتخاب کنید");
            }

        }
    }
}