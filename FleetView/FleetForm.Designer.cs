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
            this.five1h = new System.Windows.Forms.Label();
            this.four1h = new System.Windows.Forms.Label();
            this.four2h = new System.Windows.Forms.Label();
            this.three1h = new System.Windows.Forms.Label();
            this.three2h = new System.Windows.Forms.Label();
            this.two4h = new System.Windows.Forms.Label();
            this.three3h = new System.Windows.Forms.Label();
            this.two3h = new System.Windows.Forms.Label();
            this.two1h = new System.Windows.Forms.Label();
            this.two2h = new System.Windows.Forms.Label();
            this.five1pc = new System.Windows.Forms.Label();
            this.four1pc = new System.Windows.Forms.Label();
            this.four2pc = new System.Windows.Forms.Label();
            this.three1pc = new System.Windows.Forms.Label();
            this.three2pc = new System.Windows.Forms.Label();
            this.three3pc = new System.Windows.Forms.Label();
            this.two3pc = new System.Windows.Forms.Label();
            this.two1pc = new System.Windows.Forms.Label();
            this.two2pc = new System.Windows.Forms.Label();
            this.two4pc = new System.Windows.Forms.Label();
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
            // five1h
            // 
            this.five1h.AutoSize = true;
            this.five1h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five1h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.five1h.Location = new System.Drawing.Point(51, 84);
            this.five1h.Name = "five1h";
            this.five1h.Size = new System.Drawing.Size(25, 25);
            this.five1h.TabIndex = 8;
            this.five1h.Text = "5";
            // 
            // four1h
            // 
            this.four1h.AutoSize = true;
            this.four1h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four1h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.four1h.Location = new System.Drawing.Point(51, 120);
            this.four1h.Name = "four1h";
            this.four1h.Size = new System.Drawing.Size(25, 25);
            this.four1h.TabIndex = 9;
            this.four1h.Text = "4";
            // 
            // four2h
            // 
            this.four2h.AutoSize = true;
            this.four2h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four2h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.four2h.Location = new System.Drawing.Point(51, 159);
            this.four2h.Name = "four2h";
            this.four2h.Size = new System.Drawing.Size(25, 25);
            this.four2h.TabIndex = 10;
            this.four2h.Text = "4";
            // 
            // three1h
            // 
            this.three1h.AutoSize = true;
            this.three1h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three1h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.three1h.Location = new System.Drawing.Point(51, 198);
            this.three1h.Name = "three1h";
            this.three1h.Size = new System.Drawing.Size(25, 25);
            this.three1h.TabIndex = 11;
            this.three1h.Text = "3";
            // 
            // three2h
            // 
            this.three2h.AutoSize = true;
            this.three2h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three2h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.three2h.Location = new System.Drawing.Point(51, 239);
            this.three2h.Name = "three2h";
            this.three2h.Size = new System.Drawing.Size(25, 25);
            this.three2h.TabIndex = 12;
            this.three2h.Text = "3";
            // 
            // two4h
            // 
            this.two4h.AutoSize = true;
            this.two4h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two4h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.two4h.Location = new System.Drawing.Point(51, 452);
            this.two4h.Name = "two4h";
            this.two4h.Size = new System.Drawing.Size(25, 25);
            this.two4h.TabIndex = 13;
            this.two4h.Text = "2";
            // 
            // three3h
            // 
            this.three3h.AutoSize = true;
            this.three3h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three3h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.three3h.Location = new System.Drawing.Point(51, 284);
            this.three3h.Name = "three3h";
            this.three3h.Size = new System.Drawing.Size(25, 25);
            this.three3h.TabIndex = 13;
            this.three3h.Text = "3";
            // 
            // two3h
            // 
            this.two3h.AutoSize = true;
            this.two3h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two3h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.two3h.Location = new System.Drawing.Point(51, 407);
            this.two3h.Name = "two3h";
            this.two3h.Size = new System.Drawing.Size(25, 25);
            this.two3h.TabIndex = 14;
            this.two3h.Text = "2";
            // 
            // two1h
            // 
            this.two1h.AutoSize = true;
            this.two1h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two1h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.two1h.Location = new System.Drawing.Point(51, 326);
            this.two1h.Name = "two1h";
            this.two1h.Size = new System.Drawing.Size(25, 25);
            this.two1h.TabIndex = 14;
            this.two1h.Text = "2";
            // 
            // two2h
            // 
            this.two2h.AutoSize = true;
            this.two2h.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two2h.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.two2h.Location = new System.Drawing.Point(51, 366);
            this.two2h.Name = "two2h";
            this.two2h.Size = new System.Drawing.Size(25, 25);
            this.two2h.TabIndex = 15;
            this.two2h.Text = "2";
            // 
            // five1pc
            // 
            this.five1pc.AutoSize = true;
            this.five1pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five1pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.five1pc.Location = new System.Drawing.Point(1117, 84);
            this.five1pc.Name = "five1pc";
            this.five1pc.Size = new System.Drawing.Size(25, 25);
            this.five1pc.TabIndex = 16;
            this.five1pc.Text = "5";
            // 
            // four1pc
            // 
            this.four1pc.AutoSize = true;
            this.four1pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four1pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.four1pc.Location = new System.Drawing.Point(1117, 120);
            this.four1pc.Name = "four1pc";
            this.four1pc.Size = new System.Drawing.Size(25, 25);
            this.four1pc.TabIndex = 17;
            this.four1pc.Text = "4";
            // 
            // four2pc
            // 
            this.four2pc.AutoSize = true;
            this.four2pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four2pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.four2pc.Location = new System.Drawing.Point(1117, 159);
            this.four2pc.Name = "four2pc";
            this.four2pc.Size = new System.Drawing.Size(25, 25);
            this.four2pc.TabIndex = 18;
            this.four2pc.Text = "4";
            // 
            // three1pc
            // 
            this.three1pc.AutoSize = true;
            this.three1pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three1pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.three1pc.Location = new System.Drawing.Point(1117, 198);
            this.three1pc.Name = "three1pc";
            this.three1pc.Size = new System.Drawing.Size(25, 25);
            this.three1pc.TabIndex = 19;
            this.three1pc.Text = "3";
            // 
            // three2pc
            // 
            this.three2pc.AutoSize = true;
            this.three2pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three2pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.three2pc.Location = new System.Drawing.Point(1117, 239);
            this.three2pc.Name = "three2pc";
            this.three2pc.Size = new System.Drawing.Size(25, 25);
            this.three2pc.TabIndex = 20;
            this.three2pc.Text = "3";
            // 
            // three3pc
            // 
            this.three3pc.AutoSize = true;
            this.three3pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three3pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.three3pc.Location = new System.Drawing.Point(1117, 284);
            this.three3pc.Name = "three3pc";
            this.three3pc.Size = new System.Drawing.Size(25, 25);
            this.three3pc.TabIndex = 21;
            this.three3pc.Text = "3";
            // 
            // two3pc
            // 
            this.two3pc.AutoSize = true;
            this.two3pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two3pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.two3pc.Location = new System.Drawing.Point(1117, 407);
            this.two3pc.Name = "two3pc";
            this.two3pc.Size = new System.Drawing.Size(25, 25);
            this.two3pc.TabIndex = 22;
            this.two3pc.Text = "2";
            // 
            // two1pc
            // 
            this.two1pc.AutoSize = true;
            this.two1pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two1pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.two1pc.Location = new System.Drawing.Point(1117, 326);
            this.two1pc.Name = "two1pc";
            this.two1pc.Size = new System.Drawing.Size(25, 25);
            this.two1pc.TabIndex = 22;
            this.two1pc.Text = "2";
            // 
            // two2pc
            // 
            this.two2pc.AutoSize = true;
            this.two2pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two2pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.two2pc.Location = new System.Drawing.Point(1117, 366);
            this.two2pc.Name = "two2pc";
            this.two2pc.Size = new System.Drawing.Size(25, 25);
            this.two2pc.TabIndex = 23;
            this.two2pc.Text = "2";
            // 
            // two4pc
            // 
            this.two4pc.AutoSize = true;
            this.two4pc.Font = new System.Drawing.Font("Footlight MT Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two4pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.two4pc.Location = new System.Drawing.Point(1117, 452);
            this.two4pc.Name = "two4pc";
            this.two4pc.Size = new System.Drawing.Size(25, 25);
            this.two4pc.TabIndex = 24;
            this.two4pc.Text = "2";
            // 
            // FleetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1203, 652);
            this.Controls.Add(this.two4pc);
            this.Controls.Add(this.two2pc);
            this.Controls.Add(this.two1pc);
            this.Controls.Add(this.two3pc);
            this.Controls.Add(this.three3pc);
            this.Controls.Add(this.three2pc);
            this.Controls.Add(this.three1pc);
            this.Controls.Add(this.four2pc);
            this.Controls.Add(this.four1pc);
            this.Controls.Add(this.five1pc);
            this.Controls.Add(this.two2h);
            this.Controls.Add(this.two1h);
            this.Controls.Add(this.two3h);
            this.Controls.Add(this.three3h);
            this.Controls.Add(this.two4h);
            this.Controls.Add(this.three2h);
            this.Controls.Add(this.three1h);
            this.Controls.Add(this.four2h);
            this.Controls.Add(this.four1h);
            this.Controls.Add(this.five1h);
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
        private System.Windows.Forms.Label five1h;
        private System.Windows.Forms.Label four1h;
        private System.Windows.Forms.Label four2h;
        private System.Windows.Forms.Label three1h;
        private System.Windows.Forms.Label three2h;
        private System.Windows.Forms.Label two4h;
        private System.Windows.Forms.Label three3h;
        private System.Windows.Forms.Label two3h;
        private System.Windows.Forms.Label two1h;
        private System.Windows.Forms.Label two2h;
        private System.Windows.Forms.Label five1pc;
        private System.Windows.Forms.Label four1pc;
        private System.Windows.Forms.Label four2pc;
        private System.Windows.Forms.Label three1pc;
        private System.Windows.Forms.Label three2pc;
        private System.Windows.Forms.Label three3pc;
        private System.Windows.Forms.Label two3pc;
        private System.Windows.Forms.Label two1pc;
        private System.Windows.Forms.Label two2pc;
        private System.Windows.Forms.Label two4pc;
    }
}

