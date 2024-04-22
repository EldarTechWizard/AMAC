namespace AMAC.Views.FormatManagement.FormatControls.FormatAdopterView
{
    partial class FormatAdopterView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.peSeachAdopter = new DevExpress.XtraEditors.PictureEdit();
            this.tbAdopterlId = new DevExpress.XtraEditors.TextEdit();
            this.tbEmail = new DevExpress.XtraEditors.TextEdit();
            this.tbAddress = new DevExpress.XtraEditors.TextEdit();
            this.tbNumber = new DevExpress.XtraEditors.TextEdit();
            this.tbAge = new DevExpress.XtraEditors.TextEdit();
            this.tbName = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peSeachAdopter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdopterlId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 175);
            this.panel1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.Controls.Add(this.peSeachAdopter);
            this.groupControl2.Controls.Add(this.tbAdopterlId);
            this.groupControl2.Controls.Add(this.tbEmail);
            this.groupControl2.Controls.Add(this.tbAddress);
            this.groupControl2.Controls.Add(this.tbNumber);
            this.groupControl2.Controls.Add(this.tbAge);
            this.groupControl2.Controls.Add(this.tbName);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label14);
            this.groupControl2.Controls.Add(this.label15);
            this.groupControl2.Controls.Add(this.label16);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1083, 175);
            this.groupControl2.TabIndex = 265;
            this.groupControl2.Text = "Datos generales del Adoptante";
            // 
            // peSeachAdopter
            // 
            this.peSeachAdopter.Location = new System.Drawing.Point(249, 46);
            this.peSeachAdopter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.peSeachAdopter.Name = "peSeachAdopter";
            this.peSeachAdopter.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSeachAdopter.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peSeachAdopter.Size = new System.Drawing.Size(30, 20);
            this.peSeachAdopter.TabIndex = 2;
            // 
            // tbAdopterlId
            // 
            this.tbAdopterlId.Location = new System.Drawing.Point(136, 46);
            this.tbAdopterlId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdopterlId.Name = "tbAdopterlId";
            this.tbAdopterlId.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbAdopterlId.Properties.MaskSettings.Set("mask", "\\d+");
            this.tbAdopterlId.Size = new System.Drawing.Size(107, 20);
            this.tbAdopterlId.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(807, 82);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Properties.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(243, 20);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.EditValueChanged += new System.EventHandler(this.tbEmail_EditValueChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(394, 115);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbAddress.Properties.MaskSettings.Set("mask", "\\p{L}+");
            this.tbAddress.Properties.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(289, 20);
            this.tbAddress.TabIndex = 5;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(394, 83);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbNumber.Properties.MaskSettings.Set("mask", "\\p{L}+");
            this.tbNumber.Properties.ReadOnly = true;
            this.tbNumber.Size = new System.Drawing.Size(289, 20);
            this.tbNumber.TabIndex = 4;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(807, 49);
            this.tbAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAge.Name = "tbAge";
            this.tbAge.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbAge.Properties.MaskSettings.Set("mask", "\\d+");
            this.tbAge.Properties.ReadOnly = true;
            this.tbAge.Size = new System.Drawing.Size(243, 20);
            this.tbAge.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(394, 49);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.tbName.Properties.MaskSettings.Set("mask", "\\p{L}+");
            this.tbName.Properties.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(289, 20);
            this.tbName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(738, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 319;
            this.label11.Text = "EDAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(99, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 317;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(712, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 313;
            this.label4.Text = "CORREO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(280, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 18);
            this.label14.TabIndex = 309;
            this.label14.Text = "TELEFONO:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(280, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 18);
            this.label15.TabIndex = 307;
            this.label15.Text = "DOMICILIO:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(297, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 18);
            this.label16.TabIndex = 305;
            this.label16.Text = "NOMBRE:";
            // 
            // FormatAdopterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 175);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormatAdopterView";
            this.Text = "ModificarDoc_Adopt";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peSeachAdopter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdopterlId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.TextEdit tbEmail;
        private DevExpress.XtraEditors.TextEdit tbAddress;
        private DevExpress.XtraEditors.TextEdit tbNumber;
        private DevExpress.XtraEditors.TextEdit tbAge;
        private DevExpress.XtraEditors.TextEdit tbName;
        private DevExpress.XtraEditors.PictureEdit peSeachAdopter;
        private DevExpress.XtraEditors.TextEdit tbAdopterlId;
    }
}