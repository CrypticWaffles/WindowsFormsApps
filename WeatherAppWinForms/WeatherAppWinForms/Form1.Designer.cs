namespace WeatherAppWinForms
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
            this.txtb_city = new System.Windows.Forms.TextBox();
            this.btn_getWeather = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_humidity = new System.Windows.Forms.Label();
            this.lbl_windSpeed = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb_city
            // 
            this.txtb_city.Location = new System.Drawing.Point(12, 12);
            this.txtb_city.Name = "txtb_city";
            this.txtb_city.Size = new System.Drawing.Size(150, 26);
            this.txtb_city.TabIndex = 0;
            // 
            // btn_getWeather
            // 
            this.btn_getWeather.Location = new System.Drawing.Point(198, 12);
            this.btn_getWeather.Name = "btn_getWeather";
            this.btn_getWeather.Size = new System.Drawing.Size(110, 30);
            this.btn_getWeather.TabIndex = 1;
            this.btn_getWeather.Text = "Get Weather";
            this.btn_getWeather.UseVisualStyleBackColor = true;
            this.btn_getWeather.Click += new System.EventHandler(this.btn_getWeather_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Humidity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wind Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description:";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Location = new System.Drawing.Point(122, 53);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(51, 20);
            this.lbl_temp.TabIndex = 2;
            this.lbl_temp.Text = "label1";
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.Location = new System.Drawing.Point(122, 96);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.Size = new System.Drawing.Size(51, 20);
            this.lbl_humidity.TabIndex = 2;
            this.lbl_humidity.Text = "label1";
            // 
            // lbl_windSpeed
            // 
            this.lbl_windSpeed.AutoSize = true;
            this.lbl_windSpeed.Location = new System.Drawing.Point(122, 140);
            this.lbl_windSpeed.Name = "lbl_windSpeed";
            this.lbl_windSpeed.Size = new System.Drawing.Size(51, 20);
            this.lbl_windSpeed.TabIndex = 2;
            this.lbl_windSpeed.Text = "label1";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(122, 183);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(51, 20);
            this.lbl_desc.TabIndex = 2;
            this.lbl_desc.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 237);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_windSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_humidity);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_getWeather);
            this.Controls.Add(this.txtb_city);
            this.Name = "Form1";
            this.Text = "Weather App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_city;
        private System.Windows.Forms.Button btn_getWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_humidity;
        private System.Windows.Forms.Label lbl_windSpeed;
        private System.Windows.Forms.Label lbl_desc;
    }
}

