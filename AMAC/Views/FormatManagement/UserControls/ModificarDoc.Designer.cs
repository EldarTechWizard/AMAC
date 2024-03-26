namespace DiseñoAMAC
{
    partial class ModificarDoc
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarDoc));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btRespons = new DevExpress.XtraEditors.SimpleButton();
            this.btDatosAdopt = new DevExpress.XtraEditors.SimpleButton();
            this.btDatosMascota = new DevExpress.XtraEditors.SimpleButton();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelmodificar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridLookUpEdit1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelmodificar, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.92793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.07207F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 606F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1269, 693);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btRespons, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btDatosAdopt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btDatosMascota, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1263, 56);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btRespons
            // 
            this.btRespons.Appearance.BackColor = System.Drawing.Color.MidnightBlue;
            this.btRespons.Appearance.BorderColor = System.Drawing.Color.White;
            this.btRespons.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRespons.Appearance.Options.UseBackColor = true;
            this.btRespons.Appearance.Options.UseBorderColor = true;
            this.btRespons.Appearance.Options.UseFont = true;
            this.btRespons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRespons.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btRespons.ImageOptions.SvgImage")));
            this.btRespons.Location = new System.Drawing.Point(845, 3);
            this.btRespons.Name = "btRespons";
            this.btRespons.Size = new System.Drawing.Size(415, 50);
            this.btRespons.TabIndex = 101;
            this.btRespons.Text = "Responsabilidades";
            this.btRespons.Click += new System.EventHandler(this.btRespons_Click);
            // 
            // btDatosAdopt
            // 
            this.btDatosAdopt.Appearance.BackColor = System.Drawing.Color.MidnightBlue;
            this.btDatosAdopt.Appearance.BorderColor = System.Drawing.Color.White;
            this.btDatosAdopt.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatosAdopt.Appearance.Options.UseBackColor = true;
            this.btDatosAdopt.Appearance.Options.UseBorderColor = true;
            this.btDatosAdopt.Appearance.Options.UseFont = true;
            this.btDatosAdopt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDatosAdopt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btDatosAdopt.ImageOptions.SvgImage")));
            this.btDatosAdopt.Location = new System.Drawing.Point(424, 3);
            this.btDatosAdopt.Name = "btDatosAdopt";
            this.btDatosAdopt.Size = new System.Drawing.Size(415, 50);
            this.btDatosAdopt.TabIndex = 100;
            this.btDatosAdopt.Text = "Datos del Adoptante";
            this.btDatosAdopt.Click += new System.EventHandler(this.btDatosAdopt_Click);
            // 
            // btDatosMascota
            // 
            this.btDatosMascota.Appearance.BackColor = System.Drawing.Color.MidnightBlue;
            this.btDatosMascota.Appearance.BorderColor = System.Drawing.Color.White;
            this.btDatosMascota.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatosMascota.Appearance.Options.UseBackColor = true;
            this.btDatosMascota.Appearance.Options.UseBorderColor = true;
            this.btDatosMascota.Appearance.Options.UseFont = true;
            this.btDatosMascota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDatosMascota.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btDatosMascota.ImageOptions.SvgImage")));
            this.btDatosMascota.Location = new System.Drawing.Point(3, 3);
            this.btDatosMascota.Name = "btDatosMascota";
            this.btDatosMascota.Size = new System.Drawing.Size(415, 50);
            this.btDatosMascota.TabIndex = 99;
            this.btDatosMascota.Text = "Datos de la Mascota";
            this.btDatosMascota.Click += new System.EventHandler(this.btDatosMascota_Click);
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLookUpEdit1.Location = new System.Drawing.Point(3, 3);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(1263, 22);
            this.gridLookUpEdit1.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelmodificar
            // 
            this.panelmodificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmodificar.Location = new System.Drawing.Point(3, 89);
            this.panelmodificar.Name = "panelmodificar";
            this.panelmodificar.Size = new System.Drawing.Size(1263, 601);
            this.panelmodificar.TabIndex = 2;
            // 
            // ModificarDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ModificarDoc";
            this.Size = new System.Drawing.Size(1269, 693);
            this.SizeChanged += new System.EventHandler(this.UserControl1_SizeChanged);
            this.Resize += new System.EventHandler(this.UserControl1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btRespons;
        private DevExpress.XtraEditors.SimpleButton btDatosAdopt;
        private DevExpress.XtraEditors.SimpleButton btDatosMascota;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Panel panelmodificar;
    }
}
