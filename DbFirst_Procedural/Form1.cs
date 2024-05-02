using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DbFirst_Procedural
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Cleaning()
        {
            TxtBxNameSurname.Clear();
            TxtBxTc.Clear();
            TxtBxProduct.Clear();
            TxtBxPrice.Clear();
        }

        DbFirstApp2Entities conn = new DbFirstApp2Entities();

        private void BtnList_Click(object sender, EventArgs e)
        {
            //DGridView.DataSource = conn.Customers.ToList();
            DGridView.DataSource = conn.CustomerList().ToList();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Customer save = new Customer();
            save.NameSurname = TxtBxNameSurname.Text;
            save.Tc = TxtBxTc.Text;
            save.Product = TxtBxProduct.Text;
            save.Price = Convert.ToDecimal(TxtBxPrice.Text);
            //conn.Customers.Add(save);
            //conn.SaveChanges();
            conn.CustomerSave(save.NameSurname, save.Tc, save.Product, save.Price);
            DGridView.DataSource = conn.CustomerList().ToList();
        }

        private void DGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGridView.CurrentRow;
            TxtBxNameSurname.Tag = row.Cells["Id"].Value.ToString();
            TxtBxNameSurname.Text = row.Cells["NameSurname"].Value.ToString();
            TxtBxTc.Text = row.Cells["Tc"].Value.ToString();
            TxtBxProduct.Text = row.Cells["Product"].Value.ToString();
            TxtBxPrice.Text = row.Cells["Price"].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Customer update = new Customer();
            update.Id = Convert.ToInt32(TxtBxNameSurname.Tag);
            update.NameSurname = TxtBxNameSurname.Text;
            update.Tc = TxtBxTc.Text;
            update.Product = TxtBxProduct.Text;
            update.Price = Convert.ToDecimal(TxtBxPrice.Text);
            conn.CustomerUpdate(update.Id, update.NameSurname, update.Tc, update.Product, update.Price);
            DGridView.DataSource = conn.CustomerList().ToList();
            Cleaning();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Customer delete = new Customer();
            delete.Id = Convert.ToInt32(TxtBxNameSurname.Tag);
            conn.CustomerDelete(delete.Id);
            DGridView.DataSource = conn.CustomerList().ToList();
            Cleaning();
        }

        private void BtnSearch_Name_Click(object sender, EventArgs e)
        {
            //Customer search = new Customer();
            //search.NameSurname = TxtSearching.Text;
            //DGridView.DataSource = conn.CustomerName_Search(search.NameSurname);

            DGridView.DataSource = conn.CustomerName_Search(TxtSearching.Text).ToList();
        }

        private void BtnSearch_Tc_Click(object sender, EventArgs e)
        {
            //Select * from Customers where Tc = '1111..'
            //Select * from Customers where Tc =@tc

            var result = conn.Customers.Where(x => x.Tc == TxtSearching.Text).ToList();
            DGridView.DataSource = result;
        }

        private void BtnFindMe_Click(object sender, EventArgs e)
        {
            DGridView.DataSource = conn.Customers.Where(x => x.NameSurname.Equals("Deniz İnan")).ToList();
        }
    }
}
