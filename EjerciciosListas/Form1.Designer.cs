namespace EjerciciosListas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.gridAsignaturas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCredMax = new System.Windows.Forms.TextBox();
            this.txtCredMin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre y Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creditos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carrera";
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(237, 38);
            this.txtCreditos.MaxLength = 2;
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(42, 20);
            this.txtCreditos.TabIndex = 4;
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Location = new System.Drawing.Point(80, 38);
            this.txtAsignatura.MaxLength = 30;
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(151, 20);
            this.txtAsignatura.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 38);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(387, 66);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Sistemas",
            "Tecnologias de la Información",
            "Contabilidad y Auditoría",
            "Negocios Internacionales",
            "Enfermería"});
            this.cmbCarrera.Location = new System.Drawing.Point(285, 38);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(177, 21);
            this.cmbCarrera.TabIndex = 8;
            // 
            // gridAsignaturas
            // 
            this.gridAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsignaturas.Location = new System.Drawing.Point(12, 95);
            this.gridAsignaturas.Name = "gridAsignaturas";
            this.gridAsignaturas.Size = new System.Drawing.Size(450, 175);
            this.gridAsignaturas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Listado de Asignaturas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filtrar por Carrera";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(105, 279);
            this.txtCarrera.MaxLength = 30;
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(276, 20);
            this.txtCarrera.TabIndex = 12;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(387, 276);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maxima cantidad de Creditos ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Minima cantidad de Creditos ";
            // 
            // txtCredMax
            // 
            this.txtCredMax.Location = new System.Drawing.Point(164, 311);
            this.txtCredMax.Name = "txtCredMax";
            this.txtCredMax.Size = new System.Drawing.Size(57, 20);
            this.txtCredMax.TabIndex = 16;
            // 
            // txtCredMin
            // 
            this.txtCredMin.Location = new System.Drawing.Point(403, 311);
            this.txtCredMin.Name = "txtCredMin";
            this.txtCredMin.Size = new System.Drawing.Size(59, 20);
            this.txtCredMin.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 341);
            this.Controls.Add(this.txtCredMin);
            this.Controls.Add(this.txtCredMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridAsignaturas);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtAsignatura);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Listas Genericas";
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.DataGridView gridAsignaturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCredMax;
        private System.Windows.Forms.TextBox txtCredMin;
    }
}

