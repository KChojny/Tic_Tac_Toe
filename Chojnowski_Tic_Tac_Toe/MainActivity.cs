using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Chojnowski_Tic_Tac_Toe
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button[] buttons;
        Button btnStart, btnReset, btnPlayer;
        TextView textView;
        int counter, oWins, xWins;
        int[,] tab;
        bool who_start = false;
        bool turn_of_X_player = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            buttons = new Button[9];
            buttons[0] = FindViewById<Button>(Resource.Id.button1);
            buttons[1] = FindViewById<Button>(Resource.Id.button2);
            buttons[2] = FindViewById<Button>(Resource.Id.button3);
            buttons[3] = FindViewById<Button>(Resource.Id.button4);
            buttons[4] = FindViewById<Button>(Resource.Id.button5);
            buttons[5] = FindViewById<Button>(Resource.Id.button6);
            buttons[6] = FindViewById<Button>(Resource.Id.button7);
            buttons[7] = FindViewById<Button>(Resource.Id.button8);
            buttons[8] = FindViewById<Button>(Resource.Id.button9);

            btnStart = FindViewById<Button>(Resource.Id.button10);
            btnReset = FindViewById<Button>(Resource.Id.button11);
            btnPlayer = FindViewById<Button>(Resource.Id.button12);

            textView = FindViewById<TextView>(Resource.Id.textView1);

            tab = new int[3, 3];

            btnStart.Click += delegate
            {
                textView.Text = "TIC TAC TOE\nX player: " + xWins + "\nO player: " + oWins;
                counter = 0;
                turn_of_X_player = who_start;

                ClearAllButtons();
                EnableAllButtons();
                ResetTable();
                SetColour();
            };
            btnReset.Click += delegate
            {
                xWins = 0;
                oWins = 0;
                
                textView.Text = "TIC TAC TOE\nX player: " + xWins + "\nO player: " + oWins;
                counter = 0;
                turn_of_X_player = who_start;

                ClearAllButtons();
                EnableAllButtons();
                ResetTable();
                SetColour();
            };
            btnPlayer.Click += delegate
            {
                who_start = !who_start;
                btnPlayer.Text = who_start ? "X" : "O";
            };
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += ButtonClicked;
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        private void ClearAllButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "";
            }
        }
        private void EnableAllButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
            }
        }
        private void DisableAllButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = false;
            }
        }

        private void ResetTable()
        {
            for (int i = 0; i < tab.GetLength(0); i++)
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = 0;
                }
        }

        private void SetColour()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].SetTextColor(Color.Black);
            }
        }
        private void ButtonClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            if (counter < 9)
            {
                switch (button.Id)
                {
                    case (Resource.Id.button1):
                        {
                            if (turn_of_X_player)
                            {
                                buttons[0].Text = "X";
                                tab[0, 0] = 1;
                                turn_of_X_player = false;
                            }
                            else
                            {
                                buttons[0].Text = "O";
                                tab[0, 0] = -1;
                                turn_of_X_player = true;
                            }
                            buttons[0].Enabled = false; counter++;
                            break;
                        }
                    case (Resource.Id.button2):
                        {
                            if (turn_of_X_player)
                            {
                                buttons[1].Text = "X";
                                tab[0, 1] = 1;
                                turn_of_X_player = false;
                            }
                            else
                            {
                                buttons[1].Text = "O";
                                tab[0, 1] = -1;
                                turn_of_X_player = true;
                            }
                            buttons[1].Enabled = false; counter++;
                            break;
                        }
                    case (Resource.Id.button3):
                        {
                            if (turn_of_X_player)
                            {
                                buttons[2].Text = "X";
                                tab[0, 2] = 1;
                                turn_of_X_player = false;
                            }
                            else
                            {
                                buttons[2].Text = "O";
                                tab[0, 2] = -1;
                                turn_of_X_player = true;
                            }
                            buttons[2].Enabled = false; counter++;
                            break;
                        }
                    case (Resource.Id.button4):
                        {
                            if (turn_of_X_player)
                            {
                                buttons[3].Text = "X";
                                tab[1, 0] = 1;
                                turn_of_X_player = false;
                            }
                            else
                            {
                                buttons[3].Text = "O";
                                tab[1, 0] = -1;
                                turn_of_X_player = true;
                            }
                            buttons[3].Enabled = false; counter++;
                            break;
                        }
                    case (Resource.Id.button5):
                        {
                            if (turn_of_X_player)
                            {
                                buttons[4].Text = "X";
                                tab[1, 1] = 1;
                                turn_of_X_player = false;
                            }
                            else
                            {
                                buttons[4].Text = "O";
                                tab[1, 1] = -1;
                                turn_of_X_player = true;
                            }
                            buttons[4].Enabled = false; counter++;
                            break;
                        }
                    case (Resource.Id.button6):
                        {
                            if (turn_of_X_player)
                            {
                                buttons[5].Text = "X";
                                tab[1, 2] = 1;
                                turn_of_X_player = false;
                            }
                            else
                            {
                                buttons[5].Text = "O";
                                tab[1, 2] = -1;
                                turn_of_X_player = true;
                            }
                            buttons[5].Enabled = false; counter++;
                            break;
                        }
                    case (Resource.Id.button7):
                        {
                            if (turn_of_X_player)
                            {
                                buttons[6].Text = "X";
                                tab[2, 0] = 1;
                                turn_of_X_player = false;
                            }
                            else
                            {
                                buttons[6].Text = "O";
                                tab[2, 0] = -1;
                                turn_of_X_player = true;
                            }
                            buttons[6].Enabled = false; counter++;
                            break;
                        }
                    case (Resource.Id.button8):
                        {
                            if (turn_of_X_player)
                            {
                                buttons[7].Text = "X";
                                tab[2, 1] = 1;
                                turn_of_X_player = false;
                            }
                            else
                            {
                                buttons[7].Text = "O";
                                tab[2, 1] = -1;
                                turn_of_X_player = true;
                            }
                            buttons[7].Enabled = false; counter++;
                            break;
                        }
                    case (Resource.Id.button9):
                        {
                            if (turn_of_X_player)
                            {
                                buttons[8].Text = "X";
                                tab[2, 2] = 1;
                                turn_of_X_player = false;
                            }
                            else
                            {
                                buttons[8].Text = "O";
                                tab[2, 2] = -1;
                                turn_of_X_player = true;
                            }
                            buttons[8].Enabled = false; counter++;
                            break;
                        }
                }// end of switch case
                int result = CurrentResult();
                if (result == 3) { DisableAllButtons(); xWins++; textView.Text = "X player wins!\nX player: " + xWins + "\nO player: " + oWins; }
                else if (result == -3) { DisableAllButtons(); oWins++; textView.Text = "O player wins!\nX player: " + xWins + "\nO player: " + oWins; }
                else if (counter == 9) { textView.Text = "Draw!\nX player: " + xWins + "\nO player: " + oWins; }
            }
        }//end of buttonClicked
        private int CurrentResult()
        {
            int sum;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                sum = tab[i, 0] + tab[i, 1] + tab[i, 2];
                if ((sum == 3) || (sum == -3)) return sum;
            }
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                sum = tab[0, j] + tab[1, j] + tab[2, j];
                if ((sum == 3) || (sum == -3)) return sum;
            }
            sum = tab[0, 0] + tab[1, 1] + tab[2, 2];
            if ((sum == 3) || (sum == -3)) return sum;
            sum = tab[0, 2] + tab[1, 1] + tab[2, 0];
            if ((sum == 3) || (sum == -3)) return sum;
            return 0;
        }
    }
}