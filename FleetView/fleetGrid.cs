using System.ComponentModel;

using System.Drawing;

using System.Windows.Forms;
using Vsite.Oom.Battleship.Model;

namespace FleetView
{
    public partial class fleetGrid : Control
    {
        public fleetGrid()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        public fleetGrid(IContainer c)
        {
            c.Add(this);
            InitializeComponent();
        }
        public void SetupGrid(int cols, int rows)
        {
            if (this.cols == cols && this.rows == rows)
                return;
            this.cols = cols;
            this.rows = rows;
            Invalidate();
        }
        public void FleetSetup(Fleet fleet)
        {
            this.fleet = fleet;
            Invalidate();
        }
        public void SetFleetOnGrid(Fleet fleet)
        {
            this.fleet = fleet;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pen)
        {
            DrawABackground(pen);
            DrawAGrid(pen);
            if (fleet != null)
                DrawAFleet(pen);
            base.OnPaint(pen);
        }

        private int FieldWidth
        {
            get { return (ClientRectangle.Width - 1) / rows; }
        }

        private int FieldHeigth
        {
            get { return (ClientRectangle.Height - 1) / cols; }
        }

        private void DrawABackground(PaintEventArgs pen)
        {
            int width = FieldWidth * cols + 1;
            int heigth = FieldHeigth * rows + 1;
            pen.Graphics.FillRectangle(SystemBrushes.Window, 0, 0, width, heigth);
        }

        private void DrawAGrid(PaintEventArgs pen)
        {
            DrawVerticalLine(pen);
            DrawHorizontalLine(pen);
        }


        private void DrawVerticalLine(PaintEventArgs pen)
        {
            int x = 0;
            int yStart = 0;
            int yEnd = FieldHeigth * rows;
            for (int c = 0; c <= cols; ++c)
            {
                pen.Graphics.DrawLine(line, x, yStart, x, yEnd);
                x += FieldWidth;
            }
        }
        private void DrawHorizontalLine(PaintEventArgs pen)
        {
            int xStart = 0;
            int xEnd = FieldWidth * cols;
            int y = 0;
            for (int r = 0; r <= rows; ++r)
            {
                pen.Graphics.DrawLine(line, xStart, y, xEnd, y);
                y += FieldHeigth;
            }
        }

        private void DrawAFleet(PaintEventArgs pen)
        {
            foreach (Ship ship in fleet.Ships)
            {
                foreach (Square field in ship.Squares)
                    DrawAShipField(pen, field);
            }
        }

        private void DrawAShipField(PaintEventArgs pen, Square field)
        {
            int rows = field.Row;
            int cols = field.Col;
            int x = rows * FieldWidth;
            int y = cols * FieldHeigth;
            pen.Graphics.FillRectangle(shipColor, x, y, FieldWidth, FieldHeigth);
            pen.Graphics.DrawRectangle(line, x, y, FieldWidth, FieldHeigth);
        }

        private int rows = 10;
        private int cols = 10;
        private Fleet fleet;

        private Pen line = new Pen(SystemColors.ActiveBorder);
        private Brush shipColor = new SolidBrush(Color.Blue);
    }
}
