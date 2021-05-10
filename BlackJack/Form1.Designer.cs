
namespace BlackJack
{
    partial class Form_jogo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_jogo));
            this.btn_jogar_1 = new System.Windows.Forms.Button();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Pontos_A = new System.Windows.Forms.Label();
            this.btn_parar_1 = new System.Windows.Forms.Button();
            this.btn_parar_2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_jogar_2 = new System.Windows.Forms.Button();
            this.lbl_Pontos_B = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_legenda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_jogar_1
            // 
            this.btn_jogar_1.Location = new System.Drawing.Point(244, 372);
            this.btn_jogar_1.Name = "btn_jogar_1";
            this.btn_jogar_1.Size = new System.Drawing.Size(110, 29);
            this.btn_jogar_1.TabIndex = 0;
            this.btn_jogar_1.Text = "Hit";
            this.btn_jogar_1.UseVisualStyleBackColor = true;
            this.btn_jogar_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(524, 407);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(120, 28);
            this.btn_reiniciar.TabIndex = 1;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.fundoCarta;
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Pontos_A
            // 
            this.lbl_Pontos_A.AutoSize = true;
            this.lbl_Pontos_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pontos_A.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Pontos_A.Image = global::BlackJack.Properties.Resources.fundoLabel2;
            this.lbl_Pontos_A.Location = new System.Drawing.Point(291, 226);
            this.lbl_Pontos_A.Name = "lbl_Pontos_A";
            this.lbl_Pontos_A.Size = new System.Drawing.Size(52, 55);
            this.lbl_Pontos_A.TabIndex = 3;
            this.lbl_Pontos_A.Text = "0";
            this.lbl_Pontos_A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Pontos_A.Click += new System.EventHandler(this.lbl_Pontos_A_Click);
            // 
            // btn_parar_1
            // 
            this.btn_parar_1.Enabled = false;
            this.btn_parar_1.Location = new System.Drawing.Point(244, 408);
            this.btn_parar_1.Name = "btn_parar_1";
            this.btn_parar_1.Size = new System.Drawing.Size(110, 29);
            this.btn_parar_1.TabIndex = 5;
            this.btn_parar_1.Text = "Stand";
            this.btn_parar_1.UseVisualStyleBackColor = true;
            this.btn_parar_1.Click += new System.EventHandler(this.btn_parar_1_Click);
            // 
            // btn_parar_2
            // 
            this.btn_parar_2.Location = new System.Drawing.Point(535, 203);
            this.btn_parar_2.Name = "btn_parar_2";
            this.btn_parar_2.Size = new System.Drawing.Size(110, 29);
            this.btn_parar_2.TabIndex = 8;
            this.btn_parar_2.Text = "Parar";
            this.btn_parar_2.UseVisualStyleBackColor = true;
            this.btn_parar_2.Click += new System.EventHandler(this.btn_parar_2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack.Properties.Resources.dealer;
            this.pictureBox2.Location = new System.Drawing.Point(528, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btn_jogar_2
            // 
            this.btn_jogar_2.Location = new System.Drawing.Point(535, 168);
            this.btn_jogar_2.Name = "btn_jogar_2";
            this.btn_jogar_2.Size = new System.Drawing.Size(110, 29);
            this.btn_jogar_2.TabIndex = 6;
            this.btn_jogar_2.Text = "Virar";
            this.btn_jogar_2.UseVisualStyleBackColor = true;
            this.btn_jogar_2.Click += new System.EventHandler(this.btn_jogar_2_Click);
            // 
            // lbl_Pontos_B
            // 
            this.lbl_Pontos_B.AutoSize = true;
            this.lbl_Pontos_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pontos_B.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Pontos_B.Image = global::BlackJack.Properties.Resources.fundoLabel2;
            this.lbl_Pontos_B.Location = new System.Drawing.Point(431, 226);
            this.lbl_Pontos_B.Name = "lbl_Pontos_B";
            this.lbl_Pontos_B.Size = new System.Drawing.Size(52, 55);
            this.lbl_Pontos_B.TabIndex = 9;
            this.lbl_Pontos_B.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = global::BlackJack.Properties.Resources.fundoLabel2;
            this.label1.Location = new System.Drawing.Point(373, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resultado.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Resultado.Image = global::BlackJack.Properties.Resources.fundoLabel3;
            this.lbl_Resultado.Location = new System.Drawing.Point(222, 43);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 25);
            this.lbl_Resultado.TabIndex = 11;
            this.lbl_Resultado.Click += new System.EventHandler(this.lbl_Resultado_Click);
            // 
            // lbl_legenda
            // 
            this.lbl_legenda.AutoSize = true;
            this.lbl_legenda.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_legenda.Image = global::BlackJack.Properties.Resources.fundoLabel2;
            this.lbl_legenda.Location = new System.Drawing.Point(291, 148);
            this.lbl_legenda.Name = "lbl_legenda";
            this.lbl_legenda.Size = new System.Drawing.Size(103, 37);
            this.lbl_legenda.TabIndex = 4;
            this.lbl_legenda.Text = "Você  x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = global::BlackJack.Properties.Resources.fundoLabel2;
            this.label2.Location = new System.Drawing.Point(388, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dealer";
            // 
            // Form_jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.Capturar3;
            this.ClientSize = new System.Drawing.Size(656, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Pontos_B);
            this.Controls.Add(this.btn_parar_2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_jogar_2);
            this.Controls.Add(this.btn_parar_1);
            this.Controls.Add(this.lbl_legenda);
            this.Controls.Add(this.lbl_Pontos_A);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.btn_jogar_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_jogo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Blackjack (Leonardo e Thalyson)";
            this.Load += new System.EventHandler(this.Form_jogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_jogar_1;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Pontos_A;
        private System.Windows.Forms.Button btn_parar_1;
        private System.Windows.Forms.Button btn_parar_2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_jogar_2;
        private System.Windows.Forms.Label lbl_Pontos_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_legenda;
        private System.Windows.Forms.Label label2;
    }
}

