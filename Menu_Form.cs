using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Menu_Form : Form
    {
        public Menu_Form(){InitializeComponent();}
        private void Menu_Load(object sender, EventArgs e)
        {
            //If statement to keep player logged in when reopening Menu_Form
            if(Program.Username != "")
            {
                Play_button.Enabled = true;
                Login_button.Text = "Logout";
            }
            //Setting the tooltip on the Login Panel
            Guest_tooltip.SetToolTip(Guest_picturebox, "You can use 'Guest' as a username without password.");
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            //If statement for if there is no player logged in
            if (Play_button.Enabled == false)
            {
                Login_screen.Visible = true;
                Name_textbox.Focus();
                return;
            }
            //Logs out the current player
            Play_button.Enabled = false;
            Login_button.Text = "Login";
            right_pass = false; right_name = false;
            Program.Username = "";
            Program.Password = "";
            Program.High_score = 0;
        }
        private void Name_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            //Login as Guest with Enter button, else focus on password textbox
            if(e.KeyCode == Keys.Enter)
            {
                if(Name_textbox.Text == "Guest"){Login_button2_Click(sender, e);return;}
                Pass_textbox.Focus();
            }
        }
        private void Pass_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            //Start login with Enter button
            if(e.KeyCode == Keys.Enter){Login_button2_Click(sender, e);}
        }

        //Bools for the database search
        bool right_pass = false, right_name = false;

        private void Login_button2_Click(object sender, EventArgs e)
        {
            //If statement to see if it is a "Guest" login
            if (Name_textbox.Text != "Guest" )
            {
                //If statement to see if either of the login textboxes are empty
                if (Name_textbox.Text != "" && Pass_textbox.Text != "")
                {
                    //Checking length, as only 4 character or longer names and passwords can be registered
                    if (Name_textbox.Text.Length > 3 && Pass_textbox.Text.Length > 3)
                    {
                        //Query for given name and pass in Players database
                        string connectionString = "datasource=localhost;port=3306;username=root;password=;database=Players;";
                        string query = "Select Name, Password, Best_score From users";
                        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                        MySqlCommand CommandDatabase = new MySqlCommand(query, databaseConnection);
                        MySqlDataReader reader;
                        try
                        {
                            databaseConnection.Open();
                            reader = CommandDatabase.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                                    if (row[0] == Name_textbox.Text)
                                    {
                                        right_name = true;
                                        if (row[1] == Pass_textbox.Text)
                                        {
                                            right_pass = true;
                                            Program.Username = row[0];
                                            Program.Password = row[1];
                                            Program.High_score = Convert.ToInt32(row[2]);

                                            break;
                                        }
                                        break;
                                    }
                                }
                            }
                            else { MessageBox.Show("Database Empty!"); }
                            databaseConnection.Close();
                        }
                        //Error catch
                        catch (Exception ex)
                        {
                            if (ex.ToString().Contains("Unable to connect")) { MessageBox.Show("Could not connect to a database!"); return; }
                            MessageBox.Show("Something went wrong!\n\n" + ex.ToString());
                        }
                    }
                    
                    //Check if the database has the user and password combination
                    if (right_name == true)
                    {
                        if (right_pass == true)
                        {
                            Login_screen.Visible = false;
                            Play_button.Enabled = true;
                            Login_button.Text = "Logout";
                            Pass_textbox.Text = ""; Name_textbox.Text = "";
                            Play_button.Focus();
                        }
                        else
                        {
                            MessageBox.Show("That is not the right password for this name!");
                            Pass_textbox.Text = "";
                        }
                    }else{MessageBox.Show("That name is not registered!\nUse the 'Register' button!");}
                }else{MessageBox.Show("One or both of the fields are empty!");}
            }
            else
            {
                //Special case for Guest
                MessageBox.Show("Your score will not be saved as a Guest!");
                Login_screen.Visible = false;
                Play_button.Enabled = true;
                Login_button.Text = "Logout";
                Pass_textbox.Text = ""; Name_textbox.Text = "";
                Play_button.Focus();
            }
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            //If statement to see if it is a "Guest" login
            if (Name_textbox.Text != "Guest") 
            {
                //If statement to see if either of the login textboxes are empty
                if (Name_textbox.Text != "" && Pass_textbox.Text != "")
                {
                    //Checking length, as only 4 character or longer names and passwords can be registered
                    if (Name_textbox.Text.Length > 3 && Pass_textbox.Text.Length > 3)
                    {
                        
                        //Inserting new entry into Players database
                        string connectionString = "datasource=localhost;port=3306;username=root;password=;database=Players;";
                        string query = "INSERT INTO `users`(`Name`, `Password`, `Best_score`) VALUES ('" + Name_textbox.Text + "', '" + Pass_textbox.Text + "', 0);";
                        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                        MySqlCommand CommandDatabase = new MySqlCommand(query, databaseConnection);
                        try
                        {
                            databaseConnection.Open();
                            CommandDatabase.Prepare();
                            CommandDatabase.ExecuteNonQuery();
                            databaseConnection.Close();
                            MessageBox.Show("User has been registered!\nYou can Log in now!");
                        }
                        //Error catch
                        catch (Exception ex)
                        {
                            if (ex.ToString().Contains("Duplicate")) { MessageBox.Show("There is a user registered with that name!\nChoose another name!"); return; }
                            if (ex.ToString().Contains("Unable to connect")) { MessageBox.Show("Could not connect to a database!"); return; }
                            MessageBox.Show("Something went wrong!\n\n" + ex.ToString());
                        }
                    }else{MessageBox.Show("The name or password must be more than 3 characters!");}
                }else{MessageBox.Show("One or both of the fields are empty!");}
            }else{MessageBox.Show("You can't save 'Guest' as a username!");}
        }

        private void Scoreboard_button_Click(object sender, EventArgs e)
        {
            //If statement to see if the scoreboard is currently Visible
            if (Score_Panel.Visible == false)
            {
                //Query for the 5 highest scores in Players database
                string connectionString = "datasource=localhost; port=3306;username=root;password=;database=Players";
                string query = "SELECT Name, Best_score FROM `users` ORDER BY Best_score DESC LIMIT 5";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader;
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    if (reader.HasRows)
                    {
                        int i = 1;
                        while (reader.Read())
                        {
                            //Writing out the score into the richtextboxes
                            string[] row = { reader.GetString(0), reader.GetString(1) };
                            Scoreboard_richtextBox.Text += "" + i + ". " + row[0] + "\n";
                            Scoreboard_richtextBox2.Text += row[1] + " pts\n";
                            i++;
                        }
                    }
                    else { MessageBox.Show("The database is empty!"); }
                    databaseConnection.Close();
                }
                //Error catch
                catch (Exception ex)
                {
                    if (ex.ToString().Contains("Unable to connect")) { MessageBox.Show("Could not connect to a database!"); return; }
                    MessageBox.Show("Something went wrong!\n\n" + ex.ToString());
                }
                //After scores are written into the textboxes, we make the scoreboard visible
                Score_Panel.Visible = true;
            }
            else
            { 
                //If Scoreboard was visible, make it invisible and empty the textboxes
                Score_Panel.Visible = false;
                Scoreboard_richtextBox.Text = "";
                Scoreboard_richtextBox2.Text = "";
            }
        }
        private void TicTacToe_button_Click(object sender, EventArgs e)
        {
            //Open the Tictactoe_panel if closed, close it if opened and reset the game
            if (Tictactoe_panel.Visible == false) { Tictactoe_panel.Visible = true; }
            else {Tictactoe_panel.Visible = false; New_game_button_Click(sender, e);}
        }

        //3 dimensional array to store which pictureboxes have what kind of symbol, 0 is empty, 1 is X, 2 is O
        readonly int[,] fields = new int[3, 3] {{ 0, 0, 0 },
                                                { 0, 0, 0 },
                                                { 0, 0, 0 }};

        //Global variables for Tic Tac Toe
        int turn = 1; bool win = false;

        private void TicTacToe_Game(object sender)
        {
            //Store sender as variable and as a picture box, and save the corresponding values for it in the 3 dimensional array
            var field = sender as PictureBox;
            string name = field.Name;
            string[] parts = name.Split('_');
            int pos_y = int.Parse(parts[1]) - 1, pos_x = int.Parse(parts[2]) - 1;

            //If the clicked picturebox is empty, and the game is not over, proceed
            if (fields[pos_x, pos_y] == 0 && win == false)
            {

                //Save player move in array and change corresponding picturebox to X symbol
                fields[pos_x, pos_y] = 1;
                field.ImageLocation = "Assets/X_symbol_white.png";

                //If 3 turns passed, check win state for player
                if (turn >= 3)
                {
                    Check_win(1);
                }

                //If we have empty pictureboxes left, which there won't be after the player's 5th move, proceed
                if (turn < 5 && win == false)
                {
                    //Run the ai function for the program's move
                    int[] location = Tic_tac_toe_ai();

                    //After it finds one, save the position in the array, then find and change corresponding picturebox to O symbol
                    fields[location[0], location[1]] = 2;
                    name = "TTT_" + (location[1] + 1) + "_" + (location[0] + 1);
                    Control[] temp_arr = Tictactoe_panel.Controls.Find(name, true);
                    field = temp_arr[0] as PictureBox;
                    field.ImageLocation = "Assets/O_symbol_white.png";

                    //If 3 turns have passed and player has not won yet, check if AI has won
                    if (turn >= 3 && win == false)
                    {
                        Check_win(2);
                    }
                }

                //Turn counter
                turn++;
            }
        }

        private void Check_win(int player)
        {
            //Test if either player has 3 of the same symbols in any direction
            //Test for the two diagonal cases
            if (fields[0, 0] == player && fields[1, 1] == player && fields[2, 2] == player) { win = true; }
            else if (fields[0, 2] == player && fields[1, 1] == player && fields[2, 0] == player) { win = true; }

            //If there is a win for someone in the diagonals, do not seach the rows and lines
            if (win != true)
            {
                //For loop for the vertical and horizontal cases
                for (int orient = 0; orient < 2; orient++)
                {

                    //2 for loops to get through the whole array in one or the other orientation
                    for (int i = 0; i < 3; i++)
                    {
                        int count = 0;
                        for (int j = 0; j < 3; j++)
                        {
                            //Counts the number of same symbols in a row or line
                            if (orient == 0)
                            {
                                if (fields[i, j] == player) { count++; }
                            }
                            else
                            {
                                if (fields[j, i] == player) { count++; }
                            }
                        }

                        //If it finds 3 of the same in a row or line break out of the loop to stop the game
                        if (count == 3) { win = true; break; }
                    }
                    if (win == true) { break; }
                }
            }

            //If either player won, show their win label
            if (win == true)
            {
                if (player == 1) { Player_win_label.Visible = true; return; }
                else { Program_win_label.Visible = true; return; }
            }

            //If neither player won by the end of the 5th turn, show draw_label
            if (win == false && turn >= 5) { Draw_label.Visible = true; }
        }

        private int[] Tic_tac_toe_ai()
        {
            //Declare variables for search
            int[] location = { 0, 0 };
            bool found_loc = false;
            int occupied_count, empty_count, player;

            //For loop to search for 1 empty places for the program, then 1 empty space for the player and lastly 2 empty places for the program
            for (int round = 1; round < 4; round++)
            {
                //Set the player value depending on the round
                if (round == 2) { player = 1; }
                else player = 2;

                //For loop for the vertical and horizontal cases
                for (int orient = 0; orient < 2; orient++)
                {
                    //2 for loops to get through the whole array in one or the other orientation
                    for (int i = 0; i < 4; i++)
                    {
                        //Reset counters
                        occupied_count = 0; empty_count = 0;

                        //If we have not checked every line or row, proceed as normal
                        if (i < 3)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                //Counts the number of same symbols and empty spaces in a row or line, and saves one of the empty spaces location
                                if (orient == 0)
                                {
                                    if (fields[i, j] == player) { occupied_count++; }
                                    else if (fields[i, j] == 0) { empty_count++; location[0] = i; location[1] = j; }
                                }
                                else
                                {
                                    if (fields[j, i] == player) { occupied_count++; }
                                    else if (fields[j, i] == 0) { empty_count++; location[0] = j; location[1] = i; }
                                }
                            }
                        }

                        //If we have seen all the rows or lines, search the last case, the diagonals
                        else
                        {
                            int[] temp = Diagonal_check(orient, player);
                            occupied_count = temp[0]; empty_count = temp[1]; location[0] = temp[2]; location[1] = temp[3];
                        }

                        //Check if either player can win in the given row or line or diagonal
                        if (occupied_count == 2 && empty_count == 1) { found_loc = true; break; }

                        //Else in the second round, check if a suitable row or line or diagonal is optimal to try to win the game for the program
                        else if (occupied_count == 1 && empty_count == 2 && round == 3) { found_loc = true; break; }
                    }
                    if (found_loc == true) { break; }
                }
                if (found_loc == true) { break; }
            }

            //If all options have been exhausted, the program occupies a random empty space
            if (found_loc == false)
            {
                Random r = new Random();
                do
                {
                    location[0] = r.Next(0, 3);
                    location[1] = r.Next(0, 3);
                } while (fields[location[0], location[1]] != 0);
            }
            return location;
        }

        private int[] Diagonal_check(int orient, int player)
        {
            //Declare variables
            int occupied_count = 0, empty_count = 0, x = 0, y = 0;

            //2 loops to go through the matrix
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //Checks for one of the diagonals in one orientation, and the other one in the other orientation
                    if (orient == 0 && (i + j) == 2)
                    {
                        if (fields[i, j] == player) { occupied_count++; }
                        else if (fields[i, j] == 0) { empty_count++; x = i; y = j; }
                    }
                    else if (orient == 1 && i == j)
                    {
                        if (fields[i, j] == player) { occupied_count++; }
                        else if (fields[i, j] == 0) { empty_count++; x = i; y = j; }
                    }
                }
            }
            //Make an array for the return with the needed values
            int[] temp = { occupied_count, empty_count, x, y };
            return temp;
        }
        //Checks to see which Picturebox was pressed, and send it's value to the game
        private void TTT_1_1_Click(object sender, EventArgs e) { TicTacToe_Game(sender); }
        private void TTT_1_2_Click(object sender, EventArgs e) { TicTacToe_Game(sender); }
        private void TTT_1_3_Click(object sender, EventArgs e) { TicTacToe_Game(sender); }
        private void TTT_2_1_Click(object sender, EventArgs e) { TicTacToe_Game(sender); }
        private void TTT_2_2_Click(object sender, EventArgs e) { TicTacToe_Game(sender); }
        private void TTT_2_3_Click(object sender, EventArgs e) { TicTacToe_Game(sender); }
        private void TTT_3_1_Click(object sender, EventArgs e) { TicTacToe_Game(sender); }
        private void TTT_3_2_Click(object sender, EventArgs e) { TicTacToe_Game(sender); }
        private void TTT_3_3_Click(object sender, EventArgs e) { TicTacToe_Game(sender); }
        
        private void New_game_button_Click(object sender, EventArgs e)
        {
            //Empty out the matrix
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++){fields[i, j] = 0;}
            }

            //Clear the pictureboxes
            TTT_1_1.ImageLocation = ""; TTT_1_2.ImageLocation = ""; TTT_1_3.ImageLocation = "";
            TTT_2_1.ImageLocation = ""; TTT_2_2.ImageLocation = ""; TTT_2_3.ImageLocation = "";
            TTT_3_1.ImageLocation = ""; TTT_3_2.ImageLocation = ""; TTT_3_3.ImageLocation = "";

            //Reset global variables and labels
            turn = 1; win = false;
            Player_win_label.Visible = false; Program_win_label.Visible = false; Draw_label.Visible = false;
        }
        private void Play_button_Click(object sender, EventArgs e)
        {
            //Closing Menu_Form and opening Game_Form
            ActiveForm.Visible = false;
            _ = new Game_Form { Visible = true };
        }
        private void Exit_button_Click(object sender, EventArgs e){Application.Exit(); }
        
    }
}