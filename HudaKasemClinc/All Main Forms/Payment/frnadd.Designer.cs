namespace HudaKasemClinc.All_Main_Forms.Payment
{
    partial class frnadd
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
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.Txtamount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBPatients = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 25;
            this.guna2Panel1.Controls.Add(this.btnCancel);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.txtnotes);
            this.guna2Panel1.Controls.Add(this.Txtamount);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.CBPatients);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(149, 26);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1020, 397);
            this.guna2Panel1.TabIndex = 0;
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
            this.btnCancel.Location = new System.Drawing.Point(556, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(370, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 59;
            this.label3.Text = "Notes:";
            // 
            // txtnotes
            // 
            this.txtnotes.BackColor = System.Drawing.Color.White;
            this.txtnotes.BorderRadius = 10;
            this.txtnotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnotes.DefaultText = "";
            this.txtnotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnotes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotes.ForeColor = System.Drawing.Color.Black;
            this.txtnotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnotes.IconLeft = global::HudaKasemClinc.Properties.Resources.post_it;
            this.txtnotes.Location = new System.Drawing.Point(259, 217);
            this.txtnotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.PasswordChar = '\0';
            this.txtnotes.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtnotes.PlaceholderText = "Notes";
            this.txtnotes.SelectedText = "";
            this.txtnotes.Size = new System.Drawing.Size(611, 91);
            this.txtnotes.TabIndex = 58;
            this.txtnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txtamount
            // 
            this.Txtamount.BackColor = System.Drawing.Color.White;
            this.Txtamount.BorderRadius = 10;
            this.Txtamount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtamount.DefaultText = "";
            this.Txtamount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtamount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtamount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtamount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtamount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtamount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtamount.ForeColor = System.Drawing.Color.Black;
            this.Txtamount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtamount.IconLeft = global::HudaKasemClinc.Properties.Resources.secure_payment;
            this.Txtamount.Location = new System.Drawing.Point(259, 130);
            this.Txtamount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txtamount.Name = "Txtamount";
            this.Txtamount.PasswordChar = '\0';
            this.Txtamount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Txtamount.PlaceholderText = "Amount";
            this.Txtamount.SelectedText = "";
            this.Txtamount.Size = new System.Drawing.Size(611, 35);
            this.Txtamount.TabIndex = 57;
            this.Txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtamount.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.Txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtamount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 56;
            this.label2.Text = "Amount:";
            // 
            // CBPatients
            // 
            this.CBPatients.BackColor = System.Drawing.Color.Transparent;
            this.CBPatients.BorderRadius = 10;
            this.CBPatients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPatients.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBPatients.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBPatients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBPatients.ForeColor = System.Drawing.Color.Black;
            this.CBPatients.ItemHeight = 30;
            this.CBPatients.Items.AddRange(new object[] {
            "Rami"});
            this.CBPatients.Location = new System.Drawing.Point(259, 45);
            this.CBPatients.Name = "CBPatients";
            this.CBPatients.Size = new System.Drawing.Size(611, 36);
            this.CBPatients.StartIndex = 0;
            this.CBPatients.TabIndex = 55;
            this.CBPatients.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 54;
            this.label1.Text = "Patient :";
            // 
            // frnadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1379, 528);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frnadd";
            this.Text = "frnadd";
            this.Load += new System.EventHandler(this.frnadd_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtnotes;
        private Guna.UI2.WinForms.Guna2TextBox Txtamount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox CBPatients;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}