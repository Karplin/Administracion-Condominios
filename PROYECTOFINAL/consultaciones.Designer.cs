﻿namespace PROYECTOFINAL
{
    partial class consultaciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manzanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edificioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reclamacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reclamacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condominesDataSet1 = new PROYECTOFINAL.condominesDataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cManzanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cManzanaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cEdificioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cReclamacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamacionesTableAdapter = new PROYECTOFINAL.condominesDataSet1TableAdapters.reclamacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclamacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condominesDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Buscar Por Edificio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 24;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "CONSULTA DE RECLAMACIONES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.manzanaDataGridViewTextBoxColumn,
            this.edificioDataGridViewTextBoxColumn,
            this.aptoDataGridViewTextBoxColumn,
            this.reclamacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reclamacionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(807, 181);
            this.dataGridView1.TabIndex = 22;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "cedula";
            this.cedulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // manzanaDataGridViewTextBoxColumn
            // 
            this.manzanaDataGridViewTextBoxColumn.DataPropertyName = "manzana";
            this.manzanaDataGridViewTextBoxColumn.HeaderText = "manzana";
            this.manzanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manzanaDataGridViewTextBoxColumn.Name = "manzanaDataGridViewTextBoxColumn";
            this.manzanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // edificioDataGridViewTextBoxColumn
            // 
            this.edificioDataGridViewTextBoxColumn.DataPropertyName = "edificio";
            this.edificioDataGridViewTextBoxColumn.HeaderText = "edificio";
            this.edificioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edificioDataGridViewTextBoxColumn.Name = "edificioDataGridViewTextBoxColumn";
            this.edificioDataGridViewTextBoxColumn.Width = 125;
            // 
            // aptoDataGridViewTextBoxColumn
            // 
            this.aptoDataGridViewTextBoxColumn.DataPropertyName = "apto";
            this.aptoDataGridViewTextBoxColumn.HeaderText = "apto";
            this.aptoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aptoDataGridViewTextBoxColumn.Name = "aptoDataGridViewTextBoxColumn";
            this.aptoDataGridViewTextBoxColumn.Width = 125;
            // 
            // reclamacionDataGridViewTextBoxColumn
            // 
            this.reclamacionDataGridViewTextBoxColumn.DataPropertyName = "reclamacion";
            this.reclamacionDataGridViewTextBoxColumn.HeaderText = "reclamacion";
            this.reclamacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reclamacionDataGridViewTextBoxColumn.Name = "reclamacionDataGridViewTextBoxColumn";
            this.reclamacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // reclamacionesBindingSource
            // 
            this.reclamacionesBindingSource.DataMember = "reclamaciones";
            this.reclamacionesBindingSource.DataSource = this.condominesDataSet1;
            // 
            // condominesDataSet1
            // 
            this.condominesDataSet1.DataSetName = "condominesDataSet1";
            this.condominesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 36);
            this.button2.TabIndex = 27;
            this.button2.Text = "REPORTE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cManzanaToolStripMenuItem,
            this.cManzanaToolStripMenuItem1,
            this.cEdificioToolStripMenuItem,
            this.cReclamacionesToolStripMenuItem,
            this.menuPrincipalToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cManzanaToolStripMenuItem
            // 
            this.cManzanaToolStripMenuItem.Name = "cManzanaToolStripMenuItem";
            this.cManzanaToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.cManzanaToolStripMenuItem.Text = "C.Condomines";
            this.cManzanaToolStripMenuItem.Click += new System.EventHandler(this.cManzanaToolStripMenuItem_Click);
            // 
            // cManzanaToolStripMenuItem1
            // 
            this.cManzanaToolStripMenuItem1.Name = "cManzanaToolStripMenuItem1";
            this.cManzanaToolStripMenuItem1.Size = new System.Drawing.Size(95, 24);
            this.cManzanaToolStripMenuItem1.Text = "C.Manzana";
            this.cManzanaToolStripMenuItem1.Click += new System.EventHandler(this.cManzanaToolStripMenuItem1_Click);
            // 
            // cEdificioToolStripMenuItem
            // 
            this.cEdificioToolStripMenuItem.Name = "cEdificioToolStripMenuItem";
            this.cEdificioToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.cEdificioToolStripMenuItem.Text = "C.Edificio";
            this.cEdificioToolStripMenuItem.Click += new System.EventHandler(this.cEdificioToolStripMenuItem_Click);
            // 
            // cReclamacionesToolStripMenuItem
            // 
            this.cReclamacionesToolStripMenuItem.Name = "cReclamacionesToolStripMenuItem";
            this.cReclamacionesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.cReclamacionesToolStripMenuItem.Text = "C.Pagos";
            this.cReclamacionesToolStripMenuItem.Click += new System.EventHandler(this.cReclamacionesToolStripMenuItem_Click);
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reclamacionesTableAdapter
            // 
            this.reclamacionesTableAdapter.ClearBeforeFill = true;
            // 
            // consultaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(827, 385);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultaciones";
            this.Load += new System.EventHandler(this.consultaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclamacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condominesDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cManzanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cManzanaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cEdificioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cReclamacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private condominesDataSet1 condominesDataSet1;
        private System.Windows.Forms.BindingSource reclamacionesBindingSource;
        private condominesDataSet1TableAdapters.reclamacionesTableAdapter reclamacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manzanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edificioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reclamacionDataGridViewTextBoxColumn;
    }
}