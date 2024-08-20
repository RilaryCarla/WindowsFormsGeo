namespace WindowsFormsGeo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.btnREstados = new System.Windows.Forms.Button();
            this.lblEstados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNorte = new System.Windows.Forms.ComboBox();
            this.btnRNorte = new System.Windows.Forms.Button();
            this.lblNorte = new System.Windows.Forms.Label();
            this.cboNordeste = new System.Windows.Forms.ComboBox();
            this.btnRNordeste = new System.Windows.Forms.Button();
            this.lblNordeste = new System.Windows.Forms.Label();
            this.cboCo = new System.Windows.Forms.ComboBox();
            this.btnRCo = new System.Windows.Forms.Button();
            this.lblCo = new System.Windows.Forms.Label();
            this.cboSudeste = new System.Windows.Forms.ComboBox();
            this.btnRSudeste = new System.Windows.Forms.Button();
            this.lblSudeste = new System.Windows.Forms.Label();
            this.cboSul = new System.Windows.Forms.ComboBox();
            this.btnRSul = new System.Windows.Forms.Button();
            this.lblSul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os Estados:";
            // 
            // cboEstados
            // 
            this.cboEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(154, 28);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(186, 26);
            this.cboEstados.TabIndex = 1;
            // 
            // btnREstados
            // 
            this.btnREstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREstados.Location = new System.Drawing.Point(366, 28);
            this.btnREstados.Name = "btnREstados";
            this.btnREstados.Size = new System.Drawing.Size(44, 26);
            this.btnREstados.TabIndex = 2;
            this.btnREstados.Text = "_";
            this.btnREstados.UseVisualStyleBackColor = true;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(433, 32);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(16, 18);
            this.lblEstados.TabIndex = 3;
            this.lblEstados.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Região Norte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Região Nordeste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Região Centro-Oeste:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Região Sudeste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Região Sul:";
            // 
            // cboNorte
            // 
            this.cboNorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNorte.FormattingEnabled = true;
            this.cboNorte.Location = new System.Drawing.Point(154, 95);
            this.cboNorte.Name = "cboNorte";
            this.cboNorte.Size = new System.Drawing.Size(186, 26);
            this.cboNorte.TabIndex = 9;
            // 
            // btnRNorte
            // 
            this.btnRNorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRNorte.Location = new System.Drawing.Point(366, 95);
            this.btnRNorte.Name = "btnRNorte";
            this.btnRNorte.Size = new System.Drawing.Size(44, 26);
            this.btnRNorte.TabIndex = 10;
            this.btnRNorte.Text = "_";
            this.btnRNorte.UseVisualStyleBackColor = true;
            // 
            // lblNorte
            // 
            this.lblNorte.AutoSize = true;
            this.lblNorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorte.Location = new System.Drawing.Point(433, 103);
            this.lblNorte.Name = "lblNorte";
            this.lblNorte.Size = new System.Drawing.Size(16, 18);
            this.lblNorte.TabIndex = 11;
            this.lblNorte.Text = "0";
            // 
            // cboNordeste
            // 
            this.cboNordeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNordeste.FormattingEnabled = true;
            this.cboNordeste.Location = new System.Drawing.Point(154, 152);
            this.cboNordeste.Name = "cboNordeste";
            this.cboNordeste.Size = new System.Drawing.Size(186, 26);
            this.cboNordeste.TabIndex = 12;
            // 
            // btnRNordeste
            // 
            this.btnRNordeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRNordeste.Location = new System.Drawing.Point(366, 156);
            this.btnRNordeste.Name = "btnRNordeste";
            this.btnRNordeste.Size = new System.Drawing.Size(44, 26);
            this.btnRNordeste.TabIndex = 13;
            this.btnRNordeste.Text = "_";
            this.btnRNordeste.UseVisualStyleBackColor = true;
            // 
            // lblNordeste
            // 
            this.lblNordeste.AutoSize = true;
            this.lblNordeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNordeste.Location = new System.Drawing.Point(433, 164);
            this.lblNordeste.Name = "lblNordeste";
            this.lblNordeste.Size = new System.Drawing.Size(16, 18);
            this.lblNordeste.TabIndex = 14;
            this.lblNordeste.Text = "0";
            // 
            // cboCo
            // 
            this.cboCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCo.FormattingEnabled = true;
            this.cboCo.Location = new System.Drawing.Point(179, 217);
            this.cboCo.Name = "cboCo";
            this.cboCo.Size = new System.Drawing.Size(161, 26);
            this.cboCo.TabIndex = 15;
            // 
            // btnRCo
            // 
            this.btnRCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRCo.Location = new System.Drawing.Point(366, 217);
            this.btnRCo.Name = "btnRCo";
            this.btnRCo.Size = new System.Drawing.Size(44, 26);
            this.btnRCo.TabIndex = 16;
            this.btnRCo.Text = "_";
            this.btnRCo.UseVisualStyleBackColor = true;
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCo.Location = new System.Drawing.Point(433, 225);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(16, 18);
            this.lblCo.TabIndex = 17;
            this.lblCo.Text = "0";
            // 
            // cboSudeste
            // 
            this.cboSudeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSudeste.FormattingEnabled = true;
            this.cboSudeste.Location = new System.Drawing.Point(154, 278);
            this.cboSudeste.Name = "cboSudeste";
            this.cboSudeste.Size = new System.Drawing.Size(186, 26);
            this.cboSudeste.TabIndex = 18;
            // 
            // btnRSudeste
            // 
            this.btnRSudeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSudeste.Location = new System.Drawing.Point(366, 282);
            this.btnRSudeste.Name = "btnRSudeste";
            this.btnRSudeste.Size = new System.Drawing.Size(44, 26);
            this.btnRSudeste.TabIndex = 19;
            this.btnRSudeste.Text = "_";
            this.btnRSudeste.UseVisualStyleBackColor = true;
            // 
            // lblSudeste
            // 
            this.lblSudeste.AutoSize = true;
            this.lblSudeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSudeste.Location = new System.Drawing.Point(433, 290);
            this.lblSudeste.Name = "lblSudeste";
            this.lblSudeste.Size = new System.Drawing.Size(16, 18);
            this.lblSudeste.TabIndex = 20;
            this.lblSudeste.Text = "0";
            // 
            // cboSul
            // 
            this.cboSul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSul.FormattingEnabled = true;
            this.cboSul.Location = new System.Drawing.Point(154, 337);
            this.cboSul.Name = "cboSul";
            this.cboSul.Size = new System.Drawing.Size(186, 26);
            this.cboSul.TabIndex = 21;
            // 
            // btnRSul
            // 
            this.btnRSul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSul.Location = new System.Drawing.Point(366, 337);
            this.btnRSul.Name = "btnRSul";
            this.btnRSul.Size = new System.Drawing.Size(44, 27);
            this.btnRSul.TabIndex = 22;
            this.btnRSul.Text = "_";
            this.btnRSul.UseVisualStyleBackColor = true;
            // 
            // lblSul
            // 
            this.lblSul.AutoSize = true;
            this.lblSul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSul.Location = new System.Drawing.Point(433, 346);
            this.lblSul.Name = "lblSul";
            this.lblSul.Size = new System.Drawing.Size(16, 18);
            this.lblSul.TabIndex = 23;
            this.lblSul.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 414);
            this.Controls.Add(this.lblSul);
            this.Controls.Add(this.btnRSul);
            this.Controls.Add(this.cboSul);
            this.Controls.Add(this.lblSudeste);
            this.Controls.Add(this.btnRSudeste);
            this.Controls.Add(this.cboSudeste);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.btnRCo);
            this.Controls.Add(this.cboCo);
            this.Controls.Add(this.lblNordeste);
            this.Controls.Add(this.btnRNordeste);
            this.Controls.Add(this.cboNordeste);
            this.Controls.Add(this.lblNorte);
            this.Controls.Add(this.btnRNorte);
            this.Controls.Add(this.cboNorte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.btnREstados);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Button btnREstados;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNorte;
        private System.Windows.Forms.Button btnRNorte;
        private System.Windows.Forms.Label lblNorte;
        private System.Windows.Forms.ComboBox cboNordeste;
        private System.Windows.Forms.Button btnRNordeste;
        private System.Windows.Forms.Label lblNordeste;
        private System.Windows.Forms.ComboBox cboCo;
        private System.Windows.Forms.Button btnRCo;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.ComboBox cboSudeste;
        private System.Windows.Forms.Button btnRSudeste;
        private System.Windows.Forms.Label lblSudeste;
        private System.Windows.Forms.ComboBox cboSul;
        private System.Windows.Forms.Button btnRSul;
        private System.Windows.Forms.Label lblSul;
    }
}

