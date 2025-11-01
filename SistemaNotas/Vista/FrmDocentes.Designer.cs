namespace SistemaNotas.Vista
{
    partial class FrmDocentes
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbDato2 = new System.Windows.Forms.ToolStripTextBox();
            this.GruopBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbApellidoD = new System.Windows.Forms.TextBox();
            this.tbCodigoD = new System.Windows.Forms.TextBox();
            this.tbNombreD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRegistroD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.GruopBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbDato2,
            this.btnBuscar2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(136, 28);
            this.toolStripLabel1.Text = "Buscar docente:";
            // 
            // tbDato2
            // 
            this.tbDato2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDato2.Name = "tbDato2";
            this.tbDato2.Size = new System.Drawing.Size(100, 33);
            // 
            // GruopBox1
            // 
            this.GruopBox1.Controls.Add(this.label3);
            this.GruopBox1.Controls.Add(this.tbApellidoD);
            this.GruopBox1.Controls.Add(this.tbCodigoD);
            this.GruopBox1.Controls.Add(this.tbNombreD);
            this.GruopBox1.Controls.Add(this.label2);
            this.GruopBox1.Controls.Add(this.label1);
            this.GruopBox1.Location = new System.Drawing.Point(22, 55);
            this.GruopBox1.Name = "GruopBox1";
            this.GruopBox1.Size = new System.Drawing.Size(248, 130);
            this.GruopBox1.TabIndex = 1;
            this.GruopBox1.TabStop = false;
            this.GruopBox1.Text = "Datos del docente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // tbApellidoD
            // 
            this.tbApellidoD.Location = new System.Drawing.Point(86, 51);
            this.tbApellidoD.Name = "tbApellidoD";
            this.tbApellidoD.Size = new System.Drawing.Size(100, 26);
            this.tbApellidoD.TabIndex = 4;
            // 
            // tbCodigoD
            // 
            this.tbCodigoD.Location = new System.Drawing.Point(83, 94);
            this.tbCodigoD.Name = "tbCodigoD";
            this.tbCodigoD.Size = new System.Drawing.Size(91, 26);
            this.tbCodigoD.TabIndex = 3;
            // 
            // tbNombreD
            // 
            this.tbNombreD.Location = new System.Drawing.Point(83, 19);
            this.tbNombreD.Name = "tbNombreD";
            this.tbNombreD.Size = new System.Drawing.Size(147, 26);
            this.tbNombreD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // dgvRegistroD
            // 
            this.dgvRegistroD.AllowUserToAddRows = false;
            this.dgvRegistroD.AllowUserToDeleteRows = false;
            this.dgvRegistroD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroD.Location = new System.Drawing.Point(3, 22);
            this.dgvRegistroD.Name = "dgvRegistroD";
            this.dgvRegistroD.ReadOnly = true;
            this.dgvRegistroD.RowHeadersWidth = 62;
            this.dgvRegistroD.RowTemplate.Height = 28;
            this.dgvRegistroD.Size = new System.Drawing.Size(475, 194);
            this.dgvRegistroD.TabIndex = 2;
            this.dgvRegistroD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRegistroD);
            this.groupBox1.Location = new System.Drawing.Point(22, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros guardados = 0";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SistemaNotas.Properties.Resources.Agregar1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Agregar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::SistemaNotas.Properties.Resources.Eliminar1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "Eliminar";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar2.Image = global::SistemaNotas.Properties.Resources.lupa;
            this.btnBuscar2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(34, 28);
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // FrmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GruopBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmDocentes";
            this.Text = "Docentes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GruopBox1.ResumeLayout(false);
            this.GruopBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnBuscar2;
        private System.Windows.Forms.ToolStripTextBox tbDato2;
        private System.Windows.Forms.GroupBox GruopBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbApellidoD;
        private System.Windows.Forms.TextBox tbCodigoD;
        private System.Windows.Forms.TextBox tbNombreD;
        private System.Windows.Forms.DataGridView dgvRegistroD;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}