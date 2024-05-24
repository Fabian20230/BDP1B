namespace BDP1B
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
            this.PRUEBA = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NIVEL_DE_PODER = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.TextBox();
            this.RAZA = new System.Windows.Forms.TextBox();
            this.NOMBRE = new System.Windows.Forms.TextBox();
            this.INSERTAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NIVEL_DE_PODER)).BeginInit();
            this.SuspendLayout();
            // 
            // PRUEBA
            // 
            this.PRUEBA.Location = new System.Drawing.Point(69, 47);
            this.PRUEBA.Name = "PRUEBA";
            this.PRUEBA.Size = new System.Drawing.Size(97, 45);
            this.PRUEBA.TabIndex = 0;
            this.PRUEBA.Text = "button";
            this.PRUEBA.UseVisualStyleBackColor = true;
            this.PRUEBA.Click += new System.EventHandler(this.PRUEBA_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(331, 206);
            this.dataGridView1.TabIndex = 1;
            // 
            // carga
            // 
            this.carga.Location = new System.Drawing.Point(701, 160);
            this.carga.Name = "carga";
            this.carga.Size = new System.Drawing.Size(75, 23);
            this.carga.TabIndex = 2;
            this.carga.Text = "Cargar";
            this.carga.UseVisualStyleBackColor = true;
            this.carga.Click += new System.EventHandler(this.carga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "RAZA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "NIVEL DE PODER";
            // 
            // NIVEL_DE_PODER
            // 
            this.NIVEL_DE_PODER.Location = new System.Drawing.Point(343, 133);
            this.NIVEL_DE_PODER.Name = "NIVEL_DE_PODER";
            this.NIVEL_DE_PODER.Size = new System.Drawing.Size(219, 22);
            this.NIVEL_DE_PODER.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(343, 31);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(264, 22);
            this.ID.TabIndex = 8;
            // 
            // RAZA
            // 
            this.RAZA.Location = new System.Drawing.Point(343, 103);
            this.RAZA.Name = "RAZA";
            this.RAZA.Size = new System.Drawing.Size(264, 22);
            this.RAZA.TabIndex = 9;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Location = new System.Drawing.Point(343, 70);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(264, 22);
            this.NOMBRE.TabIndex = 10;
            // 
            // INSERTAR
            // 
            this.INSERTAR.Location = new System.Drawing.Point(477, 239);
            this.INSERTAR.Name = "INSERTAR";
            this.INSERTAR.Size = new System.Drawing.Size(166, 42);
            this.INSERTAR.TabIndex = 11;
            this.INSERTAR.Text = "CREAR";
            this.INSERTAR.UseVisualStyleBackColor = true;
            this.INSERTAR.Click += new System.EventHandler(this.INSERTAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.INSERTAR);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.RAZA);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.NIVEL_DE_PODER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PRUEBA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NIVEL_DE_PODER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PRUEBA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button carga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NIVEL_DE_PODER;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox RAZA;
        private System.Windows.Forms.TextBox NOMBRE;
        private System.Windows.Forms.Button INSERTAR;
    }
}

