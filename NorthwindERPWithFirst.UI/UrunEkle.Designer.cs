namespace NorthwindERPWithFirst.UI
{
    partial class UrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProcName = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.lblUnitsOnOrder = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProcName = new System.Windows.Forms.TextBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nudUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.nudUnitsOnOrder = new System.Windows.Forms.NumericUpDown();
            this.nudReorder = new System.Windows.Forms.NumericUpDown();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsOnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProcName
            // 
            this.lblProcName.AutoSize = true;
            this.lblProcName.Location = new System.Drawing.Point(65, 32);
            this.lblProcName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcName.Name = "lblProcName";
            this.lblProcName.Size = new System.Drawing.Size(94, 17);
            this.lblProcName.TabIndex = 0;
            this.lblProcName.Text = "ProductName";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(65, 79);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(60, 17);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(65, 121);
            this.lblCategoryId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(65, 17);
            this.lblCategoryId.TabIndex = 0;
            this.lblCategoryId.Text = "Category";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(65, 160);
            this.lblQuantityPerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(108, 17);
            this.lblQuantityPerUnit.TabIndex = 0;
            this.lblQuantityPerUnit.Text = "QuantityPerUnit";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(65, 207);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(65, 17);
            this.lblUnitPrice.TabIndex = 0;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(65, 251);
            this.lblUnitsInStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(86, 17);
            this.lblUnitsInStock.TabIndex = 0;
            this.lblUnitsInStock.Text = "UnitsInStock";
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.AutoSize = true;
            this.lblUnitsOnOrder.Location = new System.Drawing.Point(65, 295);
            this.lblUnitsOnOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Size = new System.Drawing.Size(96, 17);
            this.lblUnitsOnOrder.TabIndex = 0;
            this.lblUnitsOnOrder.Text = "UnitsOnOrder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "ReorderLevel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 382);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Discontinued";
            // 
            // txtProcName
            // 
            this.txtProcName.Location = new System.Drawing.Point(204, 29);
            this.txtProcName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(159, 22);
            this.txtProcName.TabIndex = 1;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(203, 72);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(160, 24);
            this.cmbSupplier.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(203, 114);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(160, 24);
            this.cmbCategory.TabIndex = 2;
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Location = new System.Drawing.Point(204, 205);
            this.nudUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(160, 22);
            this.nudUnitPrice.TabIndex = 3;
            // 
            // nudUnitInStock
            // 
            this.nudUnitInStock.Location = new System.Drawing.Point(203, 249);
            this.nudUnitInStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudUnitInStock.Name = "nudUnitInStock";
            this.nudUnitInStock.Size = new System.Drawing.Size(160, 22);
            this.nudUnitInStock.TabIndex = 3;
            // 
            // nudUnitsOnOrder
            // 
            this.nudUnitsOnOrder.Location = new System.Drawing.Point(203, 295);
            this.nudUnitsOnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudUnitsOnOrder.Name = "nudUnitsOnOrder";
            this.nudUnitsOnOrder.Size = new System.Drawing.Size(160, 22);
            this.nudUnitsOnOrder.TabIndex = 3;
            // 
            // nudReorder
            // 
            this.nudReorder.Location = new System.Drawing.Point(203, 337);
            this.nudReorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudReorder.Name = "nudReorder";
            this.nudReorder.Size = new System.Drawing.Size(160, 22);
            this.nudReorder.TabIndex = 3;
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(203, 383);
            this.chkDiscontinued.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(18, 17);
            this.chkDiscontinued.TabIndex = 4;
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(268, 448);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(144, 448);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(204, 157);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(156, 22);
            this.txtQuantity.TabIndex = 6;
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 540);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkDiscontinued);
            this.Controls.Add(this.nudReorder);
            this.Controls.Add(this.nudUnitsOnOrder);
            this.Controls.Add(this.nudUnitInStock);
            this.Controls.Add(this.nudUnitPrice);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.txtProcName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUnitsOnOrder);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantityPerUnit);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblProcName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UrunEkle";
            this.Text = "Urun Ekle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitsOnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcName;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Label lblUnitsOnOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProcName;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.NumericUpDown nudUnitInStock;
        private System.Windows.Forms.NumericUpDown nudUnitsOnOrder;
        private System.Windows.Forms.NumericUpDown nudReorder;
        private System.Windows.Forms.CheckBox chkDiscontinued;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}

