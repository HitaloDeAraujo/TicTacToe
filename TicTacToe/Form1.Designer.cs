namespace TicTacToe
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJogador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb00 = new System.Windows.Forms.PictureBox();
            this.pb22 = new System.Windows.Forms.PictureBox();
            this.pb21 = new System.Windows.Forms.PictureBox();
            this.pb20 = new System.Windows.Forms.PictureBox();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb02 = new System.Windows.Forms.PictureBox();
            this.pb01 = new System.Windows.Forms.PictureBox();
            this.botaoNovoJogo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblJogador);
            this.panel1.Location = new System.Drawing.Point(438, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 89);
            this.panel1.TabIndex = 9;
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(26, 29);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(126, 31);
            this.lblJogador.TabIndex = 0;
            this.lblJogador.Text = "jogador 1";
            this.lblJogador.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.pb00);
            this.panel2.Controls.Add(this.pb22);
            this.panel2.Controls.Add(this.pb21);
            this.panel2.Controls.Add(this.pb20);
            this.panel2.Controls.Add(this.pb12);
            this.panel2.Controls.Add(this.pb11);
            this.panel2.Controls.Add(this.pb10);
            this.panel2.Controls.Add(this.pb02);
            this.panel2.Controls.Add(this.pb01);
            this.panel2.Location = new System.Drawing.Point(41, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 380);
            this.panel2.TabIndex = 11;
            // 
            // pb00
            // 
            this.pb00.BackColor = System.Drawing.SystemColors.Control;
            this.pb00.Location = new System.Drawing.Point(14, 9);
            this.pb00.Name = "pb00";
            this.pb00.Size = new System.Drawing.Size(114, 114);
            this.pb00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb00.TabIndex = 24;
            this.pb00.TabStop = false;
            // 
            // pb22
            // 
            this.pb22.BackColor = System.Drawing.SystemColors.Control;
            this.pb22.Location = new System.Drawing.Point(254, 249);
            this.pb22.Name = "pb22";
            this.pb22.Size = new System.Drawing.Size(114, 114);
            this.pb22.TabIndex = 23;
            this.pb22.TabStop = false;
            // 
            // pb21
            // 
            this.pb21.BackColor = System.Drawing.SystemColors.Control;
            this.pb21.Location = new System.Drawing.Point(134, 249);
            this.pb21.Name = "pb21";
            this.pb21.Size = new System.Drawing.Size(114, 114);
            this.pb21.TabIndex = 22;
            this.pb21.TabStop = false;
            // 
            // pb20
            // 
            this.pb20.BackColor = System.Drawing.SystemColors.Control;
            this.pb20.Location = new System.Drawing.Point(14, 249);
            this.pb20.Name = "pb20";
            this.pb20.Size = new System.Drawing.Size(114, 114);
            this.pb20.TabIndex = 21;
            this.pb20.TabStop = false;
            // 
            // pb12
            // 
            this.pb12.BackColor = System.Drawing.SystemColors.Control;
            this.pb12.Location = new System.Drawing.Point(254, 129);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(114, 114);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb12.TabIndex = 20;
            this.pb12.TabStop = false;
            // 
            // pb11
            // 
            this.pb11.BackColor = System.Drawing.SystemColors.Control;
            this.pb11.Location = new System.Drawing.Point(134, 129);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(114, 114);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb11.TabIndex = 19;
            this.pb11.TabStop = false;
            // 
            // pb10
            // 
            this.pb10.BackColor = System.Drawing.SystemColors.Control;
            this.pb10.Location = new System.Drawing.Point(14, 129);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(114, 114);
            this.pb10.TabIndex = 18;
            this.pb10.TabStop = false;
            // 
            // pb02
            // 
            this.pb02.BackColor = System.Drawing.SystemColors.Control;
            this.pb02.Location = new System.Drawing.Point(254, 9);
            this.pb02.Name = "pb02";
            this.pb02.Size = new System.Drawing.Size(114, 114);
            this.pb02.TabIndex = 17;
            this.pb02.TabStop = false;
            // 
            // pb01
            // 
            this.pb01.BackColor = System.Drawing.SystemColors.Control;
            this.pb01.Location = new System.Drawing.Point(134, 9);
            this.pb01.Name = "pb01";
            this.pb01.Size = new System.Drawing.Size(114, 114);
            this.pb01.TabIndex = 16;
            this.pb01.TabStop = false;
            // 
            // botaoNovoJogo
            // 
            this.botaoNovoJogo.Location = new System.Drawing.Point(438, 117);
            this.botaoNovoJogo.Name = "botaoNovoJogo";
            this.botaoNovoJogo.Size = new System.Drawing.Size(173, 23);
            this.botaoNovoJogo.TabIndex = 14;
            this.botaoNovoJogo.Text = "Novo Jogo";
            this.botaoNovoJogo.UseVisualStyleBackColor = true;
            this.botaoNovoJogo.Click += new System.EventHandler(this.botaoNovoJogo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 173);
            this.button1.TabIndex = 15;
            this.button1.Text = "Novo Jogo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.botaoNovoJogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botaoNovoJogo;
        private System.Windows.Forms.PictureBox pb00;
        private System.Windows.Forms.PictureBox pb22;
        private System.Windows.Forms.PictureBox pb21;
        private System.Windows.Forms.PictureBox pb20;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb02;
        private System.Windows.Forms.PictureBox pb01;
        private System.Windows.Forms.Button button1;
    }
}

