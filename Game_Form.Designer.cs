
namespace Game
{
    partial class Game_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Form));
            this.Game_timer = new System.Windows.Forms.Timer(this.components);
            this.Ready_button = new System.Windows.Forms.Button();
            this.Quit_button = new System.Windows.Forms.Button();
            this.Resume_button = new System.Windows.Forms.Button();
            this.Score_label_1 = new System.Windows.Forms.Label();
            this.Score_label = new System.Windows.Forms.Label();
            this.Stage_label = new System.Windows.Forms.Label();
            this.Player_picturebox = new System.Windows.Forms.PictureBox();
            this.Enemy_picturebox = new System.Windows.Forms.PictureBox();
            this.Bottom_picturebox = new System.Windows.Forms.PictureBox();
            this.Main_picturebox = new System.Windows.Forms.PictureBox();
            this.Health_progressbar = new System.Windows.Forms.ProgressBar();
            this.Health_label = new System.Windows.Forms.Label();
            this.Game_over_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottom_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Game_timer
            // 
            this.Game_timer.Tick += new System.EventHandler(this.Game_timer_Tick);
            // 
            // Ready_button
            // 
            this.Ready_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Ready_button.Location = new System.Drawing.Point(5, 5);
            this.Ready_button.Name = "Ready_button";
            this.Ready_button.Size = new System.Drawing.Size(100, 35);
            this.Ready_button.TabIndex = 1;
            this.Ready_button.Text = "Ready!";
            this.Ready_button.UseVisualStyleBackColor = true;
            this.Ready_button.Click += new System.EventHandler(this.Ready_button_Click);
            // 
            // Quit_button
            // 
            this.Quit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Quit_button.Location = new System.Drawing.Point(688, 408);
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.Size = new System.Drawing.Size(100, 30);
            this.Quit_button.TabIndex = 3;
            this.Quit_button.Text = "Quit";
            this.Quit_button.UseVisualStyleBackColor = true;
            this.Quit_button.Click += new System.EventHandler(this.Quit_button_Click);
            // 
            // Resume_button
            // 
            this.Resume_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Resume_button.Location = new System.Drawing.Point(12, 408);
            this.Resume_button.Name = "Resume_button";
            this.Resume_button.Size = new System.Drawing.Size(100, 30);
            this.Resume_button.TabIndex = 2;
            this.Resume_button.Text = "Pause";
            this.Resume_button.UseVisualStyleBackColor = true;
            this.Resume_button.Click += new System.EventHandler(this.Resume_button_Click);
            // 
            // Score_label_1
            // 
            this.Score_label_1.AutoSize = true;
            this.Score_label_1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Score_label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Score_label_1.Location = new System.Drawing.Point(660, 5);
            this.Score_label_1.Name = "Score_label_1";
            this.Score_label_1.Size = new System.Drawing.Size(70, 25);
            this.Score_label_1.TabIndex = 7;
            this.Score_label_1.Text = "Score:";
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Score_label.Location = new System.Drawing.Point(721, 5);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(76, 25);
            this.Score_label.TabIndex = 8;
            this.Score_label.Text = "000 pts";
            // 
            // Stage_label
            // 
            this.Stage_label.AutoSize = true;
            this.Stage_label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Stage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Stage_label.Location = new System.Drawing.Point(354, 5);
            this.Stage_label.Name = "Stage_label";
            this.Stage_label.Size = new System.Drawing.Size(91, 25);
            this.Stage_label.TabIndex = 9;
            this.Stage_label.Text = "Stage 01";
            // 
            // Player_picturebox
            // 
            this.Player_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("Player_picturebox.Image")));
            this.Player_picturebox.Location = new System.Drawing.Point(1, 220);
            this.Player_picturebox.Name = "Player_picturebox";
            this.Player_picturebox.Size = new System.Drawing.Size(80, 80);
            this.Player_picturebox.TabIndex = 6;
            this.Player_picturebox.TabStop = false;
            // 
            // Enemy_picturebox
            // 
            this.Enemy_picturebox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Enemy_picturebox.Location = new System.Drawing.Point(80, 100);
            this.Enemy_picturebox.Name = "Enemy_picturebox";
            this.Enemy_picturebox.Size = new System.Drawing.Size(720, 200);
            this.Enemy_picturebox.TabIndex = 5;
            this.Enemy_picturebox.TabStop = false;
            this.Enemy_picturebox.Click += new System.EventHandler(this.Enemy_picturebox_Click);
            // 
            // Bottom_picturebox
            // 
            this.Bottom_picturebox.Image = global::Game.Properties.Resources.Grass;
            this.Bottom_picturebox.Location = new System.Drawing.Point(0, 300);
            this.Bottom_picturebox.Name = "Bottom_picturebox";
            this.Bottom_picturebox.Size = new System.Drawing.Size(800, 150);
            this.Bottom_picturebox.TabIndex = 4;
            this.Bottom_picturebox.TabStop = false;
            // 
            // Main_picturebox
            // 
            this.Main_picturebox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Main_picturebox.Location = new System.Drawing.Point(0, 0);
            this.Main_picturebox.Name = "Main_picturebox";
            this.Main_picturebox.Size = new System.Drawing.Size(800, 300);
            this.Main_picturebox.TabIndex = 0;
            this.Main_picturebox.TabStop = false;
            // 
            // Health_progressbar
            // 
            this.Health_progressbar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Health_progressbar.ForeColor = System.Drawing.Color.Red;
            this.Health_progressbar.Location = new System.Drawing.Point(115, 5);
            this.Health_progressbar.Maximum = 99;
            this.Health_progressbar.Name = "Health_progressbar";
            this.Health_progressbar.Size = new System.Drawing.Size(150, 30);
            this.Health_progressbar.Step = 33;
            this.Health_progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Health_progressbar.TabIndex = 11;
            this.Health_progressbar.Value = 99;
            // 
            // Health_label
            // 
            this.Health_label.AutoSize = true;
            this.Health_label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Health_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Health_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Health_label.Location = new System.Drawing.Point(170, 40);
            this.Health_label.Name = "Health_label";
            this.Health_label.Size = new System.Drawing.Size(40, 25);
            this.Health_label.TabIndex = 12;
            this.Health_label.Text = "3/3";
            // 
            // Game_over_label
            // 
            this.Game_over_label.AutoSize = true;
            this.Game_over_label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Game_over_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Game_over_label.Location = new System.Drawing.Point(282, 50);
            this.Game_over_label.Name = "Game_over_label";
            this.Game_over_label.Size = new System.Drawing.Size(235, 46);
            this.Game_over_label.TabIndex = 13;
            this.Game_over_label.Text = "Game Over!";
            this.Game_over_label.Visible = false;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Game_over_label);
            this.Controls.Add(this.Health_label);
            this.Controls.Add(this.Health_progressbar);
            this.Controls.Add(this.Stage_label);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.Score_label_1);
            this.Controls.Add(this.Player_picturebox);
            this.Controls.Add(this.Enemy_picturebox);
            this.Controls.Add(this.Ready_button);
            this.Controls.Add(this.Quit_button);
            this.Controls.Add(this.Resume_button);
            this.Controls.Add(this.Bottom_picturebox);
            this.Controls.Add(this.Main_picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game3000";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_Form_FormClosed);
            this.Load += new System.EventHandler(this.Game_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bottom_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Main_picturebox;
        private System.Windows.Forms.Timer Game_timer;
        private System.Windows.Forms.Button Ready_button;
        private System.Windows.Forms.Button Quit_button;
        private System.Windows.Forms.Button Resume_button;
        private System.Windows.Forms.PictureBox Bottom_picturebox;
        private System.Windows.Forms.PictureBox Enemy_picturebox;
        private System.Windows.Forms.PictureBox Player_picturebox;
        private System.Windows.Forms.Label Score_label_1;
        private System.Windows.Forms.Label Score_label;
        private System.Windows.Forms.Label Stage_label;
        private System.Windows.Forms.ProgressBar Health_progressbar;
        private System.Windows.Forms.Label Health_label;
        private System.Windows.Forms.Label Game_over_label;
    }
}