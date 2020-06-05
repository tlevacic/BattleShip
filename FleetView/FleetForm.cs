using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;

namespace FleetView
{
    public partial class FleetForm : Form {

        private int numOfRows = 10;
        private int numOfCols = 10;
        private GridButton[,] userPanel = new GridButton[10, 10];
        private GridButton[,] pcPanel = new GridButton[10, 10];
        private Fleet userFleet;
        private Fleet pcFleet;
        private Gunner gunner;
        private int[] sizeOfShip = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };

        public FleetForm()
        {
            InitializeComponent();
            DrawPanel(userPanel,47);
            DrawPanel(pcPanel,600);
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
                    panel[i, j].BackColor = System.Drawing.SystemColors.ControlDark;
                    panel[i, j].Location = new System.Drawing.Point(left + i * 40, 60 + j * 40);
                    panel[i, j].Size = new System.Drawing.Size(40, 40);
                    panel[i, j].TabStop = false;
                    panel[i, j].Click += ClickSquareEvent;
                    this.Controls.Add(panel[i, j]);
                }
            }
        }

        private void ClickSquareEvent(object sender, EventArgs e)
        {
            GridButton button = sender as GridButton;
            Square squareClicked = new Square(button.i, button.j);
            HitResult result= pcFleet.Hit(squareClicked);
            switch (result)
            {
                case HitResult.Hit:
                    {
                        button.BackColor = Color.Red;
                        break;
                    }
                case HitResult.Missed:
                    {
                        button.BackColor = Color.Black;
                        PcPlay();
                        break;
                    }
                case HitResult.Sunken:
                    {
                        foreach (var sunkenSquare in pcFleet.Ships.Where(s => s.Squares.Contains(squareClicked)).SelectMany(s => s.Squares))
                            pcPanel[sunkenSquare.Row, sunkenSquare.Col].BackColor = Color.DarkMagenta;
                        break;
                    }
            }
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
                        userPanel[square.Row, square.Col].BackColor = Color.Red;
                        await PcPlay();
                        break;
                    }
                case HitResult.Missed:
                    {
                        userPanel[square.Row, square.Col].BackColor = Color.Black;
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
        }

        private void ButtonQuitOnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DrawButton(object sender, EventArgs e)
        {
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
                    userPanel[field.Row,field.Col].BackColor= System.Drawing.SystemColors.ControlDark;
                }
            }

            foreach (Ship ships in fleetPc.Ships)
            {
                foreach (Square field in ships.Squares)
                {
                    pcPanel[field.Row, field.Col].BackColor = System.Drawing.SystemColors.ControlDark;
                }
            }
        }

        private void ResetButtons(Button[,] panel)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    panel[i, j].BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            buttonDraw.Enabled = false;
            playButton.Enabled = false;
        }
    }
}