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
            this.label1 = new System.Windows.Forms.Label();
            this.fleetGridPC = new FleetView.fleetGrid(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDraw.Location = new System.Drawing.Point(38, 482);
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
            this.fleetgrid.Location = new System.Drawing.Point(38, 88);
            this.fleetgrid.Name = "fleetgrid";
            this.fleetgrid.Size = new System.Drawing.Size(394, 366);
            this.fleetgrid.TabIndex = 0;
            this.fleetgrid.Click += new System.EventHandler(this.fleetgrid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Grid";
            // 
            // fleetGridPC
            // 
            this.fleetGridPC.Location = new System.Drawing.Point(591, 88);
            this.fleetGridPC.Name = "fleetGridPC";
            this.fleetGridPC.Size = new System.Drawing.Size(394, 366);
            this.fleetGridPC.TabIndex = 3;
            this.fleetGridPC.Text = "fleetGrid1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(591, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "PC Grid";
            // 
            // FleetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1377, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fleetGridPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.fleetgrid);
            this.Name = "FleetForm";
            this.Text = "Fleet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private fleetGrid fleetgrid;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label label1;
        private fleetGrid fleetGridPC;
        private System.Windows.Forms.Label label2;
    }
}

