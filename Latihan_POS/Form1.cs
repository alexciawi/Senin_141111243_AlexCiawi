using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posdbDataSet1.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.posdbDataSet1.suppliers);
            suppliersBindingSource.DataSource = this.posdbDataSet1.suppliers;

            // TODO: This line of code loads data into the 'posdbDataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.posdbDataSet1.products);
            productsBindingSource.DataSource = this.posdbDataSet1.products;

            // TODO: This line of code loads data into the 'posdbDataSet1.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.posdbDataSet1.customers);
            customersBindingSource.DataSource = this.posdbDataSet1.customers;
        }


        private void TxtCustSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCustSearch.Text))
            {
                // TODO: This line of code loads data into the 'posdbDataSet1.customers' table. You can move, or remove it, as needed.
                this.customersTableAdapter.Fill(this.posdbDataSet1.customers);
                customersBindingSource.DataSource = this.posdbDataSet1.customers;
            }
            else
            {
                var query = from o in this.posdbDataSet1.customers
                            where o.cust_name.Contains(TxtCustSearch.Text) || o.cust_email == TxtCustSearch.Text || o.cust_address.Contains(TxtCustSearch.Text)
                            select o;
                customersBindingSource.DataSource = query.ToList();
            }
        }

        private void BtnCustNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                TxtCustID.Enabled = false;
                TxtCustName.Focus();
                this.posdbDataSet1.customers.AddcustomersRow(this.posdbDataSet1.customers.NewcustomersRow());
                customersBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCustEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            TxtCustName.Focus();
        }

        private void BtnCustDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                customersBindingSource.RemoveCurrent();
        }

        private void BtnCustSave_Click(object sender, EventArgs e)
        {
            try
            {
                customersBindingSource.EndEdit();
                customersTableAdapter.Update(this.posdbDataSet1.customers);
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCustCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            customersBindingSource.ResetBindings(false);
        }

        private void TxtProductSearch_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtProductSearch.Text))
            {
                // TODO: This line of code loads data into the 'posdbDataSet1.products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.posdbDataSet1.products);
                productsBindingSource.DataSource = this.posdbDataSet1.products;
            }
            else
            {
                var query = from o in this.posdbDataSet1.products
                            where o.product_name.Contains(TxtProductSearch.Text)
                            select o;
                customersBindingSource.DataSource = query.ToList();
            }
        }
        
        private void BtnProductNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel2.Enabled = true;
                TxtProductID.Enabled = false;
                TxtProductName.Focus();
                this.posdbDataSet1.products.AddproductsRow(this.posdbDataSet1.products.NewproductsRow());
                productsBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProductEdit_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            TxtProductName.Focus();
        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                productsBindingSource.RemoveCurrent();
        }

        private void BtnProductSave_Click(object sender, EventArgs e)
        {
            try
            {
                productsBindingSource.EndEdit();
                productsTableAdapter.Update(this.posdbDataSet1.products);
                panel2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProductCancel_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            productsBindingSource.ResetBindings(false);
        }

        private void TxtSuppliersSearch_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtSuppliersSearch.Text))
            {
                // TODO: This line of code loads data into the 'posdbDataSet1.suppliers' table. You can move, or remove it, as needed.
                this.suppliersTableAdapter.Fill(this.posdbDataSet1.suppliers);
                suppliersBindingSource.DataSource = this.posdbDataSet1.suppliers;
            }
            else
            {
                var query = from o in this.posdbDataSet1.suppliers
                            where o.suppliers_name.Contains(TxtSuppliersSearch.Text)
                            select o;
                suppliersBindingSource.DataSource = query.ToList();
            }
        }

        private void BtnSuppliersNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Enabled = true;
                TxtSuppliersID.Enabled = false;
                TxtSuppliersEmail.Focus();
                this.posdbDataSet1.suppliers.AddsuppliersRow(this.posdbDataSet1.suppliers.NewsuppliersRow());
                suppliersBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuppliersEdit_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            TxtSuppliersName.Focus();
        }

        private void BtnSuppliersDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                suppliersBindingSource.RemoveCurrent();
        }

        private void BtnSuppliersSave_Click(object sender, EventArgs e)
        {
            try
            {
                suppliersBindingSource.EndEdit();
                suppliersTableAdapter.Update(this.posdbDataSet1.suppliers);
                panel3.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuppliersCancel_Click(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            suppliersBindingSource.ResetBindings(false);
        }
    }
}
