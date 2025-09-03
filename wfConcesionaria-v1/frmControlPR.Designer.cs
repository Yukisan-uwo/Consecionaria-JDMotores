namespace wfConcesionaria_v1
{
    partial class frmControlPR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarDes = new System.Windows.Forms.Button();
            this.btnAgregarDes = new System.Windows.Forms.Button();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRegalo = new System.Windows.Forms.TextBox();
            this.btnAgregarRegalo = new System.Windows.Forms.Button();
            this.btnEliminarRegalo = new System.Windows.Forms.Button();
            this.dgvRegalos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegalos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnEliminarDes);
            this.panel1.Controls.Add(this.btnAgregarDes);
            this.panel1.Controls.Add(this.txtFechaInicio);
            this.panel1.Controls.Add(this.txtFechaFin);
            this.panel1.Controls.Add(this.txtDescuento);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvDescuentos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 690);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(564, 182);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(22, 23);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(564, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(22, 23);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnEliminarDes
            // 
            this.btnEliminarDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarDes.Location = new System.Drawing.Point(130, 260);
            this.btnEliminarDes.Name = "btnEliminarDes";
            this.btnEliminarDes.Size = new System.Drawing.Size(93, 29);
            this.btnEliminarDes.TabIndex = 8;
            this.btnEliminarDes.Text = "Eliminar";
            this.btnEliminarDes.UseVisualStyleBackColor = false;
            this.btnEliminarDes.Click += new System.EventHandler(this.btnEliminarDes_Click);
            // 
            // btnAgregarDes
            // 
            this.btnAgregarDes.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarDes.Location = new System.Drawing.Point(13, 260);
            this.btnAgregarDes.Name = "btnAgregarDes";
            this.btnAgregarDes.Size = new System.Drawing.Size(91, 29);
            this.btnAgregarDes.TabIndex = 8;
            this.btnAgregarDes.Text = "Agregar";
            this.btnAgregarDes.UseVisualStyleBackColor = false;
            this.btnAgregarDes.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(227, 141);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = true;
            this.txtFechaInicio.Size = new System.Drawing.Size(338, 23);
            this.txtFechaInicio.TabIndex = 7;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(227, 182);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.ReadOnly = true;
            this.txtFechaFin.Size = new System.Drawing.Size(338, 23);
            this.txtFechaFin.TabIndex = 6;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(227, 226);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(359, 23);
            this.txtDescuento.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(227, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(359, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrar Promociones";
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.AllowUserToAddRows = false;
            this.dgvDescuentos.AllowUserToDeleteRows = false;
            this.dgvDescuentos.AllowUserToResizeColumns = false;
            this.dgvDescuentos.AllowUserToResizeRows = false;
            this.dgvDescuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDescuentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(13, 296);
            this.dgvDescuentos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.RowHeadersVisible = false;
            this.dgvDescuentos.RowHeadersWidth = 51;
            this.dgvDescuentos.RowTemplate.Height = 24;
            this.dgvDescuentos.Size = new System.Drawing.Size(573, 331);
            this.dgvDescuentos.TabIndex = 0;
            this.dgvDescuentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDescuentos_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Regalo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(639, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 27);
            this.label10.TabIndex = 3;
            this.label10.Text = "Administrar Regalos";
            // 
            // txtRegalo
            // 
            this.txtRegalo.Location = new System.Drawing.Point(705, 157);
            this.txtRegalo.Name = "txtRegalo";
            this.txtRegalo.Size = new System.Drawing.Size(196, 23);
            this.txtRegalo.TabIndex = 4;
            // 
            // btnAgregarRegalo
            // 
            this.btnAgregarRegalo.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarRegalo.Location = new System.Drawing.Point(614, 260);
            this.btnAgregarRegalo.Name = "btnAgregarRegalo";
            this.btnAgregarRegalo.Size = new System.Drawing.Size(91, 29);
            this.btnAgregarRegalo.TabIndex = 8;
            this.btnAgregarRegalo.Text = "Agregar";
            this.btnAgregarRegalo.UseVisualStyleBackColor = false;
            this.btnAgregarRegalo.Click += new System.EventHandler(this.btnAgregarRegalo_Click);
            // 
            // btnEliminarRegalo
            // 
            this.btnEliminarRegalo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarRegalo.Location = new System.Drawing.Point(733, 260);
            this.btnEliminarRegalo.Name = "btnEliminarRegalo";
            this.btnEliminarRegalo.Size = new System.Drawing.Size(93, 29);
            this.btnEliminarRegalo.TabIndex = 8;
            this.btnEliminarRegalo.Text = "Eliminar";
            this.btnEliminarRegalo.UseVisualStyleBackColor = false;
            this.btnEliminarRegalo.Click += new System.EventHandler(this.btnEliminarRegalo_Click);
            // 
            // dgvRegalos
            // 
            this.dgvRegalos.AllowUserToAddRows = false;
            this.dgvRegalos.AllowUserToDeleteRows = false;
            this.dgvRegalos.AllowUserToResizeColumns = false;
            this.dgvRegalos.AllowUserToResizeRows = false;
            this.dgvRegalos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegalos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegalos.Location = new System.Drawing.Point(614, 296);
            this.dgvRegalos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRegalos.Name = "dgvRegalos";
            this.dgvRegalos.RowHeadersVisible = false;
            this.dgvRegalos.RowHeadersWidth = 51;
            this.dgvRegalos.RowTemplate.Height = 24;
            this.dgvRegalos.Size = new System.Drawing.Size(289, 331);
            this.dgvRegalos.TabIndex = 11;
            this.dgvRegalos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegalos_CellDoubleClick);
            // 
            // frmControlPR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(914, 640);
            this.Controls.Add(this.dgvRegalos);
            this.Controls.Add(this.btnEliminarRegalo);
            this.Controls.Add(this.btnAgregarRegalo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRegalo);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmControlPR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControlPR";
            this.Load += new System.EventHandler(this.frmControlPR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegalos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDescuentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRegalo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEliminarDes;
        private System.Windows.Forms.Button btnAgregarDes;
        private System.Windows.Forms.Button btnAgregarRegalo;
        private System.Windows.Forms.Button btnEliminarRegalo;
        private System.Windows.Forms.DataGridView dgvRegalos;
    }
}