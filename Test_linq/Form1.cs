using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void Btnselect_Click(object sender, EventArgs e)
        //{
        //    StudentDataContext bank = new StudentDataContext();
        //    var query = from p in bank.Students
        //                select p;
        //    Datagridview.DataSource = query;
        //}

        //private void btnupdate_Click(object sender, EventArgs e)
        //{
        //    StudentDataContext bank = new StudentDataContext();
        //    var query = (from p in bank.Students
        //                 where p.ID == int.Parse(txtid.Text)
        //                 select p).Single();
        //    query.Fname = txtfname.Text;
        //    query.Lname = txtlname.Text;
        //    query.Avg = Convert.ToInt16(txtavg.Text);
        //    bank.SubmitChanges();
        //    var q = from p in bank.Students
        //            select p;
        //    Datagridview.DataSource = q;
        //}

        //private void btninsert_Click(object sender, EventArgs e)
        //{
        //    StudentDataContext bank = new StudentDataContext();
        //    Student u = new Student();
        //    u.ID = int.Parse(txtid.Text);
        //    u.Fname = txtfname.Text;
        //    u.Lname = txtlname.Text;
        //    u.Avg = float.Parse(txtavg.Text);
        //    bank.Students.InsertOnSubmit(u);
        //    idnum();
        //    var q = from p in bank.Students
        //            select p;
        //    Datagridview.DataSource = q;

        //}
        //public void idnum()
        //{
        //    int c1 = 0;
        //    StudentDataContext bank = new StudentDataContext();
        //    var query = from p in bank.Students
        //                select new { c1 = p.ID };
        //    txtid.Text = (query.Max(p => p.c1 + 1)).ToString();
        //}
        //private void frminsert_Load(object sender, EventArgs e)
        //{
        //    idnum();
        //}

        //private void btndelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        StudentDataContext bank = new StudentDataContext();
        //        var Query = (from p in bank.Students
        //                     where p.ID == int.Parse(txtid.Text)
        //                     select p).Single();
        //        bank.Students.DeleteOnSubmit(Query);
        //        bank.SubmitChanges();
        //        MessageBox.Show("selected Item Deleted");
        //        var query = from p in bank.Students
        //                    select p;
        //        Datagridview.DataSource = query;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void btnsearch_Click(object sender, EventArgs e)
        //{
        //    StudentDataContext bank = new StudentDataContext();
        //    var query = from p in bank.Students
        //                where p.ID == int.Parse(txtid.Text)
        //                select p;
        //    Datagridview.DataSource = query;
        //}
    }
}
