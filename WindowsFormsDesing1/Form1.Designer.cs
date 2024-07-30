namespace WindowsFormsDesing1
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
            this.btnsomar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textn1 = new System.Windows.Forms.TextBox();
            this.textn2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsomar
            // 
            this.btnsomar.Location = new System.Drawing.Point(140, 215);
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.Size = new System.Drawing.Size(119, 53);
            this.btnsomar.TabIndex = 0;
            this.btnsomar.Text = "Somar";
            this.btnsomar.UseVisualStyleBackColor = true;
            this.btnsomar.Click += new System.EventHandler(this.btnsomar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(316, 215);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(125, 53);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(487, 215);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(122, 53);
            this.btnfechar.TabIndex = 2;
            this.btnfechar.Text = "fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(115, 345);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(122, 35);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "Resultado:";
            // 
            // textn1
            // 
            this.textn1.Location = new System.Drawing.Point(172, 58);
            this.textn1.Name = "textn1";
            this.textn1.Size = new System.Drawing.Size(437, 20);
            this.textn1.TabIndex = 4;
            // 
            // textn2
            // 
            this.textn2.Location = new System.Drawing.Point(172, 123);
            this.textn2.Name = "textn2";
            this.textn2.Size = new System.Drawing.Size(437, 20);
            this.textn2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "1º Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "2º Número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textn2);
            this.Controls.Add(this.textn1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsomar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textn1;
        private System.Windows.Forms.TextBox textn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

