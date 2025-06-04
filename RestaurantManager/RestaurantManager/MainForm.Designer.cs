namespace RestaurantManager
{
    partial class MainForm
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_ordersPro = new System.Windows.Forms.Button();
            this.btn_reservations = new System.Windows.Forms.Button();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(30, 292);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(80, 30);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Location = new System.Drawing.Point(26, 31);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(110, 20);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Logged In  as:";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Location = new System.Drawing.Point(26, 62);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(46, 20);
            this.lb_role.TabIndex = 2;
            this.lb_role.Text = "Role:";
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(30, 95);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(80, 30);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_ordersPro
            // 
            this.btn_ordersPro.Location = new System.Drawing.Point(30, 167);
            this.btn_ordersPro.Name = "btn_ordersPro";
            this.btn_ordersPro.Size = new System.Drawing.Size(155, 30);
            this.btn_ordersPro.TabIndex = 4;
            this.btn_ordersPro.Text = "Order Processing";
            this.btn_ordersPro.UseVisualStyleBackColor = true;
            this.btn_ordersPro.Click += new System.EventHandler(this.btn_ordersPro_Click);
            // 
            // btn_reservations
            // 
            this.btn_reservations.Location = new System.Drawing.Point(30, 131);
            this.btn_reservations.Name = "btn_reservations";
            this.btn_reservations.Size = new System.Drawing.Size(125, 30);
            this.btn_reservations.TabIndex = 5;
            this.btn_reservations.Text = "Reservations";
            this.btn_reservations.UseVisualStyleBackColor = true;
            this.btn_reservations.Click += new System.EventHandler(this.btn_reservations_Click);
            // 
            // btn_feedback
            // 
            this.btn_feedback.Location = new System.Drawing.Point(30, 203);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(125, 30);
            this.btn_feedback.TabIndex = 6;
            this.btn_feedback.Text = "Feedback";
            this.btn_feedback.UseVisualStyleBackColor = true;
            this.btn_feedback.Click += new System.EventHandler(this.btn_feedback_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 362);
            this.Controls.Add(this.btn_feedback);
            this.Controls.Add(this.btn_reservations);
            this.Controls.Add(this.btn_ordersPro);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.btn_logout);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_ordersPro;
        private System.Windows.Forms.Button btn_reservations;
        private System.Windows.Forms.Button btn_feedback;
    }
}