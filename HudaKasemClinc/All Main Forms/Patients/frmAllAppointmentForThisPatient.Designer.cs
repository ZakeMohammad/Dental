namespace HudaKasemClinc.All_Main_Forms.Patients
{
    partial class frmAllAppointmentForThisPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.DGVALlAppointment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CBStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CBFillter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVALlAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.TopPanel.Controls.Add(this.guna2Button4);
            this.TopPanel.Controls.Add(this.btnExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1090, 40);
            this.TopPanel.TabIndex = 9;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Silver;
            this.guna2Button4.BorderColor = System.Drawing.Color.Silver;
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Button4.Font = new System.Drawing.Font("Simplified Arabic Fixed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button4.Location = new System.Drawing.Point(979, 3);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(50, 35);
            this.guna2Button4.TabIndex = 76;
            this.guna2Button4.Text = "-";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.BorderColor = System.Drawing.Color.Silver;
            this.btnExit.BorderRadius = 5;
            this.btnExit.BorderThickness = 1;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Font = new System.Drawing.Font("Simplified Arabic Fixed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gray;
            this.btnExit.Location = new System.Drawing.Point(1035, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 35);
            this.btnExit.TabIndex = 75;
            this.btnExit.Text = "x";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(441, 512);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DGVALlAppointment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVALlAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVALlAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVALlAppointment.ColumnHeadersHeight = 29;
            this.DGVALlAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVALlAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVALlAppointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGVALlAppointment.Location = new System.Drawing.Point(12, 146);
            this.DGVALlAppointment.Name = "DGVALlAppointment";
            this.DGVALlAppointment.ReadOnly = true;
            this.DGVALlAppointment.RowHeadersVisible = false;
            this.DGVALlAppointment.RowHeadersWidth = 51;
            this.DGVALlAppointment.RowTemplate.Height = 24;
            this.DGVALlAppointment.Size = new System.Drawing.Size(1066, 340);
            this.DGVALlAppointment.TabIndex = 33;
            this.DGVALlAppointment.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.DGVALlAppointment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVALlAppointment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVALlAppointment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVALlAppointment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVALlAppointment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVALlAppointment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVALlAppointment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGVALlAppointment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DGVALlAppointment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVALlAppointment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVALlAppointment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVALlAppointment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVALlAppointment.ThemeStyle.HeaderStyle.Height = 29;
            this.DGVALlAppointment.ThemeStyle.ReadOnly = true;
            this.DGVALlAppointment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGVALlAppointment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVALlAppointment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVALlAppointment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVALlAppointment.ThemeStyle.RowsStyle.Height = 24;
            this.DGVALlAppointment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DGVALlAppointment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic Fixed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "All Appointments";
            // 
            // CBStatus
            // 
            this.CBStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBStatus.BorderRadius = 5;
            this.CBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBStatus.ForeColor = System.Drawing.Color.Black;
            this.CBStatus.ItemHeight = 25;
            this.CBStatus.Items.AddRange(new object[] {
            "Active",
            "Done",
            "Canceled"});
            this.CBStatus.Location = new System.Drawing.Point(388, 109);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(216, 31);
            this.CBStatus.StartIndex = 0;
            this.CBStatus.TabIndex = 44;
            this.CBStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CBStatus.Visible = false;
            this.CBStatus.SelectedIndexChanged += new System.EventHandler(this.CBStatus_SelectedIndexChanged);
            // 
            // CBFillter
            // 
            this.CBFillter.BackColor = System.Drawing.Color.Transparent;
            this.CBFillter.BorderRadius = 5;
            this.CBFillter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBFillter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFillter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBFillter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBFillter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBFillter.ForeColor = System.Drawing.Color.Black;
            this.CBFillter.ItemHeight = 25;
            this.CBFillter.Items.AddRange(new object[] {
            "None",
            "Status"});
            this.CBFillter.Location = new System.Drawing.Point(166, 109);
            this.CBFillter.Name = "CBFillter";
            this.CBFillter.Size = new System.Drawing.Size(216, 31);
            this.CBFillter.StartIndex = 0;
            this.CBFillter.TabIndex = 43;
            this.CBFillter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CBFillter.SelectedIndexChanged += new System.EventHandler(this.CBFillter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 42;
            this.label2.Text = "Fillter By";
            // 
            // frmAllAppointmentForThisPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 569);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.CBFillter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVALlAppointment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllAppointmentForThisPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Appointment For Patient";
            this.Load += new System.EventHandler(this.frmAllAppointmentForThisPatient_Load);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVALlAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2DataGridView DGVALlAppointment;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox CBStatus;
        private Guna.UI2.WinForms.Guna2ComboBox CBFillter;
        private System.Windows.Forms.Label label2;
    }
}