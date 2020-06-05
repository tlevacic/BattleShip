using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;

namespace FleetView
{
    public enum Turn
    {
        User,
        PC
    };
    public enum Winner
    {
        User,
        PC,
        Tie,
        None
    };

    public partial class FleetForm : Form {

        //Constructor, draw panel, draw fleet, exit game
        public FleetForm()
        {
            InitializeComponent();
            DrawPanel(userPanel,187);
            DrawPanel(pcPanel,660);
            whoPlays = Turn.User;
            playerTurnButton.BackColor = Color.LawnGreen;
            pcTurnButton.BackColor = Color.Red;
            EnableButtons(userPanel,false);
            EnableButtons(pcPanel, false);
        }
        private void FleetForm_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("../../Cursor/cursor.ico");
        }
        private void DrawPanel(GridButton[,] panel,int left)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    panel[i, j] = new GridButton();
                    panel[i, j].i = i;
                    panel[i, j].j = j;
                    panel[i, j].FlatStyle = FlatStyle.Flat;
                    panel[i, j].BackColor = Color.FromArgb(232, 232, 232);
                    panel[i, j].Location = new System.Drawing.Point(left + i * 40, 120 + j * 40);
                    panel[i, j].Size = new System.Drawing.Size(40, 40);
                    panel[i, j].TabStop = false;
                    panel[i, j].Click += ClickSquareEvent;
                    this.Controls.Add(panel[i, j]);
                }
            }
            char letter = 'A';
            for (int i = 0; i < numOfRows+1; i++)
            {
                for (int j = 0; j < numOfCols+1; j++)
                {
                    gridMarks[i, j] = new GridButton();
                    if(j!=0)
                        gridMarks[i, j].Text = j.ToString();
                    if(i!=0)
                        gridMarks[i, j].Text = letter.ToString();
                    gridMarks[i, j].BackColor = Color.FromArgb(232, 232, 232);
                    gridMarks[i, j].Location = new System.Drawing.Point(left + i * 40 - 40, 120 + j * 40- 40);
                    gridMarks[i, j].Size = new System.Drawing.Size(40, 40);
                    gridMarks[i, j].TabStop = false;
                    gridMarks[i, j].FlatStyle = FlatStyle.Flat;
                    gridMarks[i, j].Enabled = false;
                    this.Controls.Add(gridMarks[i, j]);
                }
                if (i != 0)
                    letter++;
            }

        }
        private void DrawButton(object sender, EventArgs e)
        {
            running = false;
            whoPlays = Turn.User;
            playerTurnButton.BackColor = Color.LawnGreen;
            pcTurnButton.BackColor = Color.Red;
            playButton.Enabled = true;
            ResetButtons(userPanel);
            ResetButtons(pcPanel);

            Shipwright ship = new Shipwright(numOfRows, numOfCols);
            //User fleet
            var fleet = ship.CreateFleet(sizeOfShip);
            //PC Fleet
            var fleetPc = ship.CreateFleet(sizeOfShip);
            //Store that in class members
            userFleet = fleet;
            pcFleet = fleetPc;
            //Create gunner
            gunner = new Gunner(numOfRows, numOfCols, sizeOfShip);

            foreach (Ship ships in fleet.Ships)
            {
                foreach (Square field in ships.Squares)
                {
                    userPanel[field.Row, field.Col].BackColor = Color.FromArgb(0, 96, 255);
                }
            }

            foreach (Ship ships in fleetPc.Ships)
            {
                foreach (Square field in ships.Squares)
                {
                    pcPanel[field.Row, field.Col].BackColor = Color.FromArgb(0, 96, 255);
                }
            }
        }
        private void ResetButtons(Button[,] panel)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    panel[i, j].BackColor = Color.FromArgb(232, 232, 232);
                }
            }
        }
        private void ButtonQuitOnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Enabled = false;
            running = true;
            Play();
        }

        //Game Loop
        private void Play()
        {
            if (running)
            {
                if (IsGameOver() == Winner.None)
                {
                    switch (whoPlays)
                    {
                        case Turn.User:
                            {
                                UserPlay();
                                break;
                            }
                        case Turn.PC:
                            {
                                EnableButtons(pcPanel, false);
                                PcPlay();
                                break;
                            }
                    }
                }
            }
        }

        private Winner IsGameOver()
        {
            Winner winner;
            var pcFleetSunked = pcFleet.Ships.SelectMany(s => s.Squares).Any(s => s.SquareState != SquareState.Sunken);
            var userFleetSunked = userFleet.Ships.SelectMany(s => s.Squares).Any(s => s.SquareState != SquareState.Sunken);
            if (!pcFleetSunked)
            {
                running = false;
                winner = Winner.User;
            }
            else if (!userFleetSunked)
            {
                running = false;
                winner = Winner.PC;
            }
            else if(!pcFleetSunked && !userFleetSunked)
            {
                running = false;
                winner = Winner.Tie;
            }
            else
            {
                winner = Winner.None;
            }
            return winner;
        }
        private void UserPlay()
        {
            EnableButtons(pcPanel, true);
        }
        private void EnableButtons(GridButton[,] grid,bool enable)
        {
            //If enable==true, then user can play
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    grid[i, j].Enabled = enable;
                }
            }
        }

        private void ClickSquareEvent(object sender, EventArgs e)
        {
                GridButton button = sender as GridButton;
                Square squareClicked = new Square(button.i, button.j);
                HitResult result = pcFleet.Hit(squareClicked);
                switch (result)
                {
                    case HitResult.Hit:
                        {
                            button.BackColor = Color.FromArgb(255, 255, 0);
                        break;
                        }
                    case HitResult.Missed:
                        {
                            button.BackColor = Color.Red;
                            whoPlays = Turn.PC;
                        playerTurnButton.BackColor = Color.Red;
                        pcTurnButton.BackColor = Color.LawnGreen;
                        break;
                        }
                    case HitResult.Sunken:
                        {
                            foreach (var sunkenSquare in pcFleet.Ships.Where(s => s.Squares.Contains(squareClicked)).SelectMany(s => s.Squares))
                                pcPanel[sunkenSquare.Row, sunkenSquare.Col].BackColor = Color.DarkMagenta;
                            break;
                        }
                }
            Play();
        }

        private async Task PcPlay()
        {
            await Task.Delay(1000);
            Square square=gunner.NextTarget();
            HitResult result = userFleet.Hit(square);
            gunner.ProcessHitResult(result);
            switch (result)
            {
                case HitResult.Hit:
                    {
                        userPanel[square.Row, square.Col].BackColor = Color.FromArgb(255, 255, 0);
                        await PcPlay();
                        break;
                    }
                case HitResult.Missed:
                    {
                        userPanel[square.Row, square.Col].BackColor = Color.Red;
                        whoPlays = Turn.User;
                        playerTurnButton.BackColor = Color.LawnGreen;
                        pcTurnButton.BackColor = Color.Red;
                        break;
                    }
                case HitResult.Sunken:
                    {
                        foreach (var sunkenSquare in userFleet.Ships.Where(s => s.Squares.Contains(square)).SelectMany(s => s.Squares))
                            userPanel[sunkenSquare.Row, sunkenSquare.Col].BackColor = Color.DarkMagenta;
                        await PcPlay();
                        break;
                    }
            }
            Play();
        }




        private int numOfRows = 10;
        private int numOfCols = 10;
        private GridButton[,] userPanel = new GridButton[10, 10];
        private GridButton[,] pcPanel = new GridButton[10, 10];
        private GridButton[,] gridMarks = new GridButton[11, 11];
        private Fleet userFleet;
        private Fleet pcFleet;
        private Gunner gunner;
        private int[] sizeOfShip = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };
        private Turn whoPlays;
        private bool running = false;
    }
}