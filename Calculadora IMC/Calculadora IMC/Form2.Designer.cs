﻿
namespace Calculadora_IMC
{
    partial class Form2
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
            this.rb_Mulher = new System.Windows.Forms.RadioButton();
            this.rb_Homem = new System.Windows.Forms.RadioButton();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Título = new System.Windows.Forms.Label();
            this.lbl_Instrução = new System.Windows.Forms.Label();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.txt_IMC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rb_Mulher
            // 
            this.rb_Mulher.AutoSize = true;
            this.rb_Mulher.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Mulher.ForeColor = System.Drawing.Color.Purple;
            this.rb_Mulher.Location = new System.Drawing.Point(416, 159);
            this.rb_Mulher.Name = "rb_Mulher";
            this.rb_Mulher.Size = new System.Drawing.Size(97, 32);
            this.rb_Mulher.TabIndex = 43;
            this.rb_Mulher.TabStop = true;
            this.rb_Mulher.Text = "Mulher";
            this.rb_Mulher.UseVisualStyleBackColor = true;
            // 
            // rb_Homem
            // 
            this.rb_Homem.AutoSize = true;
            this.rb_Homem.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Homem.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_Homem.Location = new System.Drawing.Point(298, 159);
            this.rb_Homem.Name = "rb_Homem";
            this.rb_Homem.Size = new System.Drawing.Size(102, 32);
            this.rb_Homem.TabIndex = 42;
            this.rb_Homem.TabStop = true;
            this.rb_Homem.Text = "Homem";
            this.rb_Homem.UseVisualStyleBackColor = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Calcular.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Calcular.Location = new System.Drawing.Point(352, 347);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(95, 48);
            this.btn_Calcular.TabIndex = 50;
            this.btn_Calcular.Text = "Calcular ";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Título.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Título.Location = new System.Drawing.Point(253, 51);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(311, 33);
            this.lbl_Título.TabIndex = 55;
            this.lbl_Título.Text = "Sistema de Cálculo de IMC";
            // 
            // lbl_Instrução
            // 
            this.lbl_Instrução.AutoSize = true;
            this.lbl_Instrução.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instrução.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Instrução.Location = new System.Drawing.Point(325, 118);
            this.lbl_Instrução.Name = "lbl_Instrução";
            this.lbl_Instrução.Size = new System.Drawing.Size(161, 26);
            this.lbl_Instrução.TabIndex = 56;
            this.lbl_Instrução.Text = "Selecione o sexo!";
            // 
            // txt_Altura
            // 
            this.txt_Altura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Altura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Altura.Location = new System.Drawing.Point(330, 237);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(138, 31);
            this.txt_Altura.TabIndex = 60;
            this.txt_Altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Peso
            // 
            this.txt_Peso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Peso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Peso.Location = new System.Drawing.Point(330, 298);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(138, 31);
            this.txt_Peso.TabIndex = 62;
            this.txt_Peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Peso.Location = new System.Drawing.Point(374, 269);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(51, 26);
            this.lbl_Peso.TabIndex = 61;
            this.lbl_Peso.Text = "Peso";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_4.Location = new System.Drawing.Point(470, 304);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(28, 20);
            this.lbl_4.TabIndex = 65;
            this.lbl_4.Text = "KG";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_3.Location = new System.Drawing.Point(470, 243);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(22, 20);
            this.lbl_3.TabIndex = 66;
            this.lbl_3.Text = "M";
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Altura.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Altura.Location = new System.Drawing.Point(366, 208);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(67, 26);
            this.lbl_Altura.TabIndex = 59;
            this.lbl_Altura.Text = "Altura";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Resultado.Location = new System.Drawing.Point(212, 442);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(389, 35);
            this.txt_Resultado.TabIndex = 67;
            this.txt_Resultado.Text = "Mensagem";
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IMC
            // 
            this.txt_IMC.BackColor = System.Drawing.SystemColors.Window;
            this.txt_IMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IMC.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_IMC.Location = new System.Drawing.Point(321, 406);
            this.txt_IMC.Name = "txt_IMC";
            this.txt_IMC.Size = new System.Drawing.Size(165, 35);
            this.txt_IMC.TabIndex = 69;
            this.txt_IMC.Text = "IMC";
            this.txt_IMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.txt_IMC);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.txt_Altura);
            this.Controls.Add(this.lbl_Altura);
            this.Controls.Add(this.lbl_Instrução);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rb_Mulher);
            this.Controls.Add(this.rb_Homem);
            this.Name = "Form2";
            this.Text = "Calculadora IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Mulher;
        private System.Windows.Forms.RadioButton rb_Homem;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.Label lbl_Instrução;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.TextBox txt_IMC;
    }
}