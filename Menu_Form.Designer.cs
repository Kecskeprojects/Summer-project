
namespace Game
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.Menu_label = new System.Windows.Forms.Label();
            this.Play_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.Login_screen = new System.Windows.Forms.Panel();
            this.Guest_picturebox = new System.Windows.Forms.PictureBox();
            this.Login_button2 = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            this.Pass_textbox = new System.Windows.Forms.TextBox();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Pass_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Scoreboard_button = new System.Windows.Forms.Button();
            this.TicTacToe_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Tictactoe_panel = new System.Windows.Forms.Panel();
            this.Draw_label = new System.Windows.Forms.Label();
            this.Program_win_label = new System.Windows.Forms.Label();
            this.Player_win_label = new System.Windows.Forms.Label();
            this.New_game_button = new System.Windows.Forms.Button();
            this.Tic_tac_toe_label = new System.Windows.Forms.Label();
            this.TTT_2_2 = new System.Windows.Forms.PictureBox();
            this.TTT_3_1 = new System.Windows.Forms.PictureBox();
            this.TTT_3_2 = new System.Windows.Forms.PictureBox();
            this.TTT_3_3 = new System.Windows.Forms.PictureBox();
            this.TTT_2_3 = new System.Windows.Forms.PictureBox();
            this.TTT_2_1 = new System.Windows.Forms.PictureBox();
            this.TTT_1_3 = new System.Windows.Forms.PictureBox();
            this.TTT_1_2 = new System.Windows.Forms.PictureBox();
            this.TTT_1_1 = new System.Windows.Forms.PictureBox();
            this.Tictactoe_picturebox = new System.Windows.Forms.PictureBox();
            this.Score_Panel = new System.Windows.Forms.Panel();
            this.Scoreboard_richtextBox2 = new System.Windows.Forms.RichTextBox();
            this.Scoreboard_richtextBox = new System.Windows.Forms.RichTextBox();
            this.Scoreboard_label = new System.Windows.Forms.Label();
            this.Guest_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Login_screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_picturebox)).BeginInit();
            this.Tictactoe_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tictactoe_picturebox)).BeginInit();
            this.Score_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_label
            // 
            this.Menu_label.AutoSize = true;
            this.Menu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Menu_label.Location = new System.Drawing.Point(269, 10);
            this.Menu_label.Name = "Menu_label";
            this.Menu_label.Size = new System.Drawing.Size(262, 55);
            this.Menu_label.TabIndex = 0;
            this.Menu_label.Text = "Main Menu";
            // 
            // Play_button
            // 
            this.Play_button.Enabled = false;
            this.Play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Play_button.Location = new System.Drawing.Point(340, 120);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(120, 40);
            this.Play_button.TabIndex = 1;
            this.Play_button.Text = "Play";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Login_button.Location = new System.Drawing.Point(675, 410);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(100, 40);
            this.Login_button.TabIndex = 2;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Login_screen
            // 
            this.Login_screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_screen.Controls.Add(this.Guest_picturebox);
            this.Login_screen.Controls.Add(this.Login_button2);
            this.Login_screen.Controls.Add(this.Register_button);
            this.Login_screen.Controls.Add(this.Pass_textbox);
            this.Login_screen.Controls.Add(this.Name_textbox);
            this.Login_screen.Controls.Add(this.Pass_label);
            this.Login_screen.Controls.Add(this.Name_label);
            this.Login_screen.Controls.Add(this.Login_label);
            this.Login_screen.Location = new System.Drawing.Point(279, 320);
            this.Login_screen.Name = "Login_screen";
            this.Login_screen.Size = new System.Drawing.Size(252, 130);
            this.Login_screen.TabIndex = 3;
            this.Login_screen.Visible = false;
            // 
            // Guest_picturebox
            // 
            this.Guest_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("Guest_picturebox.Image")));
            this.Guest_picturebox.Location = new System.Drawing.Point(231, -1);
            this.Guest_picturebox.Name = "Guest_picturebox";
            this.Guest_picturebox.Size = new System.Drawing.Size(20, 20);
            this.Guest_picturebox.TabIndex = 7;
            this.Guest_picturebox.TabStop = false;
            // 
            // Login_button2
            // 
            this.Login_button2.Location = new System.Drawing.Point(4, 100);
            this.Login_button2.Name = "Login_button2";
            this.Login_button2.Size = new System.Drawing.Size(70, 25);
            this.Login_button2.TabIndex = 5;
            this.Login_button2.Text = "Login";
            this.Login_button2.UseVisualStyleBackColor = true;
            this.Login_button2.Click += new System.EventHandler(this.Login_button2_Click);
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(177, 100);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(70, 25);
            this.Register_button.TabIndex = 6;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Pass_textbox
            // 
            this.Pass_textbox.Location = new System.Drawing.Point(105, 65);
            this.Pass_textbox.Name = "Pass_textbox";
            this.Pass_textbox.PasswordChar = '*';
            this.Pass_textbox.Size = new System.Drawing.Size(100, 20);
            this.Pass_textbox.TabIndex = 4;
            this.Pass_textbox.UseSystemPasswordChar = true;
            this.Pass_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pass_textbox_KeyDown);
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(105, 35);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(100, 20);
            this.Name_textbox.TabIndex = 3;
            this.Name_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Name_textbox_KeyDown);
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Pass_label.Location = new System.Drawing.Point(30, 65);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(64, 15);
            this.Pass_label.TabIndex = 2;
            this.Pass_label.Text = "Password:";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name_label.Location = new System.Drawing.Point(50, 35);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(44, 15);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Name:";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Login_label.Location = new System.Drawing.Point(-1, -1);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(45, 19);
            this.Login_label.TabIndex = 0;
            this.Login_label.Text = "Login";
            // 
            // Scoreboard_button
            // 
            this.Scoreboard_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Scoreboard_button.Location = new System.Drawing.Point(345, 190);
            this.Scoreboard_button.Name = "Scoreboard_button";
            this.Scoreboard_button.Size = new System.Drawing.Size(110, 25);
            this.Scoreboard_button.TabIndex = 4;
            this.Scoreboard_button.Text = "Scoreboard";
            this.Scoreboard_button.UseVisualStyleBackColor = true;
            this.Scoreboard_button.Click += new System.EventHandler(this.Scoreboard_button_Click);
            // 
            // TicTacToe_button
            // 
            this.TicTacToe_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TicTacToe_button.Location = new System.Drawing.Point(350, 240);
            this.TicTacToe_button.Name = "TicTacToe_button";
            this.TicTacToe_button.Size = new System.Drawing.Size(100, 30);
            this.TicTacToe_button.TabIndex = 5;
            this.TicTacToe_button.Text = "Tic-Tac-Toe";
            this.TicTacToe_button.UseVisualStyleBackColor = true;
            this.TicTacToe_button.Click += new System.EventHandler(this.TicTacToe_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Exit_button.Location = new System.Drawing.Point(10, 410);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(100, 40);
            this.Exit_button.TabIndex = 6;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Tictactoe_panel
            // 
            this.Tictactoe_panel.BackColor = System.Drawing.Color.White;
            this.Tictactoe_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tictactoe_panel.Controls.Add(this.Draw_label);
            this.Tictactoe_panel.Controls.Add(this.Program_win_label);
            this.Tictactoe_panel.Controls.Add(this.Player_win_label);
            this.Tictactoe_panel.Controls.Add(this.New_game_button);
            this.Tictactoe_panel.Controls.Add(this.Tic_tac_toe_label);
            this.Tictactoe_panel.Controls.Add(this.TTT_2_2);
            this.Tictactoe_panel.Controls.Add(this.TTT_3_1);
            this.Tictactoe_panel.Controls.Add(this.TTT_3_2);
            this.Tictactoe_panel.Controls.Add(this.TTT_3_3);
            this.Tictactoe_panel.Controls.Add(this.TTT_2_3);
            this.Tictactoe_panel.Controls.Add(this.TTT_2_1);
            this.Tictactoe_panel.Controls.Add(this.TTT_1_3);
            this.Tictactoe_panel.Controls.Add(this.TTT_1_2);
            this.Tictactoe_panel.Controls.Add(this.TTT_1_1);
            this.Tictactoe_panel.Controls.Add(this.Tictactoe_picturebox);
            this.Tictactoe_panel.Location = new System.Drawing.Point(575, 10);
            this.Tictactoe_panel.Name = "Tictactoe_panel";
            this.Tictactoe_panel.Size = new System.Drawing.Size(200, 300);
            this.Tictactoe_panel.TabIndex = 7;
            this.Tictactoe_panel.Visible = false;
            // 
            // Draw_label
            // 
            this.Draw_label.AutoSize = true;
            this.Draw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Draw_label.Location = new System.Drawing.Point(75, 30);
            this.Draw_label.Name = "Draw_label";
            this.Draw_label.Size = new System.Drawing.Size(50, 20);
            this.Draw_label.TabIndex = 14;
            this.Draw_label.Text = "Draw!";
            this.Draw_label.Visible = false;
            // 
            // Program_win_label
            // 
            this.Program_win_label.AutoSize = true;
            this.Program_win_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Program_win_label.Location = new System.Drawing.Point(68, 30);
            this.Program_win_label.Name = "Program_win_label";
            this.Program_win_label.Size = new System.Drawing.Size(64, 20);
            this.Program_win_label.TabIndex = 13;
            this.Program_win_label.Text = "AI wins!";
            this.Program_win_label.Visible = false;
            // 
            // Player_win_label
            // 
            this.Player_win_label.AutoSize = true;
            this.Player_win_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Player_win_label.Location = new System.Drawing.Point(65, 30);
            this.Player_win_label.Name = "Player_win_label";
            this.Player_win_label.Size = new System.Drawing.Size(69, 20);
            this.Player_win_label.TabIndex = 12;
            this.Player_win_label.Text = "You win!";
            this.Player_win_label.Visible = false;
            // 
            // New_game_button
            // 
            this.New_game_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.New_game_button.Location = new System.Drawing.Point(40, 261);
            this.New_game_button.Name = "New_game_button";
            this.New_game_button.Size = new System.Drawing.Size(120, 30);
            this.New_game_button.TabIndex = 11;
            this.New_game_button.Text = "New Game";
            this.New_game_button.UseVisualStyleBackColor = true;
            this.New_game_button.Click += new System.EventHandler(this.New_game_button_Click);
            // 
            // Tic_tac_toe_label
            // 
            this.Tic_tac_toe_label.AutoSize = true;
            this.Tic_tac_toe_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Tic_tac_toe_label.Location = new System.Drawing.Point(38, 0);
            this.Tic_tac_toe_label.Name = "Tic_tac_toe_label";
            this.Tic_tac_toe_label.Size = new System.Drawing.Size(125, 26);
            this.Tic_tac_toe_label.TabIndex = 10;
            this.Tic_tac_toe_label.Text = "Tic-Tac-Toe";
            // 
            // TTT_2_2
            // 
            this.TTT_2_2.BackColor = System.Drawing.SystemColors.Window;
            this.TTT_2_2.Location = new System.Drawing.Point(69, 124);
            this.TTT_2_2.Name = "TTT_2_2";
            this.TTT_2_2.Size = new System.Drawing.Size(60, 60);
            this.TTT_2_2.TabIndex = 9;
            this.TTT_2_2.TabStop = false;
            this.TTT_2_2.Click += new System.EventHandler(this.TTT_2_2_Click);
            // 
            // TTT_3_1
            // 
            this.TTT_3_1.BackColor = System.Drawing.SystemColors.Window;
            this.TTT_3_1.Location = new System.Drawing.Point(1, 192);
            this.TTT_3_1.Name = "TTT_3_1";
            this.TTT_3_1.Size = new System.Drawing.Size(60, 60);
            this.TTT_3_1.TabIndex = 8;
            this.TTT_3_1.TabStop = false;
            this.TTT_3_1.Click += new System.EventHandler(this.TTT_3_1_Click);
            // 
            // TTT_3_2
            // 
            this.TTT_3_2.BackColor = System.Drawing.SystemColors.Window;
            this.TTT_3_2.Location = new System.Drawing.Point(69, 192);
            this.TTT_3_2.Name = "TTT_3_2";
            this.TTT_3_2.Size = new System.Drawing.Size(60, 60);
            this.TTT_3_2.TabIndex = 7;
            this.TTT_3_2.TabStop = false;
            this.TTT_3_2.Click += new System.EventHandler(this.TTT_3_2_Click);
            // 
            // TTT_3_3
            // 
            this.TTT_3_3.BackColor = System.Drawing.SystemColors.Window;
            this.TTT_3_3.Location = new System.Drawing.Point(136, 192);
            this.TTT_3_3.Name = "TTT_3_3";
            this.TTT_3_3.Size = new System.Drawing.Size(60, 60);
            this.TTT_3_3.TabIndex = 6;
            this.TTT_3_3.TabStop = false;
            this.TTT_3_3.Click += new System.EventHandler(this.TTT_3_3_Click);
            // 
            // TTT_2_3
            // 
            this.TTT_2_3.BackColor = System.Drawing.SystemColors.Window;
            this.TTT_2_3.Location = new System.Drawing.Point(136, 124);
            this.TTT_2_3.Name = "TTT_2_3";
            this.TTT_2_3.Size = new System.Drawing.Size(60, 60);
            this.TTT_2_3.TabIndex = 5;
            this.TTT_2_3.TabStop = false;
            this.TTT_2_3.Click += new System.EventHandler(this.TTT_2_3_Click);
            // 
            // TTT_2_1
            // 
            this.TTT_2_1.BackColor = System.Drawing.SystemColors.Window;
            this.TTT_2_1.Location = new System.Drawing.Point(1, 124);
            this.TTT_2_1.Name = "TTT_2_1";
            this.TTT_2_1.Size = new System.Drawing.Size(60, 60);
            this.TTT_2_1.TabIndex = 4;
            this.TTT_2_1.TabStop = false;
            this.TTT_2_1.Click += new System.EventHandler(this.TTT_2_1_Click);
            // 
            // TTT_1_3
            // 
            this.TTT_1_3.BackColor = System.Drawing.SystemColors.Window;
            this.TTT_1_3.Location = new System.Drawing.Point(136, 56);
            this.TTT_1_3.Name = "TTT_1_3";
            this.TTT_1_3.Size = new System.Drawing.Size(60, 60);
            this.TTT_1_3.TabIndex = 3;
            this.TTT_1_3.TabStop = false;
            this.TTT_1_3.Click += new System.EventHandler(this.TTT_1_3_Click);
            // 
            // TTT_1_2
            // 
            this.TTT_1_2.BackColor = System.Drawing.SystemColors.Window;
            this.TTT_1_2.Location = new System.Drawing.Point(69, 56);
            this.TTT_1_2.Name = "TTT_1_2";
            this.TTT_1_2.Size = new System.Drawing.Size(60, 60);
            this.TTT_1_2.TabIndex = 2;
            this.TTT_1_2.TabStop = false;
            this.TTT_1_2.Click += new System.EventHandler(this.TTT_1_2_Click);
            // 
            // TTT_1_1
            // 
            this.TTT_1_1.BackColor = System.Drawing.SystemColors.Window;
            this.TTT_1_1.Location = new System.Drawing.Point(1, 56);
            this.TTT_1_1.Name = "TTT_1_1";
            this.TTT_1_1.Size = new System.Drawing.Size(60, 60);
            this.TTT_1_1.TabIndex = 1;
            this.TTT_1_1.TabStop = false;
            this.TTT_1_1.Click += new System.EventHandler(this.TTT_1_1_Click);
            // 
            // Tictactoe_picturebox
            // 
            this.Tictactoe_picturebox.Image = global::Game.Properties.Resources.Tic_Tac_Toe_board;
            this.Tictactoe_picturebox.Location = new System.Drawing.Point(-1, 54);
            this.Tictactoe_picturebox.Name = "Tictactoe_picturebox";
            this.Tictactoe_picturebox.Size = new System.Drawing.Size(200, 200);
            this.Tictactoe_picturebox.TabIndex = 0;
            this.Tictactoe_picturebox.TabStop = false;
            // 
            // Score_Panel
            // 
            this.Score_Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Score_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Score_Panel.Controls.Add(this.Scoreboard_richtextBox2);
            this.Score_Panel.Controls.Add(this.Scoreboard_richtextBox);
            this.Score_Panel.Controls.Add(this.Scoreboard_label);
            this.Score_Panel.Location = new System.Drawing.Point(10, 10);
            this.Score_Panel.Name = "Score_Panel";
            this.Score_Panel.Size = new System.Drawing.Size(250, 165);
            this.Score_Panel.TabIndex = 8;
            this.Score_Panel.Visible = false;
            // 
            // Scoreboard_richtextBox2
            // 
            this.Scoreboard_richtextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.Scoreboard_richtextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scoreboard_richtextBox2.Enabled = false;
            this.Scoreboard_richtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Scoreboard_richtextBox2.HideSelection = false;
            this.Scoreboard_richtextBox2.Location = new System.Drawing.Point(172, 41);
            this.Scoreboard_richtextBox2.Name = "Scoreboard_richtextBox2";
            this.Scoreboard_richtextBox2.Size = new System.Drawing.Size(78, 120);
            this.Scoreboard_richtextBox2.TabIndex = 9;
            this.Scoreboard_richtextBox2.Text = "";
            // 
            // Scoreboard_richtextBox
            // 
            this.Scoreboard_richtextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Scoreboard_richtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scoreboard_richtextBox.Enabled = false;
            this.Scoreboard_richtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Scoreboard_richtextBox.HideSelection = false;
            this.Scoreboard_richtextBox.Location = new System.Drawing.Point(0, 41);
            this.Scoreboard_richtextBox.Name = "Scoreboard_richtextBox";
            this.Scoreboard_richtextBox.Size = new System.Drawing.Size(166, 120);
            this.Scoreboard_richtextBox.TabIndex = 9;
            this.Scoreboard_richtextBox.Text = "";
            // 
            // Scoreboard_label
            // 
            this.Scoreboard_label.AutoSize = true;
            this.Scoreboard_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Scoreboard_label.Location = new System.Drawing.Point(63, 0);
            this.Scoreboard_label.Name = "Scoreboard_label";
            this.Scoreboard_label.Size = new System.Drawing.Size(124, 26);
            this.Scoreboard_label.TabIndex = 0;
            this.Scoreboard_label.Text = "Scoreboard";
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Score_Panel);
            this.Controls.Add(this.Tictactoe_panel);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.TicTacToe_button);
            this.Controls.Add(this.Scoreboard_button);
            this.Controls.Add(this.Login_screen);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Play_button);
            this.Controls.Add(this.Menu_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Login_screen.ResumeLayout(false);
            this.Login_screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Guest_picturebox)).EndInit();
            this.Tictactoe_panel.ResumeLayout(false);
            this.Tictactoe_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTT_1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tictactoe_picturebox)).EndInit();
            this.Score_Panel.ResumeLayout(false);
            this.Score_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu_label;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Panel Login_screen;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.TextBox Pass_textbox;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Button Login_button2;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button Scoreboard_button;
        private System.Windows.Forms.Button TicTacToe_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Panel Score_Panel;
        private System.Windows.Forms.PictureBox Guest_picturebox;
        private System.Windows.Forms.ToolTip Guest_tooltip;
        private System.Windows.Forms.Label Scoreboard_label;
        private System.Windows.Forms.RichTextBox Scoreboard_richtextBox;
        private System.Windows.Forms.RichTextBox Scoreboard_richtextBox2;
        private System.Windows.Forms.PictureBox Tictactoe_picturebox;
        private System.Windows.Forms.Label Tic_tac_toe_label;
        private System.Windows.Forms.Button New_game_button;
        public System.Windows.Forms.Panel Tictactoe_panel;
        public System.Windows.Forms.Label Program_win_label;
        public System.Windows.Forms.Label Player_win_label;
        public System.Windows.Forms.Label Draw_label;
        public System.Windows.Forms.PictureBox TTT_1_1;
        public System.Windows.Forms.PictureBox TTT_2_2;
        public System.Windows.Forms.PictureBox TTT_3_1;
        public System.Windows.Forms.PictureBox TTT_3_2;
        public System.Windows.Forms.PictureBox TTT_3_3;
        public System.Windows.Forms.PictureBox TTT_2_3;
        public System.Windows.Forms.PictureBox TTT_2_1;
        public System.Windows.Forms.PictureBox TTT_1_3;
        public System.Windows.Forms.PictureBox TTT_1_2;
    }
}

