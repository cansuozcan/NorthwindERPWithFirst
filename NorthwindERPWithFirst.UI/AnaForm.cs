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
    public partial class AnaForm : Form
    {
        private NorthwindEntities db;
        public AnaForm()
        {
            InitializeComponent();
            db = new NorthwindEntities();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkle frmUrunEkle = new UrunEkle();
            frmUrunEkle.Show();

        }

        private void urunleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvAnaForm.DataSource = db.Products.Select(p => new { p.ProductName, p.SupplierID, p.CategoryID, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued }).ToList();
            //dgvAnaForm.DataSource = db.Products.ToList();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvAnaForm.DataSource = db.Products.Remove();
        }

        
    }
}
