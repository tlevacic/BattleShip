namespace FleetView
{
    partial class FleetForm
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.fleetgrid = new FleetView.fleetGrid(this.components);
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDraw.Location = new System.Drawing.Point(219, 450);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(141, 30);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "&Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.drawButton);
            // 
            // fleetgrid
            // 
            this.fleetgrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fleetgrid.Location = new System.Drawing.Point(69, 12);
            this.fleetgrid.Name = "fleetgrid";
            this.fleetgrid.Size = new System.Drawing.Size(451, 413);
            this.fleetgrid.TabIndex = 0;
            // 
            // FleetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(591, 511);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.fleetgrid);
            this.Name = "FleetForm";
            this.Text = "Fleet";
            this.ResumeLayout(false);

        }

        #endregion
        private fleetGrid fleetgrid;
        private System.Windows.Forms.Button buttonDraw;
    }
}

