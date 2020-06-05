using System;
using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;

namespace FleetView
{
    public partial class FleetForm : Form { 

        int numOfRows= 10;
        int numOfCols = 10;
        Button[,] userPanel = new Button[10, 10];
        Button[,] pcPanel = new Button[10, 10];

        public FleetForm()
        {
            InitializeComponent();
            DrawPanel(userPanel,47);
            DrawPanel(pcPanel,600);

        }
        private void DrawPanel(Button[,] panel,int left)
        {
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfCols; j++)
                {
                    panel[i, j] = new Button();
                    panel[i, j].BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                    panel[i, j].Location = new System.Drawing.Point(left + i * 40, 60 + j * 40);
                    panel[i, j].Size = new System.Drawing.Size(40, 40);
                    panel[i, j].TabStop = false;
                    this.Controls.Add(panel[i, j]);
                }
            }
        }

        private void buttonQuitOnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawButton(object sender, EventArgs e)
        {
            ResetButtons(userPanel);
            int[] sizeOfShip = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };

            Shipwright ship = new Shipwright(numOfRows, numOfCols);
            var fleet = ship.CreateFleet(sizeOfShip);
            foreach (Ship ships in fleet.Ships)
            {
                foreach (Square field in ships.Squares)
                {
                    userPanel[field.Row,field.Col].BackColor= System.Drawing.SystemColors.ControlDark;
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

        private void fleetgrid_Click(object sender, EventArgs e)
        {

        }
    }
}