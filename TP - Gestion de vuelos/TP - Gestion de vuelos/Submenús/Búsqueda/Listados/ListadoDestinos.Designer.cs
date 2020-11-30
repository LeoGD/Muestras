namespace TP___Gestion_de_vuelos
{
    partial class ListadoDestinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoDestinos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.btnFiltrarDestino = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbDestinos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnFiltrarPaisDestino = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvPaisDestino = new System.Windows.Forms.DataGridView();
            this.cbPaisDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaisDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(36, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 323);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnQuitarFiltro);
            this.tabPage1.Controls.Add(this.btnFiltrarDestino);
            this.tabPage1.Controls.Add(this.btnVolver);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Controls.Add(this.cbDestinos);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ID Destino";
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(274, 242);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(140, 35);
            this.btnQuitarFiltro.TabIndex = 23;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // btnFiltrarDestino
            // 
            this.btnFiltrarDestino.Location = new System.Drawing.Point(128, 242);
            this.btnFiltrarDestino.Name = "btnFiltrarDestino";
            this.btnFiltrarDestino.Size = new System.Drawing.Size(140, 35);
            this.btnFiltrarDestino.TabIndex = 22;
            this.btnFiltrarDestino.Text = "Filtrar";
            this.btnFiltrarDestino.UseVisualStyleBackColor = true;
            this.btnFiltrarDestino.Click += new System.EventHandler(this.btnFiltrarDestino_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(417, 242);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 35);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver al Menú Principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(128, 76);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(428, 150);
            this.dgv.TabIndex = 2;
            // 
            // cbDestinos
            // 
            this.cbDestinos.FormattingEnabled = true;
            this.cbDestinos.Location = new System.Drawing.Point(128, 28);
            this.cbDestinos.Name = "cbDestinos";
            this.cbDestinos.Size = new System.Drawing.Size(127, 21);
            this.cbDestinos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Destino:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.btnQuitar);
            this.tabPage2.Controls.Add(this.btnFiltrarPaisDestino);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dgvPaisDestino);
            this.tabPage2.Controls.Add(this.cbPaisDestino);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pais";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(274, 242);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(140, 35);
            this.btnQuitar.TabIndex = 26;
            this.btnQuitar.Text = "Quitar Filtro";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnFiltrarPaisDestino
            // 
            this.btnFiltrarPaisDestino.Location = new System.Drawing.Point(128, 242);
            this.btnFiltrarPaisDestino.Name = "btnFiltrarPaisDestino";
            this.btnFiltrarPaisDestino.Size = new System.Drawing.Size(140, 35);
            this.btnFiltrarPaisDestino.TabIndex = 25;
            this.btnFiltrarPaisDestino.Text = "Filtrar";
            this.btnFiltrarPaisDestino.UseVisualStyleBackColor = true;
            this.btnFiltrarPaisDestino.Click += new System.EventHandler(this.btnFiltrarPaisDestino_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 35);
            this.button3.TabIndex = 24;
            this.button3.Text = "Volver al Menú Principal";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvPaisDestino
            // 
            this.dgvPaisDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaisDestino.Location = new System.Drawing.Point(128, 76);
            this.dgvPaisDestino.Name = "dgvPaisDestino";
            this.dgvPaisDestino.Size = new System.Drawing.Size(428, 150);
            this.dgvPaisDestino.TabIndex = 23;
            // 
            // cbPaisDestino
            // 
            this.cbPaisDestino.FormattingEnabled = true;
            this.cbPaisDestino.Location = new System.Drawing.Point(128, 28);
            this.cbPaisDestino.Name = "cbPaisDestino";
            this.cbPaisDestino.Size = new System.Drawing.Size(127, 21);
            this.cbPaisDestino.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Pais:";
            // 
            // ListadoDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 443);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoDestinos";
            this.Text = "ListadoDestinos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListadoDestinos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaisDestino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbDestinos;
        private System.Windows.Forms.Button btnFiltrarDestino;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cbPaisDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrarPaisDestino;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvPaisDestino;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.Button btnQuitar;
    }
}