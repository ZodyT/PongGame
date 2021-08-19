
namespace Pong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.MediumBlue;
            this.player.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player.ImageLocation = "";
            this.player.Location = new System.Drawing.Point(12, 199);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 127);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Red;
            this.cpu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cpu.Location = new System.Drawing.Point(889, 199);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(27, 127);
            this.cpu.TabIndex = 1;
            this.cpu.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ball.Location = new System.Drawing.Point(444, 262);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 26);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerScore.ForeColor = System.Drawing.Color.MediumBlue;
            this.playerScore.Location = new System.Drawing.Point(175, 9);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(46, 31);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "00";
            this.playerScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpuLabel.ForeColor = System.Drawing.Color.Red;
            this.cpuLabel.Location = new System.Drawing.Point(705, 9);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(46, 31);
            this.cpuLabel.TabIndex = 4;
            this.cpuLabel.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.player);
            this.Location = new System.Drawing.Point(505, 9);
            this.Name = "Form1";
            this.Text = "Zody\'s Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuLabel;
    }
}

