namespace wfConcesionaria_v1
{
    partial class frmAgregarKits
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnidadesKit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrecioKit = new System.Windows.Forms.Label();
            this.txtPrecioKit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoKit = new System.Windows.Forms.TextBox();
            this.lblNuevokits = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUnidadesKit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblPrecioKit);
            this.panel1.Controls.Add(this.txtPrecioKit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNuevoKit);
            this.panel1.Controls.Add(this.lblNuevokits);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 236);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unidades kit";
            // 
            // txtUnidadesKit
            // 
            this.txtUnidadesKit.Location = new System.Drawing.Point(144, 150);
            this.txtUnidadesKit.Name = "txtUnidadesKit";
            this.txtUnidadesKit.Size = new System.Drawing.Size(144, 20);
            this.txtUnidadesKit.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(97, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar kit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrecioKit
            // 
            this.lblPrecioKit.AutoSize = true;
            this.lblPrecioKit.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioKit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioKit.Location = new System.Drawing.Point(15, 104);
            this.lblPrecioKit.Name = "lblPrecioKit";
            this.lblPrecioKit.Size = new System.Drawing.Size(88, 19);
            this.lblPrecioKit.TabIndex = 2;
            this.lblPrecioKit.Text = "Precio Kit";
            // 
            // txtPrecioKit
            // 
            this.txtPrecioKit.Location = new System.Drawing.Point(144, 106);
            this.txtPrecioKit.Name = "txtPrecioKit";
            this.txtPrecioKit.Size = new System.Drawing.Size(144, 20);
            this.txtPrecioKit.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 49);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kit";
            // 
            // txtNuevoKit
            // 
            this.txtNuevoKit.Location = new System.Drawing.Point(144, 67);
            this.txtNuevoKit.Name = "txtNuevoKit";
            this.txtNuevoKit.Size = new System.Drawing.Size(144, 20);
            this.txtNuevoKit.TabIndex = 1;
            // 
            // lblNuevokits
            // 
            this.lblNuevokits.AutoSize = true;
            this.lblNuevokits.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevokits.Location = new System.Drawing.Point(15, 65);
            this.lblNuevokits.Name = "lblNuevokits";
            this.lblNuevokits.Size = new System.Drawing.Size(94, 19);
            this.lblNuevokits.TabIndex = 0;
            this.lblNuevokits.Text = "Kit Nuevo:";
            // 
            // frmAgregarKits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 234);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarKits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarKits";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrecioKit;
        private System.Windows.Forms.TextBox txtPrecioKit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoKit;
        private System.Windows.Forms.Label lblNuevokits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidadesKit;
    }
}