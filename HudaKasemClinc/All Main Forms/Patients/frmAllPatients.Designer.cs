namespace HudaKasemClinc.All_Main_Forms.Patients
{
    partial class frmAllPatients
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
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.CBStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFillter = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBFillter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVALlPrescriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVALlPrescriptions)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(929, 686);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.CBStatus);
            this.guna2Panel1.Controls.Add(this.txtFillter);
            this.guna2Panel1.Controls.Add(this.CBFillter);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.DGVALlPrescriptions);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(120, 110);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1703, 512);
            this.guna2Panel1.TabIndex = 34;
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
            "Recovered",
            "Still Sick"});
            this.CBStatus.Location = new System.Drawing.Point(410, 31);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(216, 31);
            this.CBStatus.StartIndex = 0;
            this.CBStatus.TabIndex = 52;
            this.CBStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CBStatus.Visible = false;
            this.CBStatus.SelectedIndexChanged += new System.EventHandler(this.CBStatus_SelectedIndexChanged);
            // 
            // txtFillter
            // 
            this.txtFillter.BorderRadius = 10;
            this.txtFillter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFillter.DefaultText = "";
            this.txtFillter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFillter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFillter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFillter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFillter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFillter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFillter.ForeColor = System.Drawing.Color.Black;
            this.txtFillter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFillter.Location = new System.Drawing.Point(410, 31);
            this.txtFillter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFillter.Name = "txtFillter";
            this.txtFillter.PasswordChar = '\0';
            this.txtFillter.PlaceholderText = "";
            this.txtFillter.SelectedText = "";
            this.txtFillter.Size = new System.Drawing.Size(413, 29);
            this.txtFillter.TabIndex = 51;
            this.txtFillter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFillter.Visible = false;
            this.txtFillter.TextChanged += new System.EventHandler(this.txtFillter_TextChanged);
            this.txtFillter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFillter_KeyPress);
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
            "Patient Name",
            "Patient Status"});
            this.CBFillter.Location = new System.Drawing.Point(188, 31);
            this.CBFillter.Name = "CBFillter";
            this.CBFillter.Size = new System.Drawing.Size(216, 31);
            this.CBFillter.StartIndex = 0;
            this.CBFillter.TabIndex = 50;
            this.CBFillter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CBFillter.SelectedIndexChanged += new System.EventHandler(this.CBFillter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fillter By";
            // 
            // DGVALlPrescriptions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVALlPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVALlPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVALlPrescriptions.ColumnHeadersHeight = 29;
            this.DGVALlPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVALlPrescriptions.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVALlPrescriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGVALlPrescriptions.Location = new System.Drawing.Point(45, 78);
            this.DGVALlPrescriptions.Name = "DGVALlPrescriptions";
            this.DGVALlPrescriptions.ReadOnly = true;
            this.DGVALlPrescriptions.RowHeadersVisible = false;
            this.DGVALlPrescriptions.RowHeadersWidth = 51;
            this.DGVALlPrescriptions.RowTemplate.Height = 24;
            this.DGVALlPrescriptions.Size = new System.Drawing.Size(1604, 408);
            this.DGVALlPrescriptions.TabIndex = 44;
            this.DGVALlPrescriptions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.DGVALlPrescriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVALlPrescriptions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVALlPrescriptions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVALlPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVALlPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVALlPrescriptions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVALlPrescriptions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGVALlPrescriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DGVALlPrescriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVALlPrescriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVALlPrescriptions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVALlPrescriptions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVALlPrescriptions.ThemeStyle.HeaderStyle.Height = 29;
            this.DGVALlPrescriptions.ThemeStyle.ReadOnly = true;
            this.DGVALlPrescriptions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DGVALlPrescriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVALlPrescriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVALlPrescriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVALlPrescriptions.ThemeStyle.RowsStyle.Height = 24;
            this.DGVALlPrescriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DGVALlPrescriptions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frmAllPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 783);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllPatients";
            this.Text = "All Patients";
            this.Load += new System.EventHandler(this.frmAllPatients_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVALlPrescriptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVALlPrescriptions;
        private Guna.UI2.WinForms.Guna2TextBox txtFillter;
        private Guna.UI2.WinForms.Guna2ComboBox CBFillter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox CBStatus;
    }
}