
namespace BlackJack
{
    partial class FormRegra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegra));
            this.btnRegrasVoltar = new System.Windows.Forms.Button();
            this.lblRegrasTitulo = new System.Windows.Forms.Label();
            this.lblRegrasExplicacao = new System.Windows.Forms.Label();
            this.lblRegrasSubtitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegrasVoltar
            // 
            this.btnRegrasVoltar.Location = new System.Drawing.Point(528, 438);
            this.btnRegrasVoltar.Name = "btnRegrasVoltar";
            this.btnRegrasVoltar.Size = new System.Drawing.Size(115, 36);
            this.btnRegrasVoltar.TabIndex = 0;
            this.btnRegrasVoltar.Text = "< Voltar";
            this.btnRegrasVoltar.UseVisualStyleBackColor = true;
            this.btnRegrasVoltar.Click += new System.EventHandler(this.btnRegrasVoltar_Click);
            // 
            // lblRegrasTitulo
            // 
            this.lblRegrasTitulo.AutoSize = true;
            this.lblRegrasTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegrasTitulo.ForeColor = System.Drawing.Color.Yellow;
            this.lblRegrasTitulo.Image = global::BlackJack.Properties.Resources.fundoLabel3;
            this.lblRegrasTitulo.Location = new System.Drawing.Point(244, 49);
            this.lblRegrasTitulo.Name = "lblRegrasTitulo";
            this.lblRegrasTitulo.Size = new System.Drawing.Size(276, 30);
            this.lblRegrasTitulo.TabIndex = 1;
            this.lblRegrasTitulo.Text = "Regras do Blackjack ou 21!";
            // 
            // lblRegrasExplicacao
            // 
            this.lblRegrasExplicacao.AutoSize = true;
            this.lblRegrasExplicacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegrasExplicacao.ForeColor = System.Drawing.Color.Yellow;
            this.lblRegrasExplicacao.Image = global::BlackJack.Properties.Resources.fundoLabel4;
            this.lblRegrasExplicacao.Location = new System.Drawing.Point(18, 162);
            this.lblRegrasExplicacao.Name = "lblRegrasExplicacao";
            this.lblRegrasExplicacao.Size = new System.Drawing.Size(620, 315);
            this.lblRegrasExplicacao.TabIndex = 2;
            this.lblRegrasExplicacao.Text = resources.GetString("lblRegrasExplicacao.Text");
            // 
            // lblRegrasSubtitulo
            // 
            this.lblRegrasSubtitulo.AutoSize = true;
            this.lblRegrasSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegrasSubtitulo.ForeColor = System.Drawing.Color.Yellow;
            this.lblRegrasSubtitulo.Image = global::BlackJack.Properties.Resources.fundoLabel4;
            this.lblRegrasSubtitulo.Location = new System.Drawing.Point(213, 108);
            this.lblRegrasSubtitulo.Name = "lblRegrasSubtitulo";
            this.lblRegrasSubtitulo.Size = new System.Drawing.Size(389, 42);
            this.lblRegrasSubtitulo.TabIndex = 3;
            this.lblRegrasSubtitulo.Text = "O BlackJack é o jogo de cartas mais famoso do mundo,\r\ne muito fácil de se jogar.\r" +
    "\n";
            // 
            // FormRegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.Capturar3;
            this.ClientSize = new System.Drawing.Size(655, 486);
            this.Controls.Add(this.lblRegrasSubtitulo);
            this.Controls.Add(this.btnRegrasVoltar);
            this.Controls.Add(this.lblRegrasExplicacao);
            this.Controls.Add(this.lblRegrasTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack (Leonardo e Thalyson) > Regras";
            this.Load += new System.EventHandler(this.FormRegra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegrasVoltar;
        private System.Windows.Forms.Label lblRegrasTitulo;
        private System.Windows.Forms.Label lblRegrasExplicacao;
        private System.Windows.Forms.Label lblRegrasSubtitulo;
    }
}