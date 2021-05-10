
namespace BlackJack
{
    partial class form_apresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_apresentacao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btnRegra = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.Capturar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Iniciar.Location = new System.Drawing.Point(8, 409);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(151, 29);
            this.btn_Iniciar.TabIndex = 2;
            this.btn_Iniciar.Text = "JOGAR!";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btnRegra
            // 
            this.btnRegra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegra.Location = new System.Drawing.Point(167, 409);
            this.btnRegra.Name = "btnRegra";
            this.btnRegra.Size = new System.Drawing.Size(80, 29);
            this.btnRegra.TabIndex = 3;
            this.btnRegra.Text = "REGRAS";
            this.btnRegra.UseVisualStyleBackColor = false;
            this.btnRegra.Click += new System.EventHandler(this.btnRegra_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSobre.Location = new System.Drawing.Point(254, 409);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(82, 29);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "SOBRE";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // form_apresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnRegra);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_apresentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack (Leonardo e Thalyson)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btnRegra;
        private System.Windows.Forms.Button btnSobre;
    }
}