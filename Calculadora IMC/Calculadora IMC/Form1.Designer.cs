
namespace Calculadora_IMC
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
            this.btnAbrir_CalculadoraIMC = new System.Windows.Forms.Button();
            this.btnAbrir_FormaGeométrica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrir_CalculadoraIMC
            // 
            this.btnAbrir_CalculadoraIMC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAbrir_CalculadoraIMC.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir_CalculadoraIMC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAbrir_CalculadoraIMC.Location = new System.Drawing.Point(113, 171);
            this.btnAbrir_CalculadoraIMC.Name = "btnAbrir_CalculadoraIMC";
            this.btnAbrir_CalculadoraIMC.Size = new System.Drawing.Size(196, 87);
            this.btnAbrir_CalculadoraIMC.TabIndex = 6;
            this.btnAbrir_CalculadoraIMC.Text = " Calculadora IMC";
            this.btnAbrir_CalculadoraIMC.UseVisualStyleBackColor = false;
            this.btnAbrir_CalculadoraIMC.Click += new System.EventHandler(this.btnAbrir_CalculadoraIMC_Click);
            // 
            // btnAbrir_FormaGeométrica
            // 
            this.btnAbrir_FormaGeométrica.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAbrir_FormaGeométrica.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir_FormaGeométrica.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAbrir_FormaGeométrica.Location = new System.Drawing.Point(486, 171);
            this.btnAbrir_FormaGeométrica.Name = "btnAbrir_FormaGeométrica";
            this.btnAbrir_FormaGeométrica.Size = new System.Drawing.Size(196, 87);
            this.btnAbrir_FormaGeométrica.TabIndex = 7;
            this.btnAbrir_FormaGeométrica.Text = "Forma Geométrica";
            this.btnAbrir_FormaGeométrica.UseVisualStyleBackColor = false;
            this.btnAbrir_FormaGeométrica.Click += new System.EventHandler(this.btnAbrir_FormaGeométrica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrir_FormaGeométrica);
            this.Controls.Add(this.btnAbrir_CalculadoraIMC);
            this.Name = "Form1";
            this.Text = "Tela Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir_CalculadoraIMC;
        private System.Windows.Forms.Button btnAbrir_FormaGeométrica;
    }
}

