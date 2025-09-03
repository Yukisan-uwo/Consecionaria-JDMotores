namespace wfConcesionaria_v1
{
    partial class frmCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorreo));
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtConCopia = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtAdjunto = new System.Windows.Forms.TextBox();
            this.lblAdjuntar = new System.Windows.Forms.Label();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.lblCuerpo = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblConcopia = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.ofdRuta = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdjuntar.Location = new System.Drawing.Point(635, 178);
            this.btnAdjuntar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(25, 19);
            this.btnAdjuntar.TabIndex = 42;
            this.btnAdjuntar.Text = "...";
            this.btnAdjuntar.UseVisualStyleBackColor = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(152, 101);
            this.txtPara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(509, 20);
            this.txtPara.TabIndex = 30;
            // 
            // txtConCopia
            // 
            this.txtConCopia.Location = new System.Drawing.Point(152, 127);
            this.txtConCopia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConCopia.Name = "txtConCopia";
            this.txtConCopia.Size = new System.Drawing.Size(509, 20);
            this.txtConCopia.TabIndex = 32;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(152, 150);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(509, 20);
            this.txtAsunto.TabIndex = 33;
            // 
            // txtAdjunto
            // 
            this.txtAdjunto.Location = new System.Drawing.Point(152, 178);
            this.txtAdjunto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdjunto.Name = "txtAdjunto";
            this.txtAdjunto.Size = new System.Drawing.Size(487, 20);
            this.txtAdjunto.TabIndex = 34;
            // 
            // lblAdjuntar
            // 
            this.lblAdjuntar.AutoSize = true;
            this.lblAdjuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjuntar.Location = new System.Drawing.Point(73, 175);
            this.lblAdjuntar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdjuntar.Name = "lblAdjuntar";
            this.lblAdjuntar.Size = new System.Drawing.Size(82, 20);
            this.lblAdjuntar.TabIndex = 41;
            this.lblAdjuntar.Text = "Adjuntar:";
            this.lblAdjuntar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(76, 243);
            this.txtCuerpo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(584, 140);
            this.txtCuerpo.TabIndex = 35;
            // 
            // lblCuerpo
            // 
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuerpo.Location = new System.Drawing.Point(73, 220);
            this.lblCuerpo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(81, 20);
            this.lblCuerpo.TabIndex = 40;
            this.lblCuerpo.Text = "Mensaje:";
            this.lblCuerpo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(73, 150);
            this.lblAsunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(71, 20);
            this.lblAsunto.TabIndex = 39;
            this.lblAsunto.Text = "Asunto:";
            this.lblAsunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConcopia
            // 
            this.lblConcopia.AutoSize = true;
            this.lblConcopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcopia.Location = new System.Drawing.Point(73, 124);
            this.lblConcopia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConcopia.Name = "lblConcopia";
            this.lblConcopia.Size = new System.Drawing.Size(38, 20);
            this.lblConcopia.TabIndex = 38;
            this.lblConcopia.Text = "CC:";
            this.lblConcopia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.Location = new System.Drawing.Point(73, 101);
            this.lblPara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(51, 20);
            this.lblPara.TabIndex = 37;
            this.lblPara.Text = "Para:";
            this.lblPara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(249, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 24);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Enviar Correos Electronicos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(73, 73);
            this.lblDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(37, 20);
            this.lblDe.TabIndex = 31;
            this.lblDe.Text = "De:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(370, 399);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(68, 32);
            this.btnEnviar.TabIndex = 43;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(152, 73);
            this.txtDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDe.Name = "txtDe";
            this.txtDe.ReadOnly = true;
            this.txtDe.Size = new System.Drawing.Size(509, 20);
            this.txtDe.TabIndex = 44;
            // 
            // ofdRuta
            // 
            this.ofdRuta.FileName = "openFileDialog1";
            this.ofdRuta.Multiselect = true;
            // 
            // frmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 441);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.txtConCopia);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtAdjunto);
            this.Controls.Add(this.lblAdjuntar);
            this.Controls.Add(this.txtCuerpo);
            this.Controls.Add(this.lblCuerpo);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.lblConcopia);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCorreo";
            this.Text = "Correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtConCopia;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtAdjunto;
        private System.Windows.Forms.Label lblAdjuntar;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Label lblCuerpo;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblConcopia;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.OpenFileDialog ofdRuta;
    }
}