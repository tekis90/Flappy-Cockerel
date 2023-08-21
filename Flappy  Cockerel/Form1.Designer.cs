
namespace Flappy__Cockerel
{
    partial class FlappyBird
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skor_label1 = new System.Windows.Forms.Label();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.gameOverpictureBox = new System.Windows.Forms.PictureBox();
            this.zemin_pictureBox = new System.Windows.Forms.PictureBox();
            this.flappyBirdpictureBox = new System.Windows.Forms.PictureBox();
            this.boru_alt__pictureBox = new System.Windows.Forms.PictureBox();
            this.boru_ust_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBirdpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru_alt__pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru_ust_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // skor_label1
            // 
            this.skor_label1.AutoSize = true;
            this.skor_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor_label1.Location = new System.Drawing.Point(12, 9);
            this.skor_label1.Name = "skor_label1";
            this.skor_label1.Size = new System.Drawing.Size(92, 25);
            this.skor_label1.TabIndex = 4;
            this.skor_label1.Text = "SKOR:0";
            // 
            // game_timer
            // 
            this.game_timer.Interval = 20;
            this.game_timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startButton.Location = new System.Drawing.Point(301, 230);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(117, 46);
            this.startButton.TabIndex = 5;
            this.startButton.TabStop = false;
            this.startButton.Text = "Başlat";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameOverpictureBox
            // 
            this.gameOverpictureBox.Image = global::Flappy__Cockerel.Properties.Resources.game_over;
            this.gameOverpictureBox.Location = new System.Drawing.Point(282, 282);
            this.gameOverpictureBox.Name = "gameOverpictureBox";
            this.gameOverpictureBox.Size = new System.Drawing.Size(179, 139);
            this.gameOverpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameOverpictureBox.TabIndex = 6;
            this.gameOverpictureBox.TabStop = false;
            this.gameOverpictureBox.Visible = false;
            // 
            // zemin_pictureBox
            // 
            this.zemin_pictureBox.Image = global::Flappy__Cockerel.Properties.Resources.ground;
            this.zemin_pictureBox.Location = new System.Drawing.Point(1, 655);
            this.zemin_pictureBox.Name = "zemin_pictureBox";
            this.zemin_pictureBox.Size = new System.Drawing.Size(603, 80);
            this.zemin_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin_pictureBox.TabIndex = 3;
            this.zemin_pictureBox.TabStop = false;
            // 
            // flappyBirdpictureBox
            // 
            this.flappyBirdpictureBox.Image = global::Flappy__Cockerel.Properties.Resources.rooster1;
            this.flappyBirdpictureBox.Location = new System.Drawing.Point(3, 190);
            this.flappyBirdpictureBox.Name = "flappyBirdpictureBox";
            this.flappyBirdpictureBox.Size = new System.Drawing.Size(132, 115);
            this.flappyBirdpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBirdpictureBox.TabIndex = 2;
            this.flappyBirdpictureBox.TabStop = false;
            // 
            // boru_alt__pictureBox
            // 
            this.boru_alt__pictureBox.Image = global::Flappy__Cockerel.Properties.Resources.pipe;
            this.boru_alt__pictureBox.Location = new System.Drawing.Point(476, 466);
            this.boru_alt__pictureBox.Name = "boru_alt__pictureBox";
            this.boru_alt__pictureBox.Size = new System.Drawing.Size(100, 183);
            this.boru_alt__pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru_alt__pictureBox.TabIndex = 1;
            this.boru_alt__pictureBox.TabStop = false;
            // 
            // boru_ust_pictureBox
            // 
            this.boru_ust_pictureBox.Image = global::Flappy__Cockerel.Properties.Resources.pipedown;
            this.boru_ust_pictureBox.Location = new System.Drawing.Point(480, 9);
            this.boru_ust_pictureBox.Name = "boru_ust_pictureBox";
            this.boru_ust_pictureBox.Size = new System.Drawing.Size(96, 216);
            this.boru_ust_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru_ust_pictureBox.TabIndex = 0;
            this.boru_ust_pictureBox.TabStop = false;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(603, 730);
            this.Controls.Add(this.gameOverpictureBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.skor_label1);
            this.Controls.Add(this.zemin_pictureBox);
            this.Controls.Add(this.flappyBirdpictureBox);
            this.Controls.Add(this.boru_alt__pictureBox);
            this.Controls.Add(this.boru_ust_pictureBox);
            this.Name = "FlappyBird";
            this.Text = "FlappyCockerelGame";
            this.Load += new System.EventHandler(this.FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameOverpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBirdpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru_alt__pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru_ust_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boru_ust_pictureBox;
        private System.Windows.Forms.PictureBox boru_alt__pictureBox;
        private System.Windows.Forms.PictureBox flappyBirdpictureBox;
        private System.Windows.Forms.PictureBox zemin_pictureBox;
        private System.Windows.Forms.Label skor_label1;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox gameOverpictureBox;
    }
}

