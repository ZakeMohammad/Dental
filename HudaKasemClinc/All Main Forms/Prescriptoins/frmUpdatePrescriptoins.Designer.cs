namespace HudaKasemClinc.All_Main_Forms.Prescriptoins
{
    partial class frmUpdatePrescriptoins
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSerarch = new Guna.UI2.WinForms.Guna2Button();
            this.txtFillter = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDoctorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBMidicen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Datemiker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.btnSerarch);
            this.guna2Panel1.Controls.Add(this.txtFillter);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(562, 32);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(793, 67);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btnSerarch
            // 
            this.btnSerarch.BackColor = System.Drawing.Color.White;
            this.btnSerarch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSerarch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSerarch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSerarch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSerarch.FillColor = System.Drawing.Color.Transparent;
            this.btnSerarch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSerarch.ForeColor = System.Drawing.Color.White;
            this.btnSerarch.Location = new System.Drawing.Point(21, 45);
            this.btnSerarch.Name = "btnSerarch";
            this.btnSerarch.Size = new System.Drawing.Size(48, 10);
            this.btnSerarch.TabIndex = 2;
            this.btnSerarch.Click += new System.EventHandler(this.btnSerarch_Click);
            // 
            // txtFillter
            // 
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
            this.txtFillter.IconLeft = global::HudaKasemClinc.Properties.Resources.loupe;
            this.txtFillter.Location = new System.Drawing.Point(106, 11);
            this.txtFillter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFillter.Name = "txtFillter";
            this.txtFillter.PasswordChar = '\0';
            this.txtFillter.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFillter.PlaceholderText = "PrescriptionID";
            this.txtFillter.SelectedText = "";
            this.txtFillter.Size = new System.Drawing.Size(673, 34);
            this.txtFillter.TabIndex = 37;
            this.txtFillter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFillter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFillter_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search";
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BorderRadius = 20;
            this.MainPanel.Controls.Add(this.txtDoctorName);
            this.MainPanel.Controls.Add(this.Txtname);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.CBMidicen);
            this.MainPanel.Controls.Add(this.Datemiker);
            this.MainPanel.Controls.Add(this.label17);
            this.MainPanel.Controls.Add(this.txtNotes);
            this.MainPanel.Controls.Add(this.btnSave);
            this.MainPanel.Controls.Add(this.btnCancel);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.FillColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(531, 105);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(880, 645);
            this.MainPanel.TabIndex = 5;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.BackColor = System.Drawing.Color.White;
            this.txtDoctorName.BorderRadius = 10;
            this.txtDoctorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorName.DefaultText = "";
            this.txtDoctorName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoctorName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoctorName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoctorName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoctorName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoctorName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDoctorName.ForeColor = System.Drawing.Color.Black;
            this.txtDoctorName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoctorName.Location = new System.Drawing.Point(256, 176);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.PasswordChar = '\0';
            this.txtDoctorName.PlaceholderText = "";
            this.txtDoctorName.ReadOnly = true;
            this.txtDoctorName.SelectedText = "";
            this.txtDoctorName.Size = new System.Drawing.Size(540, 39);
            this.txtDoctorName.TabIndex = 100;
            this.txtDoctorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txtname
            // 
            this.Txtname.BackColor = System.Drawing.Color.White;
            this.Txtname.BorderRadius = 10;
            this.Txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtname.DefaultText = "";
            this.Txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txtname.ForeColor = System.Drawing.Color.Black;
            this.Txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtname.Location = new System.Drawing.Point(256, 61);
            this.Txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtname.Name = "Txtname";
            this.Txtname.PasswordChar = '\0';
            this.Txtname.PlaceholderText = "";
            this.Txtname.ReadOnly = true;
            this.Txtname.SelectedText = "";
            this.Txtname.Size = new System.Drawing.Size(540, 39);
            this.Txtname.TabIndex = 99;
            this.Txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic Fixed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 34);
            this.label7.TabIndex = 98;
            this.label7.Text = "Description";
            // 
            // CBMidicen
            // 
            this.CBMidicen.BackColor = System.Drawing.Color.Transparent;
            this.CBMidicen.BorderRadius = 10;
            this.CBMidicen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBMidicen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMidicen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBMidicen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBMidicen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBMidicen.ForeColor = System.Drawing.Color.Black;
            this.CBMidicen.ItemHeight = 30;
            this.CBMidicen.Items.AddRange(new object[] {
            "Rami"});
            this.CBMidicen.Location = new System.Drawing.Point(256, 283);
            this.CBMidicen.Name = "CBMidicen";
            this.CBMidicen.Size = new System.Drawing.Size(583, 36);
            this.CBMidicen.StartIndex = 0;
            this.CBMidicen.TabIndex = 94;
            this.CBMidicen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Datemiker
            // 
            this.Datemiker.Checked = true;
            this.Datemiker.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Datemiker.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datemiker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datemiker.Location = new System.Drawing.Point(256, 385);
            this.Datemiker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Datemiker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Datemiker.Name = "Datemiker";
            this.Datemiker.Size = new System.Drawing.Size(583, 36);
            this.Datemiker.TabIndex = 77;
            this.Datemiker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Datemiker.Value = new System.DateTime(2024, 2, 23, 16, 0, 9, 371);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Simplified Arabic Fixed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(25, 820);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 34);
            this.label17.TabIndex = 68;
            this.label17.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.AutoScroll = true;
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.BorderRadius = 20;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.Black;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(37, 539);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNotes.PlaceholderText = "Description";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(787, 218);
            this.txtNotes.TabIndex = 67;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(458, 765);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Update";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(644, 765);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic Fixed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 34);
            this.label5.TabIndex = 38;
            this.label5.Text = "Medicine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic Fixed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 34);
            this.label4.TabIndex = 37;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic Fixed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 34);
            this.label3.TabIndex = 36;
            this.label3.Text = "Doctor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic Fixed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 34);
            this.label2.TabIndex = 35;
            this.label2.Text = "Patient Name";
            // 
            // frmUpdatePrescriptoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 783);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdatePrescriptoins";
            this.Text = "frmUpdatePrescriptoins";
            this.Load += new System.EventHandler(this.frmUpdatePrescriptoins_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSerarch;
        private Guna.UI2.WinForms.Guna2TextBox txtFillter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2DateTimePicker Datemiker;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox CBMidicen;
        private Guna.UI2.WinForms.Guna2TextBox txtDoctorName;
        private Guna.UI2.WinForms.Guna2TextBox Txtname;
    }
}