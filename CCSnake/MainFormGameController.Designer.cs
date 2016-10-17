namespace CCSnake
{
    partial class MainFormGameController
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormGameController));
            this.pictureBox2_new_GAME = new System.Windows.Forms.PictureBox();
            this.pictureBox1_KEYS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_new_GAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_KEYS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2_new_GAME
            // 
            this.pictureBox2_new_GAME.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2_new_GAME.Image")));
            this.pictureBox2_new_GAME.Location = new System.Drawing.Point(542, 314);
            this.pictureBox2_new_GAME.Name = "pictureBox2_new_GAME";
            this.pictureBox2_new_GAME.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2_new_GAME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2_new_GAME.TabIndex = 3;
            this.pictureBox2_new_GAME.TabStop = false;
            this.pictureBox2_new_GAME.Click += new System.EventHandler(this.pictureBox2_NewGAME);
            // 
            // pictureBox1_KEYS
            // 
            this.pictureBox1_KEYS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_KEYS.Image")));
            this.pictureBox1_KEYS.Location = new System.Drawing.Point(542, 109);
            this.pictureBox1_KEYS.Name = "pictureBox1_KEYS";
            this.pictureBox1_KEYS.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1_KEYS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_KEYS.TabIndex = 2;
            this.pictureBox1_KEYS.TabStop = false;
            this.pictureBox1_KEYS.Click += new System.EventHandler(this.pictureBox1_StartPause);
            this.pictureBox1_KEYS.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_KEY_for_move);
            // 
            // MainFormGameController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 540);
            this.Controls.Add(this.pictureBox2_new_GAME);
            this.Controls.Add(this.pictureBox1_KEYS);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximumSize = new System.Drawing.Size(700, 578);
            this.MinimumSize = new System.Drawing.Size(700, 578);
            this.Name = "MainFormGameController";
            this.Text = "Snake 1.0 - © Alexey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormGameController_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_new_GAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_KEYS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_KEYS;
        private System.Windows.Forms.PictureBox pictureBox2_new_GAME;
    }
}

