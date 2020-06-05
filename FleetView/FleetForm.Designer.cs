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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.playerTurnButton = new System.Windows.Forms.Button();
            this.pcTurnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonDraw.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDraw.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDraw.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonDraw.Location = new System.Drawing.Point(169, 562);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(141, 30);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "&Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.DrawButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "HUMAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1118, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "AI";
            // 
            // playButton
            // 
            this.playButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.playButton.Enabled = false;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.playButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(408, 562);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(137, 30);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playerTurnButton
            // 
            this.playerTurnButton.BackColor = System.Drawing.Color.LawnGreen;
            this.playerTurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerTurnButton.Location = new System.Drawing.Point(144, 31);
            this.playerTurnButton.Name = "playerTurnButton";
            this.playerTurnButton.Size = new System.Drawing.Size(14, 12);
            this.playerTurnButton.TabIndex = 6;
            this.playerTurnButton.UseVisualStyleBackColor = false;
            // 
            // pcTurnButton
            // 
            this.pcTurnButton.BackColor = System.Drawing.Color.LawnGreen;
            this.pcTurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pcTurnButton.Location = new System.Drawing.Point(1066, 31);
            this.pcTurnButton.Name = "pcTurnButton";
            this.pcTurnButton.Size = new System.Drawing.Size(14, 12);
            this.pcTurnButton.TabIndex = 7;
            this.pcTurnButton.UseVisualStyleBackColor = false;
            // 
            // FleetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1203, 652);
            this.Controls.Add(this.pcTurnButton);
            this.Controls.Add(this.playerTurnButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FleetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet";
            this.Load += new System.EventHandler(this.FleetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button playerTurnButton;
        private System.Windows.Forms.Button pcTurnButton;
    }
}

