using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public partial class Game_Form : Form
    {
        public Game_Form(){InitializeComponent();}
        private void Game_Form_Load(object sender, EventArgs e) {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        private void Resume_button_Click(object sender, EventArgs e)
        {
            //Resume timer if it is stopped, else, stop the timer
            if(Resume_button.Text == "Resume")
            {
                Resume_button.Text = "Pause";
                Game_timer.Interval = 20;
                Game_timer.Start();
                gamestarted = true;
            }
            else
            {
                Resume_button.Text = "Resume";
                Game_timer.Stop();
                gamestarted = false;
            }
        }

        //Global variables
        int charanim_time = 0, last_shot = 0, number_of_enemies = 5, health = 3, stage = 0, points = 0, spawn = 0, spawn_time = 0, finished_enemies = 0;
        bool gamestarted = false, clicked = false;
        readonly List<Arrows> arrows = new List<Arrows>();
        readonly List<Enemies> enemies = new List<Enemies>();

        private void Game_timer_Tick(object sender, EventArgs e)
        {
            //Check if Character is currently "shooting"
            if (Player_picturebox.ImageLocation == "Assets/Character_shoot.png")
            {
                //If a click occurs before picture reset, restart the timer
                if(clicked == true) { charanim_time = 0; clicked = false; }

                //If the timer had 15 loops since picture change, reset picture to "still", if not, add to the counter
                if (charanim_time >= 15) { charanim_time = 0; Player_picturebox.ImageLocation = "Assets/Character_still.png"; }
                else charanim_time++;
            }

            //Create graphics variable, clear the previous objects
            BufferedGraphics gr = new BufferedGraphicsContext().Allocate(Enemy_picturebox.CreateGraphics(), DisplayRectangle);
            gr.Graphics.Clear(Color.LightSkyBlue);

            //Collision test
            for (int i = 0; i < arrows.Count; i++)
            {
                //Only check arrows that have not hit something
                if (arrows[i].hit != true)
                {
                    for (int j = 0; j < spawn; j++)
                    {
                        //Only check enemies that have not been hit or hit the player
                        if (enemies[j].hit != true && enemies[j].reached_border != true)
                        {

                            //Check if any enemy coordinates match up with the middle of the arrow
                            if (arrows[i].arr_x_coord + 5 > enemies[j].x_coord && arrows[i].arr_x_coord + 5 < enemies[j].x_coord + 50 && 
                                arrows[i].arr_y_coord + 5 > enemies[j].y_coord - 5 && arrows[i].arr_y_coord + 5 < enemies[j].y_coord + 50)
                            {
                                arrows[i].hit = true;
                                enemies[j].health -= 1;

                                //Check if enemy has health left
                                if (enemies[j].health <= 0)
                                {
                                    enemies[j].hit = true;
                                    points++;

                                    //Write out new score on scoreboard
                                    if (points < 100)
                                    {
                                        if (points < 10) Score_label.Text = "00" + points + " pts";
                                        else Score_label.Text = "0" + points + " pts";
                                    }
                                    else Score_label.Text = "" + points + " pts";
                                }
                            }
                        }
                    }
                }
            }

            //For loop to draw all the arrows, add 1 to the last_shot counter
            last_shot++;
            for (int i = 0; i < arrows.Count; i++)
            {
                if (arrows[i].steps_taken < arrows[i].steps_total + 30 && arrows[i].hit != true) {
                    gr.Graphics.FillEllipse(new SolidBrush(Color.Black), arrows[i].arr_x_coord, arrows[i].arr_y_coord, 10, 10);
                    arrows[i].arr_x_coord += arrows[i].arr_x_speed;
                    arrows[i].arr_y_coord += arrows[i].arr_y_speed;
                    arrows[i].steps_taken++;
                }
            }

            //Control rate of new enemies introduced to Enemy_picturebox
            if(spawn < enemies.Count && spawn_time == 15)
            {
                spawn++;
                spawn_time = 0;
            }
            spawn_time++;

            //For loop for drawing enemies on the Enemy_picturebox
            for (int i = 0; i < spawn; i++)
            {
                if (enemies[i].reached_border != true && enemies[i].hit != true) {

                    //Switch for drawing the different types of enemies
                    if(enemies[i].type == 1){ gr.Graphics.FillEllipse(new SolidBrush(enemies[i].color), enemies[i].x_coord, enemies[i].y_coord, enemies[i].dim_x, enemies[i].dim_y); }
                    else { gr.Graphics.FillRectangle(new SolidBrush(enemies[i].color), enemies[i].x_coord, enemies[i].y_coord, enemies[i].dim_x, enemies[i].dim_y); }

                    //If enemy reaches character, it disappears and damages player, otherwise continue moving
                    if(enemies[i].x_coord <= 0)
                    {
                        enemies[i].reached_border = true;
                        health--;
                        Health_label.Text = "" + health + "/3";
                        Health_progressbar.Value -= 33;
                    }
                    else enemies[i].x_coord -= enemies[i].speed;
                }
                //Count number of enemies hit by arrow or hit player
                if(enemies[i].reached_border == true || enemies[i].hit == true)
                {
                    finished_enemies += 1;
                }
            }

            //If all enemies died or hit the player, the stage is over, if the player's health ran out, the game is over
            if(health <= 0) 
            { 
                Game_timer.Stop(); 
                gr.Graphics.Clear(Color.LightSkyBlue); 
                gamestarted = false; 
                Ready_button.Enabled = false; 
                Resume_button.Enabled = false;
                Game_over_label.Visible = true;
            }
            if (finished_enemies == enemies.Count) 
            { 
                Game_timer.Stop(); 
                gr.Graphics.Clear(Color.LightSkyBlue); 
                gamestarted = false; 
            }
            else finished_enemies = 0;

            //Render the buffer
            gr.Render();

            //Less flicker
            System.Threading.Thread.Sleep(20);
        }
        private void Ready_button_Click(object sender, EventArgs e)
        {
            if (gamestarted == false)
            {
                //Start the timer, clear enemy and arrow list
                Game_timer.Interval = 20;
                Game_timer.Start();
                arrows.Clear();
                enemies.Clear();

                //Reset global variables, new random number generator
                gamestarted = true;
                spawn = 0; spawn_time = 0;
                health = 3; Health_label.Text = "3/3"; Health_progressbar.Value = 99;
                Random r = new Random();

                //For loop to add enemy entries to the enemies list
                for (int i = 0; i < number_of_enemies; i++)
                {
                    //Randomize the types for the enemies
                    int rand = r.Next(0, 4);
                    switch (rand)
                    {
                        case 0: { enemies.Add(new Enemies(720, 5, 160, 1, 0, Color.Brown, 40, 40)); break; }
                        case 1: { enemies.Add(new Enemies(720, 7, 60, 1, 1, Color.Red, 40, 40)); break; }
                        case 2: { enemies.Add(new Enemies(720, 5, 150, 3, 2, Color.Blue, 50, 50)); break; }
                        case 3: { enemies.Add(new Enemies(720, 10, 160, 1, 3, Color.Green, 50, 40)); break; }
                    }
                }

                //Up the number of enemies for the next round
                number_of_enemies += 2;

                //Add one to the stage variable, and set the text for the Stage_label
                stage++;
                if (stage < 10) Stage_label.Text = "Stage 0" + stage;
                else Stage_label.Text = "Stage " + stage;
            }
        }

        private void Enemy_picturebox_Click(object sender, EventArgs e)
        {
            //Check if ready button has been pressed and if enough time has elapsed between shots
            if (gamestarted == true && last_shot > 8)
            {
                //Variable declaration
                int kezd_x = 0, kezd_y = 150, total_step;
                float temp_x, temp_y;

                //Location of cursor in the Enemy_picturebox
                int cursor_x = Cursor.Position.X - (Screen.PrimaryScreen.Bounds.Width - Game_Form.ActiveForm.Width) / 2 - 80 - 5;
                int cursor_y = Cursor.Position.Y - (Screen.PrimaryScreen.Bounds.Height - Game_Form.ActiveForm.Height) / 2 - 100 - 5;

                //Calculate length of route the arrow has to take, and from that, the pixels the arrow moves in a single tick in both axes
                total_step = Convert.ToInt32(Math.Sqrt(Math.Pow(cursor_x - kezd_x, 2) + Math.Pow(cursor_y - kezd_y, 2))/22);
                temp_y = (kezd_y - cursor_y) / total_step * -1;
                temp_x = cursor_x / total_step;

                //Add new Arrow to list
                arrows.Add(new Arrows(kezd_x, temp_x, kezd_y, temp_y, total_step));

                //Set character picture to "shoot" image, change clicked bool, reset last_shot tick counter
                Player_picturebox.ImageLocation = "Assets/Character_shoot.png";
                clicked = true;
                last_shot = 0;
            }
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            //If the game is not running, the user is not a Guest and the score is higher than their high score, save the new high score in the database
            if(gamestarted == false)
            {
                if(Program.Username != "" && points > Program.High_score)
                {
                    string connectionString = "datasource=localhost;port=3306;username=root;password=;database=Players;";
                    string query = "UPDATE `users` SET `Best_score`= " + points + " WHERE Name = '" + Program.Username + "';";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand CommandDatabase = new MySqlCommand(query, databaseConnection);
                    try
                    {
                        databaseConnection.Open();
                        CommandDatabase.Prepare();
                        CommandDatabase.ExecuteNonQuery();
                        databaseConnection.Close();
                    }
                    //Error catch
                    catch (Exception ex)
                    {
                        if (ex.ToString().Contains("Unable to connect")) { MessageBox.Show("Could not connect to a database!"); return; }
                        MessageBox.Show("Something went wrong!\n\n" + ex.ToString());
                    }
                }
                Game_Form.ActiveForm.Close();
            }
        }

        private void Game_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Go back to Menu_Form when Game_Form closes
            _ = new Menu_Form { Visible = true };
        }
    }
}