
namespace Flappy_Bird
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
            this.label1 = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Game_Over = new System.Windows.Forms.PictureBox();
            this.TopPipe1 = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Star = new System.Windows.Forms.PictureBox();
            this.TopPipe = new System.Windows.Forms.PictureBox();
            this.BottomPipe = new System.Windows.Forms.PictureBox();
            this.BottomPipe1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Over)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(263, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score -";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Game_Over
            // 
            this.Game_Over.Image = global::Flappy_Bird.Properties.Resources.Game_over;
            this.Game_Over.Location = new System.Drawing.Point(164, 197);
            this.Game_Over.Name = "Game_Over";
            this.Game_Over.Size = new System.Drawing.Size(309, 254);
            this.Game_Over.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Game_Over.TabIndex = 8;
            this.Game_Over.TabStop = false;
            this.Game_Over.Visible = false;
            // 
            // TopPipe1
            // 
            this.TopPipe1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TopPipe1.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.TopPipe1.Location = new System.Drawing.Point(360, -5);
            this.TopPipe1.Name = "TopPipe1";
            this.TopPipe1.Size = new System.Drawing.Size(100, 236);
            this.TopPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopPipe1.TabIndex = 7;
            this.TopPipe1.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(62, 178);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(64, 53);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 0;
            this.Bird.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(0, 613);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(653, 83);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // Star
            // 
            this.Star.Image = global::Flappy_Bird.Properties.Resources.star;
            this.Star.Location = new System.Drawing.Point(415, 292);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(45, 44);
            this.Star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Star.TabIndex = 5;
            this.Star.TabStop = false;
            // 
            // TopPipe
            // 
            this.TopPipe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TopPipe.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.TopPipe.Location = new System.Drawing.Point(62, -5);
            this.TopPipe.Name = "TopPipe";
            this.TopPipe.Size = new System.Drawing.Size(100, 123);
            this.TopPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopPipe.TabIndex = 1;
            this.TopPipe.TabStop = false;
            // 
            // BottomPipe
            // 
            this.BottomPipe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BottomPipe.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.BottomPipe.Location = new System.Drawing.Point(62, 406);
            this.BottomPipe.Name = "BottomPipe";
            this.BottomPipe.Size = new System.Drawing.Size(96, 212);
            this.BottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomPipe.TabIndex = 2;
            this.BottomPipe.TabStop = false;
            // 
            // BottomPipe1
            // 
            this.BottomPipe1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BottomPipe1.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.BottomPipe1.Location = new System.Drawing.Point(405, 416);
            this.BottomPipe1.Name = "BottomPipe1";
            this.BottomPipe1.Size = new System.Drawing.Size(96, 212);
            this.BottomPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomPipe1.TabIndex = 6;
            this.BottomPipe1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 694);
            this.Controls.Add(this.TopPipe1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.TopPipe);
            this.Controls.Add(this.BottomPipe);
            this.Controls.Add(this.BottomPipe1);
            this.Controls.Add(this.Game_Over);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Game_Over)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox TopPipe;
        private System.Windows.Forms.PictureBox BottomPipe;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Star;
        private System.Windows.Forms.PictureBox BottomPipe1;
        private System.Windows.Forms.PictureBox TopPipe1;
        private System.Windows.Forms.PictureBox Game_Over;
    }
}

