namespace wfConcesionaria_v1
{
    partial class frmColores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColores));
            this.lblColorNew = new System.Windows.Forms.Label();
            this.lblrgb = new System.Windows.Forms.Label();
            this.txtNuevocolor = new System.Windows.Forms.TextBox();
            this.txtColorRGB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColorNew
            // 
            this.lblColorNew.AutoSize = true;
            this.lblColorNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorNew.Location = new System.Drawing.Point(20, 80);
            this.lblColorNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColorNew.Name = "lblColorNew";
            this.lblColorNew.Size = new System.Drawing.Size(139, 24);
            this.lblColorNew.TabIndex = 0;
            this.lblColorNew.Text = "Color Nuevo:";
            // 
            // lblrgb
            // 
            this.lblrgb.AutoSize = true;
            this.lblrgb.BackColor = System.Drawing.Color.Transparent;
            this.lblrgb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrgb.Location = new System.Drawing.Point(40, 127);
            this.lblrgb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrgb.Name = "lblrgb";
            this.lblrgb.Size = new System.Drawing.Size(119, 24);
            this.lblrgb.TabIndex = 2;
            this.lblrgb.Text = "Color RGB:";
            // 
            // txtNuevocolor
            // 
            this.txtNuevocolor.Location = new System.Drawing.Point(212, 79);
            this.txtNuevocolor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNuevocolor.Name = "txtNuevocolor";
            this.txtNuevocolor.Size = new System.Drawing.Size(191, 22);
            this.txtNuevocolor.TabIndex = 1;
            // 
            // txtColorRGB
            // 
            this.txtColorRGB.Location = new System.Drawing.Point(212, 131);
            this.txtColorRGB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColorRGB.Name = "txtColorRGB";
            this.txtColorRGB.Size = new System.Drawing.Size(191, 22);
            this.txtColorRGB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(126, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblrgb);
            this.panel1.Controls.Add(this.txtColorRGB);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNuevocolor);
            this.panel1.Controls.Add(this.lblColorNew);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 302);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 60);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Colores";
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 264);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblColorNew;
        private System.Windows.Forms.Label lblrgb;
        private System.Windows.Forms.TextBox txtNuevocolor;
        private System.Windows.Forms.TextBox txtColorRGB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}