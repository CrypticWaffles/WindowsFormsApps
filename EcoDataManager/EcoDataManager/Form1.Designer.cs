using System;

namespace EcoDataManager
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
            this.components = new System.ComponentModel.Container();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txtb_filename = new System.Windows.Forms.TextBox();
            this.cmb_tableSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.loginDBDataSet1 = new EcoDataManager.LoginDBDataSet();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.cmb_colFilter = new System.Windows.Forms.ComboBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.ctx_exportMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_exportAsCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_exportAsXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_exportAsJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.btn_applyDateFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_exportSummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.ctx_exportMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(317, 483);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 30);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txtb_filename
            // 
            this.txtb_filename.Location = new System.Drawing.Point(12, 451);
            this.txtb_filename.Name = "txtb_filename";
            this.txtb_filename.Size = new System.Drawing.Size(461, 26);
            this.txtb_filename.TabIndex = 4;
            // 
            // cmb_tableSelect
            // 
            this.cmb_tableSelect.FormattingEnabled = true;
            this.cmb_tableSelect.Items.AddRange(new object[] {
            "Species",
            "Observations",
            "Environment"});
            this.cmb_tableSelect.Location = new System.Drawing.Point(12, 417);
            this.cmb_tableSelect.Name = "cmb_tableSelect";
            this.cmb_tableSelect.Size = new System.Drawing.Size(121, 28);
            this.cmb_tableSelect.TabIndex = 5;
            this.cmb_tableSelect.SelectedIndexChanged += new System.EventHandler(this.cmb_tableSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a table";
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(398, 483);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(75, 30);
            this.btn_import.TabIndex = 7;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // loginDBDataSet1
            // 
            this.loginDBDataSet1.DataSetName = "LoginDBDataSet";
            this.loginDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(12, 12);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowHeadersWidth = 62;
            this.dgv_main.RowTemplate.Height = 28;
            this.dgv_main.Size = new System.Drawing.Size(1141, 372);
            this.dgv_main.TabIndex = 11;
            // 
            // txt_filter
            // 
            this.txt_filter.Location = new System.Drawing.Point(942, 467);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(121, 26);
            this.txt_filter.TabIndex = 15;
            // 
            // cmb_colFilter
            // 
            this.cmb_colFilter.FormattingEnabled = true;
            this.cmb_colFilter.Location = new System.Drawing.Point(942, 413);
            this.cmb_colFilter.Name = "cmb_colFilter";
            this.cmb_colFilter.Size = new System.Drawing.Size(121, 28);
            this.cmb_colFilter.TabIndex = 16;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(1069, 411);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 30);
            this.btn_apply.TabIndex = 17;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(942, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Filtered Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(942, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Filter";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(1069, 467);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 30);
            this.btn_export.TabIndex = 22;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ctx_exportMenu
            // 
            this.ctx_exportMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctx_exportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_exportAsCSV,
            this.tsmi_exportAsXML,
            this.tsmi_exportAsJSON});
            this.ctx_exportMenu.Name = "ctx_exportMenu";
            this.ctx_exportMenu.Size = new System.Drawing.Size(206, 100);
            // 
            // tsmi_exportAsCSV
            // 
            this.tsmi_exportAsCSV.Name = "tsmi_exportAsCSV";
            this.tsmi_exportAsCSV.Size = new System.Drawing.Size(205, 32);
            this.tsmi_exportAsCSV.Text = "Export as CSV";
            this.tsmi_exportAsCSV.Click += new System.EventHandler(this.tsmi_exportAsCSV_Click);
            // 
            // tsmi_exportAsXML
            // 
            this.tsmi_exportAsXML.Name = "tsmi_exportAsXML";
            this.tsmi_exportAsXML.Size = new System.Drawing.Size(205, 32);
            this.tsmi_exportAsXML.Text = "Export as XML";
            this.tsmi_exportAsXML.Click += new System.EventHandler(this.tsmi_exportAsXML_Click);
            // 
            // tsmi_exportAsJSON
            // 
            this.tsmi_exportAsJSON.Name = "tsmi_exportAsJSON";
            this.tsmi_exportAsJSON.Size = new System.Drawing.Size(205, 32);
            this.tsmi_exportAsJSON.Text = "Export as JSON";
            this.tsmi_exportAsJSON.Click += new System.EventHandler(this.tsmi_exportAsJSON_Click);
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(552, 415);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(300, 26);
            this.dtp_start.TabIndex = 26;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(552, 467);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(300, 26);
            this.dtp_end.TabIndex = 26;
            // 
            // btn_applyDateFilter
            // 
            this.btn_applyDateFilter.Location = new System.Drawing.Point(858, 424);
            this.btn_applyDateFilter.Name = "btn_applyDateFilter";
            this.btn_applyDateFilter.Size = new System.Drawing.Size(75, 60);
            this.btn_applyDateFilter.TabIndex = 27;
            this.btn_applyDateFilter.Text = "Filter Dates";
            this.btn_applyDateFilter.UseVisualStyleBackColor = true;
            this.btn_applyDateFilter.Click += new System.EventHandler(this.btn_applyDateFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "End Date";
            // 
            // btn_exportSummary
            // 
            this.btn_exportSummary.Location = new System.Drawing.Point(994, 503);
            this.btn_exportSummary.Name = "btn_exportSummary";
            this.btn_exportSummary.Size = new System.Drawing.Size(150, 30);
            this.btn_exportSummary.TabIndex = 28;
            this.btn_exportSummary.Text = "Export Summary";
            this.btn_exportSummary.UseVisualStyleBackColor = true;
            this.btn_exportSummary.Click += new System.EventHandler(this.btn_exportSummary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 544);
            this.Controls.Add(this.btn_exportSummary);
            this.Controls.Add(this.btn_applyDateFilter);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cmb_colFilter);
            this.Controls.Add(this.txt_filter);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tableSelect);
            this.Controls.Add(this.txtb_filename);
            this.Controls.Add(this.btn_browse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ctx_exportMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txtb_filename;
        private System.Windows.Forms.ComboBox cmb_tableSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_import;
        private LoginDBDataSet loginDBDataSet1;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.TextBox txt_filter;
        private System.Windows.Forms.ComboBox cmb_colFilter;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ContextMenuStrip ctx_exportMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exportAsCSV;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exportAsXML;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exportAsJSON;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button btn_applyDateFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_exportSummary;
    }
}

