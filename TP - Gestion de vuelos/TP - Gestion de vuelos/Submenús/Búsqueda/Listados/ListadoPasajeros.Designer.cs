namespace TP___Gestion_de_vuelos
{
    partial class ListadoPasajeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoPasajeros));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.btnFiltrarPasajeros = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvPasajeros = new System.Windows.Forms.DataGridView();
            this.cbPasajeros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnFiltrarDni = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvDniPasajero = new System.Windows.Forms.DataGridView();
            this.cbDniPasajero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbApellidosZ = new System.Windows.Forms.CheckBox();
            this.cbApellidosA = new System.Windows.Forms.CheckBox();
            this.btnFiltrarApellido = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvApellidos = new System.Windows.Forms.DataGridView();
            this.txtIdPasajero = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDniPasajero)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApellidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(39, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 323);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.txtIdPasajero);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnQuitarFiltro);
            this.tabPage1.Controls.Add(this.btnFiltrarPasajeros);
            this.tabPage1.Controls.Add(this.btnVolver);
            this.tabPage1.Controls.Add(this.dgvPasajeros);
            this.tabPage1.Controls.Add(this.cbPasajeros);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ID Pasajero";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 21);
            this.button1.TabIndex = 26;
            this.button1.Text = "Filtrar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(388, 242);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(140, 35);
            this.btnQuitarFiltro.TabIndex = 24;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // btnFiltrarPasajeros
            // 
            this.btnFiltrarPasajeros.Location = new System.Drawing.Point(242, 242);
            this.btnFiltrarPasajeros.Name = "btnFiltrarPasajeros";
            this.btnFiltrarPasajeros.Size = new System.Drawing.Size(140, 35);
            this.btnFiltrarPasajeros.TabIndex = 22;
            this.btnFiltrarPasajeros.Text = "Filtrar";
            this.btnFiltrarPasajeros.UseVisualStyleBackColor = true;
            this.btnFiltrarPasajeros.Click += new System.EventHandler(this.btnFiltrarPasajeros_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(534, 242);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 35);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver al Menú Principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.Location = new System.Drawing.Point(246, 86);
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.Size = new System.Drawing.Size(428, 150);
            this.dgvPasajeros.TabIndex = 2;
            // 
            // cbPasajeros
            // 
            this.cbPasajeros.FormattingEnabled = true;
            this.cbPasajeros.Location = new System.Drawing.Point(334, 20);
            this.cbPasajeros.Name = "cbPasajeros";
            this.cbPasajeros.Size = new System.Drawing.Size(127, 21);
            this.cbPasajeros.TabIndex = 1;
            this.cbPasajeros.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pasajero:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btnQuitar);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.btnFiltrarDni);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dgvDniPasajero);
            this.tabPage2.Controls.Add(this.cbDniPasajero);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DNI";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(274, 242);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(140, 35);
            this.btnQuitar.TabIndex = 29;
            this.btnQuitar.Text = "Quitar Filtro";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(88, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Igual a:";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(88, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Menor a:";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(88, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mayor a:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarDni
            // 
            this.btnFiltrarDni.Location = new System.Drawing.Point(128, 242);
            this.btnFiltrarDni.Name = "btnFiltrarDni";
            this.btnFiltrarDni.Size = new System.Drawing.Size(140, 35);
            this.btnFiltrarDni.TabIndex = 25;
            this.btnFiltrarDni.Text = "Filtrar";
            this.btnFiltrarDni.UseVisualStyleBackColor = true;
            this.btnFiltrarDni.Click += new System.EventHandler(this.btnFiltrarDni_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 35);
            this.button3.TabIndex = 24;
            this.button3.Text = "Volver al Menú Principal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvDniPasajero
            // 
            this.dgvDniPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDniPasajero.Location = new System.Drawing.Point(128, 76);
            this.dgvDniPasajero.Name = "dgvDniPasajero";
            this.dgvDniPasajero.Size = new System.Drawing.Size(428, 150);
            this.dgvDniPasajero.TabIndex = 23;
            // 
            // cbDniPasajero
            // 
            this.cbDniPasajero.FormattingEnabled = true;
            this.cbDniPasajero.Location = new System.Drawing.Point(174, 28);
            this.cbDniPasajero.Name = "cbDniPasajero";
            this.cbDniPasajero.Size = new System.Drawing.Size(127, 21);
            this.cbDniPasajero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.cbApellidosZ);
            this.tabPage3.Controls.Add(this.cbApellidosA);
            this.tabPage3.Controls.Add(this.btnFiltrarApellido);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.dgvApellidos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(680, 297);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Apellidos";
            // 
            // cbApellidosZ
            // 
            this.cbApellidosZ.AutoSize = true;
            this.cbApellidosZ.Location = new System.Drawing.Point(148, 34);
            this.cbApellidosZ.Name = "cbApellidosZ";
            this.cbApellidosZ.Size = new System.Drawing.Size(49, 17);
            this.cbApellidosZ.TabIndex = 29;
            this.cbApellidosZ.Text = "Z - A";
            this.cbApellidosZ.UseVisualStyleBackColor = true;
            // 
            // cbApellidosA
            // 
            this.cbApellidosA.AutoSize = true;
            this.cbApellidosA.Location = new System.Drawing.Point(65, 34);
            this.cbApellidosA.Name = "cbApellidosA";
            this.cbApellidosA.Size = new System.Drawing.Size(49, 17);
            this.cbApellidosA.TabIndex = 28;
            this.cbApellidosA.Text = "A - Z";
            this.cbApellidosA.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarApellido
            // 
            this.btnFiltrarApellido.Location = new System.Drawing.Point(128, 240);
            this.btnFiltrarApellido.Name = "btnFiltrarApellido";
            this.btnFiltrarApellido.Size = new System.Drawing.Size(140, 35);
            this.btnFiltrarApellido.TabIndex = 27;
            this.btnFiltrarApellido.Text = "Filtrar";
            this.btnFiltrarApellido.UseVisualStyleBackColor = true;
            this.btnFiltrarApellido.Click += new System.EventHandler(this.btnFiltrarApellido_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(416, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 35);
            this.button5.TabIndex = 26;
            this.button5.Text = "Volver al Menú Principal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvApellidos
            // 
            this.dgvApellidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApellidos.Location = new System.Drawing.Point(128, 76);
            this.dgvApellidos.Name = "dgvApellidos";
            this.dgvApellidos.Size = new System.Drawing.Size(428, 150);
            this.dgvApellidos.TabIndex = 25;
            // 
            // txtIdPasajero
            // 
            this.txtIdPasajero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIdPasajero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIdPasajero.Location = new System.Drawing.Point(117, 21);
            this.txtIdPasajero.Name = "txtIdPasajero";
            this.txtIdPasajero.Size = new System.Drawing.Size(112, 20);
            this.txtIdPasajero.TabIndex = 30;
            // 
            // ListadoPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 443);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoPasajeros";
            this.Text = "ListadoPasajeros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListadoPasajeros_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDniPasajero)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApellidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnFiltrarPasajeros;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvPasajeros;
        private System.Windows.Forms.ComboBox cbPasajeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnFiltrarDni;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvDniPasajero;
        private System.Windows.Forms.ComboBox cbDniPasajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFiltrarApellido;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvApellidos;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.CheckBox cbApellidosZ;
        private System.Windows.Forms.CheckBox cbApellidosA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdPasajero;
    }
}