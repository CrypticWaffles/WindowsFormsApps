namespace Form3
{
    partial class Form1
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
            this.btnLoadPeople = new System.Windows.Forms.Button();
            this.lvPeopleData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoadProducts = new System.Windows.Forms.Button();
            this.lvProductData = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadPeople
            // 
            this.btnLoadPeople.Location = new System.Drawing.Point(13, 13);
            this.btnLoadPeople.Name = "btnLoadPeople";
            this.btnLoadPeople.Size = new System.Drawing.Size(172, 41);
            this.btnLoadPeople.TabIndex = 0;
            this.btnLoadPeople.Text = "Load People Data";
            this.btnLoadPeople.UseVisualStyleBackColor = true;
            this.btnLoadPeople.Click += new System.EventHandler(this.btnLoadPeople_Click);
            // 
            // lvPeopleData
            // 
            this.lvPeopleData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPeopleData.HideSelection = false;
            this.lvPeopleData.Location = new System.Drawing.Point(13, 60);
            this.lvPeopleData.MultiSelect = false;
            this.lvPeopleData.Name = "lvPeopleData";
            this.lvPeopleData.Size = new System.Drawing.Size(455, 189);
            this.lvPeopleData.TabIndex = 1;
            this.lvPeopleData.UseCompatibleStateImageBehavior = false;
            this.lvPeopleData.View = System.Windows.Forms.View.Details;
            this.lvPeopleData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPeopleData_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PersonID";
            this.columnHeader2.Width = 100;
            // 
            // btnLoadProducts
            // 
            this.btnLoadProducts.Location = new System.Drawing.Point(13, 263);
            this.btnLoadProducts.Name = "btnLoadProducts";
            this.btnLoadProducts.Size = new System.Drawing.Size(172, 41);
            this.btnLoadProducts.TabIndex = 0;
            this.btnLoadProducts.Text = "Load Products";
            this.btnLoadProducts.UseVisualStyleBackColor = true;
            this.btnLoadProducts.Click += new System.EventHandler(this.btnLoadProducts_Click);
            // 
            // lvProductData
            // 
            this.lvProductData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvProductData.HideSelection = false;
            this.lvProductData.Location = new System.Drawing.Point(13, 310);
            this.lvProductData.Name = "lvProductData";
            this.lvProductData.Size = new System.Drawing.Size(700, 300);
            this.lvProductData.TabIndex = 1;
            this.lvProductData.UseCompatibleStateImageBehavior = false;
            this.lvProductData.View = System.Windows.Forms.View.Details;
            this.lvProductData.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProductData_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Impersonating";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(479, 112);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(125, 26);
            this.txtbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(610, 112);
            this.txtbID.Name = "txtbID";
            this.txtbID.ReadOnly = true;
            this.txtbID.Size = new System.Drawing.Size(125, 26);
            this.txtbID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Person ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Inventory";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ProductID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Purchase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 634);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvProductData);
            this.Controls.Add(this.btnLoadProducts);
            this.Controls.Add(this.lvPeopleData);
            this.Controls.Add(this.btnLoadPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPeople;
        private System.Windows.Forms.ListView lvPeopleData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnLoadProducts;
        private System.Windows.Forms.ListView lvProductData;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label4;
    }
}

