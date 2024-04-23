namespace AMAC
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode1.LevelTemplate = this.cardView1;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 391);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cName,
            this.cAge,
            this.cAddress,
            this.cNumber,
            this.cEmail});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // cName
            // 
            this.cName.Caption = "Nombre";
            this.cName.FieldName = "nombre";
            this.cName.MinWidth = 25;
            this.cName.Name = "cName";
            this.cName.Visible = true;
            this.cName.VisibleIndex = 0;
            this.cName.Width = 94;
            // 
            // cAge
            // 
            this.cAge.Caption = "Edad";
            this.cAge.FieldName = "edad";
            this.cAge.MinWidth = 25;
            this.cAge.Name = "cAge";
            this.cAge.Visible = true;
            this.cAge.VisibleIndex = 1;
            this.cAge.Width = 94;
            // 
            // cAddress
            // 
            this.cAddress.Caption = "Numero1";
            this.cAddress.FieldName = "numero";
            this.cAddress.MinWidth = 25;
            this.cAddress.Name = "cAddress";
            this.cAddress.Visible = true;
            this.cAddress.VisibleIndex = 3;
            this.cAddress.Width = 94;
            // 
            // cNumber
            // 
            this.cNumber.Caption = "Domicilio";
            this.cNumber.FieldName = "domicilio";
            this.cNumber.MinWidth = 25;
            this.cNumber.Name = "cNumber";
            this.cNumber.Visible = true;
            this.cNumber.VisibleIndex = 4;
            this.cNumber.Width = 94;
            // 
            // cEmail
            // 
            this.cEmail.Caption = "Correo";
            this.cEmail.FieldName = "correo";
            this.cEmail.MinWidth = 25;
            this.cEmail.Name = "cEmail";
            this.cEmail.Visible = true;
            this.cEmail.VisibleIndex = 2;
            this.cEmail.Width = 94;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "";
            this.lookUpEdit1.Location = new System.Drawing.Point(56, 12);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("voluntario", "Voluntario"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("fecha de adopcion", "Fecha")});
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Size = new System.Drawing.Size(707, 22);
            this.lookUpEdit1.TabIndex = 1;
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cName;
        private DevExpress.XtraGrid.Columns.GridColumn cAge;
        private DevExpress.XtraGrid.Columns.GridColumn cEmail;
        private DevExpress.XtraGrid.Columns.GridColumn cAddress;
        private DevExpress.XtraGrid.Columns.GridColumn cNumber;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}

