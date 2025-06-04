namespace RestfulAPI
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
            this.txtb_url = new System.Windows.Forms.TextBox();
            this.rtxtb_response = new System.Windows.Forms.RichTextBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtb_data = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_method = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtb_url
            // 
            this.txtb_url.Location = new System.Drawing.Point(16, 23);
            this.txtb_url.Name = "txtb_url";
            this.txtb_url.Size = new System.Drawing.Size(519, 26);
            this.txtb_url.TabIndex = 0;
            // 
            // rtxtb_response
            // 
            this.rtxtb_response.Location = new System.Drawing.Point(16, 90);
            this.rtxtb_response.Name = "rtxtb_response";
            this.rtxtb_response.Size = new System.Drawing.Size(519, 358);
            this.rtxtb_response.TabIndex = 1;
            this.rtxtb_response.Text = "";
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(1026, 35);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 30);
            this.btn_go.TabIndex = 2;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response";
            // 
            // rtxtb_data
            // 
            this.rtxtb_data.Location = new System.Drawing.Point(582, 90);
            this.rtxtb_data.Name = "rtxtb_data";
            this.rtxtb_data.Size = new System.Drawing.Size(519, 358);
            this.rtxtb_data.TabIndex = 1;
            this.rtxtb_data.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // cmb_method
            // 
            this.cmb_method.FormattingEnabled = true;
            this.cmb_method.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cmb_method.Location = new System.Drawing.Point(582, 23);
            this.cmb_method.Name = "cmb_method";
            this.cmb_method.Size = new System.Drawing.Size(206, 28);
            this.cmb_method.TabIndex = 6;
            this.cmb_method.Text = "GET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 475);
            this.Controls.Add(this.cmb_method);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.rtxtb_data);
            this.Controls.Add(this.rtxtb_response);
            this.Controls.Add(this.txtb_url);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_url;
        private System.Windows.Forms.RichTextBox rtxtb_response;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtb_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_method;
    }
}

