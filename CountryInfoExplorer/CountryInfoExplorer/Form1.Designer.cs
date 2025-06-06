namespace CountryInfoExplorer
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
            this.lbl_countryName = new System.Windows.Forms.Label();
            this.txt_countryName = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_population = new System.Windows.Forms.Label();
            this.lbl_region = new System.Windows.Forms.Label();
            this.lbl_subRegion = new System.Windows.Forms.Label();
            this.lbl_capital = new System.Windows.Forms.Label();
            this.pbx_flag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_flag)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_countryName
            // 
            this.lbl_countryName.AutoSize = true;
            this.lbl_countryName.Location = new System.Drawing.Point(13, 13);
            this.lbl_countryName.Name = "lbl_countryName";
            this.lbl_countryName.Size = new System.Drawing.Size(157, 20);
            this.lbl_countryName.TabIndex = 0;
            this.lbl_countryName.Text = "Enter Country Name:";
            // 
            // txt_countryName
            // 
            this.txt_countryName.Location = new System.Drawing.Point(13, 37);
            this.txt_countryName.Name = "txt_countryName";
            this.txt_countryName.Size = new System.Drawing.Size(157, 26);
            this.txt_countryName.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(176, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 30);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Population:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Region:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sub Region:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capital:";
            // 
            // lbl_population
            // 
            this.lbl_population.AutoSize = true;
            this.lbl_population.Location = new System.Drawing.Point(128, 97);
            this.lbl_population.Name = "lbl_population";
            this.lbl_population.Size = new System.Drawing.Size(35, 20);
            this.lbl_population.TabIndex = 3;
            this.lbl_population.Text = "N/A";
            // 
            // lbl_region
            // 
            this.lbl_region.AutoSize = true;
            this.lbl_region.Location = new System.Drawing.Point(128, 127);
            this.lbl_region.Name = "lbl_region";
            this.lbl_region.Size = new System.Drawing.Size(35, 20);
            this.lbl_region.TabIndex = 3;
            this.lbl_region.Text = "N/A";
            // 
            // lbl_subRegion
            // 
            this.lbl_subRegion.AutoSize = true;
            this.lbl_subRegion.Location = new System.Drawing.Point(128, 158);
            this.lbl_subRegion.Name = "lbl_subRegion";
            this.lbl_subRegion.Size = new System.Drawing.Size(35, 20);
            this.lbl_subRegion.TabIndex = 3;
            this.lbl_subRegion.Text = "N/A";
            // 
            // lbl_capital
            // 
            this.lbl_capital.AutoSize = true;
            this.lbl_capital.Location = new System.Drawing.Point(128, 188);
            this.lbl_capital.Name = "lbl_capital";
            this.lbl_capital.Size = new System.Drawing.Size(35, 20);
            this.lbl_capital.TabIndex = 3;
            this.lbl_capital.Text = "N/A";
            // 
            // pbx_flag
            // 
            this.pbx_flag.Location = new System.Drawing.Point(286, 37);
            this.pbx_flag.Name = "pbx_flag";
            this.pbx_flag.Size = new System.Drawing.Size(300, 171);
            this.pbx_flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_flag.TabIndex = 4;
            this.pbx_flag.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 278);
            this.Controls.Add(this.pbx_flag);
            this.Controls.Add(this.lbl_capital);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_subRegion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_region);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_population);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_countryName);
            this.Controls.Add(this.lbl_countryName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_countryName;
        private System.Windows.Forms.TextBox txt_countryName;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_population;
        private System.Windows.Forms.Label lbl_region;
        private System.Windows.Forms.Label lbl_subRegion;
        private System.Windows.Forms.Label lbl_capital;
        private System.Windows.Forms.PictureBox pbx_flag;
    }
}

