namespace LaboratorioFinalDB
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxAnio_lanzamiento = new System.Windows.Forms.TextBox();
            this.textBoxGeneracion = new System.Windows.Forms.TextBox();
            this.comboBoxCompania = new System.Windows.Forms.ComboBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.dataGridViewConsolas = new System.Windows.Forms.DataGridView();
            this.buttonCargarRegistros = new System.Windows.Forms.Button();
            this.buttonBuscarPorID = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFiltrar_porNintendo = new System.Windows.Forms.Button();
            this.buttonFiltrar_porSega = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Harper Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MIJELI AZUCENA LUCERO BURGOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Harper Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(93, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "CARNE 0905-23-5501";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(79, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(79, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Compañía:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(79, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Año de Lanzamiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(79, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Generación:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(325, 176);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(259, 26);
            this.textBoxID.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(325, 250);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(259, 26);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxAnio_lanzamiento
            // 
            this.textBoxAnio_lanzamiento.Location = new System.Drawing.Point(325, 380);
            this.textBoxAnio_lanzamiento.Name = "textBoxAnio_lanzamiento";
            this.textBoxAnio_lanzamiento.Size = new System.Drawing.Size(259, 26);
            this.textBoxAnio_lanzamiento.TabIndex = 10;
            // 
            // textBoxGeneracion
            // 
            this.textBoxGeneracion.Location = new System.Drawing.Point(325, 446);
            this.textBoxGeneracion.Name = "textBoxGeneracion";
            this.textBoxGeneracion.Size = new System.Drawing.Size(259, 26);
            this.textBoxGeneracion.TabIndex = 11;
            // 
            // comboBoxCompania
            // 
            this.comboBoxCompania.FormattingEnabled = true;
            this.comboBoxCompania.Location = new System.Drawing.Point(325, 318);
            this.comboBoxCompania.Name = "comboBoxCompania";
            this.comboBoxCompania.Size = new System.Drawing.Size(259, 28);
            this.comboBoxCompania.TabIndex = 12;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(84, 532);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(152, 49);
            this.buttonCrear.TabIndex = 13;
            this.buttonCrear.Text = "Crear Registro";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // dataGridViewConsolas
            // 
            this.dataGridViewConsolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsolas.Location = new System.Drawing.Point(791, 176);
            this.dataGridViewConsolas.Name = "dataGridViewConsolas";
            this.dataGridViewConsolas.RowHeadersWidth = 62;
            this.dataGridViewConsolas.RowTemplate.Height = 28;
            this.dataGridViewConsolas.Size = new System.Drawing.Size(756, 296);
            this.dataGridViewConsolas.TabIndex = 14;
            // 
            // buttonCargarRegistros
            // 
            this.buttonCargarRegistros.Location = new System.Drawing.Point(791, 525);
            this.buttonCargarRegistros.Name = "buttonCargarRegistros";
            this.buttonCargarRegistros.Size = new System.Drawing.Size(187, 61);
            this.buttonCargarRegistros.TabIndex = 15;
            this.buttonCargarRegistros.Text = "Cargar todos los registros";
            this.buttonCargarRegistros.UseVisualStyleBackColor = true;
            this.buttonCargarRegistros.Click += new System.EventHandler(this.buttonCargarRegistros_Click);
            // 
            // buttonBuscarPorID
            // 
            this.buttonBuscarPorID.Location = new System.Drawing.Point(597, 173);
            this.buttonBuscarPorID.Name = "buttonBuscarPorID";
            this.buttonBuscarPorID.Size = new System.Drawing.Size(128, 33);
            this.buttonBuscarPorID.TabIndex = 16;
            this.buttonBuscarPorID.Text = "Buscar por Id";
            this.buttonBuscarPorID.UseVisualStyleBackColor = true;
            this.buttonBuscarPorID.Click += new System.EventHandler(this.buttonBuscarPorID_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(260, 532);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(152, 49);
            this.buttonActualizar.TabIndex = 17;
            this.buttonActualizar.Text = "Actualizar registro";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(432, 532);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(152, 49);
            this.buttonEliminar.TabIndex = 18;
            this.buttonEliminar.Text = "Eliminar registro";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(260, 34);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(110, 33);
            this.buttonSiguiente.TabIndex = 20;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(116, 34);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(110, 33);
            this.buttonAnterior.TabIndex = 21;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.buttonFiltrar_porSega);
            this.groupBox1.Controls.Add(this.buttonFiltrar_porNintendo);
            this.groupBox1.Location = new System.Drawing.Point(1316, 512);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 193);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas por filtro";
            // 
            // buttonFiltrar_porNintendo
            // 
            this.buttonFiltrar_porNintendo.Location = new System.Drawing.Point(31, 32);
            this.buttonFiltrar_porNintendo.Name = "buttonFiltrar_porNintendo";
            this.buttonFiltrar_porNintendo.Size = new System.Drawing.Size(171, 42);
            this.buttonFiltrar_porNintendo.TabIndex = 0;
            this.buttonFiltrar_porNintendo.Text = "Filtrar por Nintendo";
            this.buttonFiltrar_porNintendo.UseVisualStyleBackColor = true;
            this.buttonFiltrar_porNintendo.Click += new System.EventHandler(this.buttonFiltrar_porNintendo_Click);
            // 
            // buttonFiltrar_porSega
            // 
            this.buttonFiltrar_porSega.Location = new System.Drawing.Point(31, 85);
            this.buttonFiltrar_porSega.Name = "buttonFiltrar_porSega";
            this.buttonFiltrar_porSega.Size = new System.Drawing.Size(171, 42);
            this.buttonFiltrar_porSega.TabIndex = 1;
            this.buttonFiltrar_porSega.Text = "Filtrar por Sega";
            this.buttonFiltrar_porSega.UseVisualStyleBackColor = true;
            this.buttonFiltrar_porSega.Click += new System.EventHandler(this.buttonFiltrar_porSega_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Filtrar por Sony";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Font = new System.Drawing.Font("Harper Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(1192, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "DANIELA MARICLER GÜITZ PALMA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Font = new System.Drawing.Font("Harper Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1342, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "CARNE 0905-23-15374";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAnterior);
            this.groupBox2.Controls.Add(this.buttonSiguiente);
            this.groupBox2.Location = new System.Drawing.Point(84, 620);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 85);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navegación de los registros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1662, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonBuscarPorID);
            this.Controls.Add(this.buttonCargarRegistros);
            this.Controls.Add(this.dataGridViewConsolas);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.comboBoxCompania);
            this.Controls.Add(this.textBoxGeneracion);
            this.Controls.Add(this.textBoxAnio_lanzamiento);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos sobre Consolas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxAnio_lanzamiento;
        private System.Windows.Forms.TextBox textBoxGeneracion;
        private System.Windows.Forms.ComboBox comboBoxCompania;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.DataGridView dataGridViewConsolas;
        private System.Windows.Forms.Button buttonCargarRegistros;
        private System.Windows.Forms.Button buttonBuscarPorID;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonFiltrar_porSega;
        private System.Windows.Forms.Button buttonFiltrar_porNintendo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

