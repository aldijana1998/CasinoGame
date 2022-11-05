namespace CasinoGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl_casiino = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.lbl_loss = new System.Windows.Forms.Label();
            this.lbl_bidAmount = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_bid = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_casiino
            // 
            this.lbl_casiino.AutoSize = true;
            this.lbl_casiino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casiino.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_casiino.Location = new System.Drawing.Point(0, 9);
            this.lbl_casiino.Name = "lbl_casiino";
            this.lbl_casiino.Size = new System.Drawing.Size(67, 20);
            this.lbl_casiino.TabIndex = 3;
            this.lbl_casiino.Text = "Casino";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.ForeColor = System.Drawing.Color.Silver;
            this.lbl_balance.Location = new System.Drawing.Point(0, 38);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(99, 20);
            this.lbl_balance.TabIndex = 4;
            this.lbl_balance.Text = "Balance :$";
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_win.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbl_win.Location = new System.Drawing.Point(11, 192);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(79, 20);
            this.lbl_win.TabIndex = 5;
            this.lbl_win.Text = "Wins : 0";
            // 
            // lbl_loss
            // 
            this.lbl_loss.AutoSize = true;
            this.lbl_loss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loss.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_loss.Location = new System.Drawing.Point(11, 226);
            this.lbl_loss.Name = "lbl_loss";
            this.lbl_loss.Size = new System.Drawing.Size(78, 20);
            this.lbl_loss.TabIndex = 6;
            this.lbl_loss.Text = "Loss : 0";
            // 
            // lbl_bidAmount
            // 
            this.lbl_bidAmount.AutoSize = true;
            this.lbl_bidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bidAmount.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_bidAmount.Location = new System.Drawing.Point(118, 192);
            this.lbl_bidAmount.Name = "lbl_bidAmount";
            this.lbl_bidAmount.Size = new System.Drawing.Size(107, 20);
            this.lbl_bidAmount.TabIndex = 7;
            this.lbl_bidAmount.Text = "Bid-Amount";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CasinoGame.Properties.Resources.dollar1;
            this.pictureBox3.Location = new System.Drawing.Point(180, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CasinoGame.Properties.Resources.dollar1;
            this.pictureBox2.Location = new System.Drawing.Point(104, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CasinoGame.Properties.Resources.dollar1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 36);
            this.textBox1.TabIndex = 8;
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.White;
            this.btn_play.Location = new System.Drawing.Point(15, 270);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(125, 50);
            this.btn_play.TabIndex = 9;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_bid
            // 
            this.btn_bid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bid.ForeColor = System.Drawing.Color.White;
            this.btn_bid.Location = new System.Drawing.Point(146, 270);
            this.btn_bid.Name = "btn_bid";
            this.btn_bid.Size = new System.Drawing.Size(125, 50);
            this.btn_bid.TabIndex = 10;
            this.btn_bid.Text = "New Bid";
            this.btn_bid.UseVisualStyleBackColor = true;
            this.btn_bid.Click += new System.EventHandler(this.btn_bid_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(282, 323);
            this.Controls.Add(this.btn_bid);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_bidAmount);
            this.Controls.Add(this.lbl_loss);
            this.Controls.Add(this.lbl_win);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_casiino);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casino Game in C#";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_casiino;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Label lbl_loss;
        private System.Windows.Forms.Label lbl_bidAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_bid;
        private System.Windows.Forms.Timer timer1;
    }
}

