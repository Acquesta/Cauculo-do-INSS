
namespace CauculoINSS
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncaucular = new System.Windows.Forms.Button();
            this.btnresetar = new System.Windows.Forms.Button();
            this.lblINSScobrado = new System.Windows.Forms.Label();
            this.lblporcentagem = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cauculo do INSS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seu Salário:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(142, 96);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(118, 20);
            this.txtsalario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "INSS Cobrado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salário Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Porcentagem:";
            // 
            // btncaucular
            // 
            this.btncaucular.Location = new System.Drawing.Point(300, 350);
            this.btncaucular.Name = "btncaucular";
            this.btncaucular.Size = new System.Drawing.Size(111, 23);
            this.btncaucular.TabIndex = 6;
            this.btncaucular.Text = "Calcular";
            this.btncaucular.UseVisualStyleBackColor = true;
            this.btncaucular.Click += new System.EventHandler(this.btncaucular_Click);
            // 
            // btnresetar
            // 
            this.btnresetar.Location = new System.Drawing.Point(12, 350);
            this.btnresetar.Name = "btnresetar";
            this.btnresetar.Size = new System.Drawing.Size(111, 23);
            this.btnresetar.TabIndex = 7;
            this.btnresetar.Text = "Resetar";
            this.btnresetar.UseVisualStyleBackColor = true;
            // 
            // lblINSScobrado
            // 
            this.lblINSScobrado.AutoSize = true;
            this.lblINSScobrado.Location = new System.Drawing.Point(34, 201);
            this.lblINSScobrado.Name = "lblINSScobrado";
            this.lblINSScobrado.Size = new System.Drawing.Size(0, 13);
            this.lblINSScobrado.TabIndex = 8;
            // 
            // lblporcentagem
            // 
            this.lblporcentagem.AutoSize = true;
            this.lblporcentagem.Location = new System.Drawing.Point(167, 201);
            this.lblporcentagem.Name = "lblporcentagem";
            this.lblporcentagem.Size = new System.Drawing.Size(0, 13);
            this.lblporcentagem.TabIndex = 9;
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(314, 201);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(0, 13);
            this.lblfinal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 396);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lblporcentagem);
            this.Controls.Add(this.lblINSScobrado);
            this.Controls.Add(this.btnresetar);
            this.Controls.Add(this.btncaucular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncaucular;
        private System.Windows.Forms.Button btnresetar;
        private System.Windows.Forms.Label lblINSScobrado;
        private System.Windows.Forms.Label lblporcentagem;
        private System.Windows.Forms.Label lblfinal;
    }
}

