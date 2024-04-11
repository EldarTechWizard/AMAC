namespace AMAC.Views.AdopterManagement
{ 
    partial class AdopterManagementView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvAdopter = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbId = new DevExpress.XtraEditors.TextEdit();
            this.tbAge = new DevExpress.XtraEditors.TextEdit();
            this.tbEmail = new DevExpress.XtraEditors.TextEdit();
            this.tbAddress = new DevExpress.XtraEditors.TextEdit();
            this.tbNumber = new DevExpress.XtraEditors.TextEdit();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveAndEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdopter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.98773F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.01227F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1275, 815);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 46);
            this.label1.TabIndex = 92;
            this.label1.Text = "GESTOR DE ADOPTANTES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1069, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 108);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::AMAC.Properties.Resources.AMACPNG;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 129;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1269, 695);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.20144F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.79856F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1269, 695);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvAdopter);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 338);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1263, 354);
            this.panel5.TabIndex = 1;
            // 
            // dgvAdopter
            // 
            this.dgvAdopter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdopter.Location = new System.Drawing.Point(0, 0);
            this.dgvAdopter.MainView = this.gridView1;
            this.dgvAdopter.Name = "dgvAdopter";
            this.dgvAdopter.Size = new System.Drawing.Size(1263, 354);
            this.dgvAdopter.TabIndex = 0;
            this.dgvAdopter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvAdopter;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsFilter.InHeaderSearchMode = DevExpress.XtraGrid.Views.Grid.GridInHeaderSearchMode.TextFilter;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1263, 329);
            this.panel4.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.tbId);
            this.groupControl1.Controls.Add(this.tbAge);
            this.groupControl1.Controls.Add(this.tbEmail);
            this.groupControl1.Controls.Add(this.tbAddress);
            this.groupControl1.Controls.Add(this.tbNumber);
            this.groupControl1.Controls.Add(this.tbName);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSaveAndEdit);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1263, 329);
            this.groupControl1.TabIndex = 158;
            this.groupControl1.Text = "Nuevo Adoptante";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(194, 60);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(93, 22);
            this.tbId.TabIndex = 336;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(426, 105);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(296, 22);
            this.tbAge.TabIndex = 335;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(913, 58);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(296, 22);
            this.tbEmail.TabIndex = 334;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(914, 161);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(296, 22);
            this.tbAddress.TabIndex = 332;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(913, 111);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(295, 22);
            this.tbNumber.TabIndex = 331;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(426, 60);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(296, 22);
            this.tbName.TabIndex = 330;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(346, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 23);
            this.label11.TabIndex = 298;
            this.label11.Text = "EDAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 296;
            this.label5.Text = "IDENTIFICADOR:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(53, 185);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 64);
            this.btnDelete.TabIndex = 294;
            this.btnDelete.Text = "ELIMINAR";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSaveAndEdit
            // 
            this.btnSaveAndEdit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveAndEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAndEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnSaveAndEdit.ForeColor = System.Drawing.Color.White;
            this.btnSaveAndEdit.Location = new System.Drawing.Point(244, 185);
            this.btnSaveAndEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAndEdit.Name = "btnSaveAndEdit";
            this.btnSaveAndEdit.Size = new System.Drawing.Size(202, 64);
            this.btnSaveAndEdit.TabIndex = 290;
            this.btnSaveAndEdit.Text = "GUARDAR";
            this.btnSaveAndEdit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(802, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 288;
            this.label2.Text = "CORREO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(780, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 284;
            this.label8.Text = "TELEFONO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(782, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 282;
            this.label7.Text = "DOMICILIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(314, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 280;
            this.label6.Text = "NOMBRE:";
            // 
            // AdopterManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 815);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdopterManagementView";
            this.Text = "gestorAdopt";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdopter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveAndEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    private DevExpress.XtraEditors.TextEdit tbAge;
    private DevExpress.XtraEditors.TextEdit tbEmail;
    private DevExpress.XtraEditors.TextEdit tbAddress;
    private DevExpress.XtraEditors.TextEdit tbNumber;
    private DevExpress.XtraEditors.TextEdit tbName;
        private DevExpress.XtraGrid.GridControl dgvAdopter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit tbId;
    }
}