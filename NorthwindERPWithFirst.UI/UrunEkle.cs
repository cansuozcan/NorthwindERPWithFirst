using NorthwindERPWithFirst.UI.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindERPWithFirst.UI
{
    public partial class UrunEkle : Form
    {
        private NorthwindEntities db;
        public UrunEkle()
        {
            InitializeComponent();
            db = new NorthwindEntities();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = db.Categories.Select(x => new { Id = x.CategoryID, Name = x.CategoryName }).ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbSupplier.DataSource = db.Suppliers.Select(x => new { Id = x.SupplierID, Name = x.CompanyName }).ToList();
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Product newProd = new Product();
            newProd.SupplierID = (int)cmbSupplier.SelectedValue;
            newProd.CategoryID = (int)cmbSupplier.SelectedValue;
            newProd.Discontinued = chkDiscontinued.Checked;
            newProd.ProductName = txtProcName.Text;
            newProd.QuantityPerUnit = txtQuantity.Text;
            newProd.ReorderLevel = Convert.ToInt16(nudReorder.Value);
            newProd.UnitPrice = nudUnitPrice.Value;
            newProd.UnitsInStock = Convert.ToInt16(nudUnitInStock.Value);
            newProd.UnitsOnOrder = Convert.ToInt16(nudUnitsOnOrder.Value);
            db.Products.Add(newProd);
            db.SaveChanges();
           
           
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
