using System;
using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;

namespace FleetView
{
    public partial class FleetForm : Form { 

        int numOfRows= 10;
        int numOfCols = 10;

        public FleetForm()
        {
            InitializeComponent();
            fleetgrid.SetupGrid(numOfCols, numOfRows);
            fleetGridPC.SetupGrid(numOfCols, numOfRows);
        }
        private void buttonQuitOnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawButton(object sender, EventArgs e)
        {
            int[] sizeOfShip = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };

            Shipwright ship = new Shipwright(numOfRows, numOfCols);
            var fleet = ship.CreateFleet(sizeOfShip);
            var fleetPc = ship.CreateFleet(sizeOfShip);
            fleetGridPC.FleetSetup(fleetPc);
            fleetgrid.FleetSetup(fleet);
        }

        private void fleetgrid_Click(object sender, EventArgs e)
        {

        }
    }
}