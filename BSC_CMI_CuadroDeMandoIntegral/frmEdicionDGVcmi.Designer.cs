namespace BSC_CMI_CuadroDeMandoIntegral
{
    partial class frmEdicionDGVcmi
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
            this.btGuardar = new System.Windows.Forms.Button();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btSubir = new System.Windows.Forms.Button();
            this.btBajar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardar.BackColor = System.Drawing.Color.Goldenrod;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Location = new System.Drawing.Point(634, 470);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(132, 62);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Tag = "0";
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // textBox0
            // 
            this.textBox0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox0.Location = new System.Drawing.Point(12, 12);
            this.textBox0.Multiline = true;
            this.textBox0.Name = "textBox0";
            this.textBox0.ReadOnly = true;
            this.textBox0.Size = new System.Drawing.Size(754, 77);
            this.textBox0.TabIndex = 1;
            this.textBox0.Tag = "0";
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv.Location = new System.Drawing.Point(12, 95);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(604, 437);
            this.dgv.TabIndex = 0;
            this.dgv.Tag = "0";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Objetivo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btNuevo
            // 
            this.btNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNuevo.Location = new System.Drawing.Point(634, 95);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(132, 55);
            this.btNuevo.TabIndex = 3;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btSubir
            // 
            this.btSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSubir.Location = new System.Drawing.Point(634, 172);
            this.btSubir.Name = "btSubir";
            this.btSubir.Size = new System.Drawing.Size(132, 55);
            this.btSubir.TabIndex = 4;
            this.btSubir.Text = "Subir";
            this.btSubir.UseVisualStyleBackColor = true;
            this.btSubir.Click += new System.EventHandler(this.btSubir_Click);
            // 
            // btBajar
            // 
            this.btBajar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBajar.Location = new System.Drawing.Point(634, 250);
            this.btBajar.Name = "btBajar";
            this.btBajar.Size = new System.Drawing.Size(132, 55);
            this.btBajar.TabIndex = 5;
            this.btBajar.Text = "Bajar";
            this.btBajar.UseVisualStyleBackColor = true;
            this.btBajar.Click += new System.EventHandler(this.btBajar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminar.Location = new System.Drawing.Point(634, 328);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(132, 55);
            this.btEliminar.TabIndex = 6;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // frmEdicionDGVcmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btBajar);
            this.Controls.Add(this.btSubir);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.dgv);
            this.Name = "frmEdicionDGVcmi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMI : Edición de Objetivos Estrategicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btSubir;
        private System.Windows.Forms.Button btBajar;
        private System.Windows.Forms.Button btEliminar;
    }
}