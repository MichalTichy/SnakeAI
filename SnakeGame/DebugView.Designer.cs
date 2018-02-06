namespace SnakeGame
{
    partial class DebugView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LWallAhead = new System.Windows.Forms.Label();
            this.LWallBehind = new System.Windows.Forms.Label();
            this.LWallRight = new System.Windows.Forms.Label();
            this.lWallLeft = new System.Windows.Forms.Label();
            this.DataUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lCurrentHeading = new System.Windows.Forms.Label();
            this.lDistanceToFoodLeft = new System.Windows.Forms.Label();
            this.lDistanceToFoodRight = new System.Windows.Forms.Label();
            this.lDistanceToFoodBehind = new System.Windows.Forms.Label();
            this.lDistanceToFoodAhead = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lIsAlive = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lDistanceToBodyLeft = new System.Windows.Forms.Label();
            this.lDistanceToBodyRight = new System.Windows.Forms.Label();
            this.lDistanceToBodyBehind = new System.Windows.Forms.Label();
            this.lDistanceToBodyAhead = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DistanceFromWall - AHEAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DistanceFromWall - BEHIND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DistanceFromWall - RIGHT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DistanceFromWall - LEFT";
            // 
            // LWallAhead
            // 
            this.LWallAhead.Location = new System.Drawing.Point(184, 3);
            this.LWallAhead.Name = "LWallAhead";
            this.LWallAhead.Size = new System.Drawing.Size(100, 23);
            this.LWallAhead.TabIndex = 4;
            this.LWallAhead.Text = "0";
            // 
            // LWallBehind
            // 
            this.LWallBehind.Location = new System.Drawing.Point(184, 26);
            this.LWallBehind.Name = "LWallBehind";
            this.LWallBehind.Size = new System.Drawing.Size(100, 23);
            this.LWallBehind.TabIndex = 5;
            this.LWallBehind.Text = "0";
            // 
            // LWallRight
            // 
            this.LWallRight.Location = new System.Drawing.Point(184, 49);
            this.LWallRight.Name = "LWallRight";
            this.LWallRight.Size = new System.Drawing.Size(100, 23);
            this.LWallRight.TabIndex = 6;
            this.LWallRight.Text = "0";
            // 
            // lWallLeft
            // 
            this.lWallLeft.Location = new System.Drawing.Point(184, 72);
            this.lWallLeft.Name = "lWallLeft";
            this.lWallLeft.Size = new System.Drawing.Size(100, 23);
            this.lWallLeft.TabIndex = 7;
            this.lWallLeft.Text = "0";
            // 
            // DataUpdateTimer
            // 
            this.DataUpdateTimer.Tick += new System.EventHandler(this.DataUpdateTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current heading";
            // 
            // lCurrentHeading
            // 
            this.lCurrentHeading.Location = new System.Drawing.Point(488, 3);
            this.lCurrentHeading.Name = "lCurrentHeading";
            this.lCurrentHeading.Size = new System.Drawing.Size(100, 23);
            this.lCurrentHeading.TabIndex = 9;
            // 
            // lDistanceToFoodLeft
            // 
            this.lDistanceToFoodLeft.Location = new System.Drawing.Point(184, 190);
            this.lDistanceToFoodLeft.Name = "lDistanceToFoodLeft";
            this.lDistanceToFoodLeft.Size = new System.Drawing.Size(100, 23);
            this.lDistanceToFoodLeft.TabIndex = 17;
            this.lDistanceToFoodLeft.Text = "0";
            // 
            // lDistanceToFoodRight
            // 
            this.lDistanceToFoodRight.Location = new System.Drawing.Point(184, 167);
            this.lDistanceToFoodRight.Name = "lDistanceToFoodRight";
            this.lDistanceToFoodRight.Size = new System.Drawing.Size(100, 23);
            this.lDistanceToFoodRight.TabIndex = 16;
            this.lDistanceToFoodRight.Text = "0";
            // 
            // lDistanceToFoodBehind
            // 
            this.lDistanceToFoodBehind.Location = new System.Drawing.Point(184, 144);
            this.lDistanceToFoodBehind.Name = "lDistanceToFoodBehind";
            this.lDistanceToFoodBehind.Size = new System.Drawing.Size(100, 23);
            this.lDistanceToFoodBehind.TabIndex = 15;
            this.lDistanceToFoodBehind.Text = "0";
            // 
            // lDistanceToFoodAhead
            // 
            this.lDistanceToFoodAhead.Location = new System.Drawing.Point(184, 121);
            this.lDistanceToFoodAhead.Name = "lDistanceToFoodAhead";
            this.lDistanceToFoodAhead.Size = new System.Drawing.Size(100, 23);
            this.lDistanceToFoodAhead.TabIndex = 14;
            this.lDistanceToFoodAhead.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "DistanceToFood - LEFT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "DistanceToFood - RIGHT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "DistanceToFood - BEHIND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "DistanceToFood - AHEAD";
            // 
            // lIsAlive
            // 
            this.lIsAlive.Location = new System.Drawing.Point(488, 26);
            this.lIsAlive.Name = "lIsAlive";
            this.lIsAlive.Size = new System.Drawing.Size(100, 23);
            this.lIsAlive.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Is alive";
            // 
            // lScore
            // 
            this.lScore.Location = new System.Drawing.Point(488, 49);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(100, 23);
            this.lScore.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Score";
            // 
            // lDistanceToBodyLeft
            // 
            this.lDistanceToBodyLeft.Location = new System.Drawing.Point(184, 303);
            this.lDistanceToBodyLeft.Name = "lDistanceToBodyLeft";
            this.lDistanceToBodyLeft.Size = new System.Drawing.Size(100, 23);
            this.lDistanceToBodyLeft.TabIndex = 29;
            this.lDistanceToBodyLeft.Text = "0";
            // 
            // lDistanceToBodyRight
            // 
            this.lDistanceToBodyRight.Location = new System.Drawing.Point(184, 280);
            this.lDistanceToBodyRight.Name = "lDistanceToBodyRight";
            this.lDistanceToBodyRight.Size = new System.Drawing.Size(100, 23);
            this.lDistanceToBodyRight.TabIndex = 28;
            this.lDistanceToBodyRight.Text = "0";
            // 
            // lDistanceToBodyBehind
            // 
            this.lDistanceToBodyBehind.Location = new System.Drawing.Point(184, 257);
            this.lDistanceToBodyBehind.Name = "lDistanceToBodyBehind";
            this.lDistanceToBodyBehind.Size = new System.Drawing.Size(100, 23);
            this.lDistanceToBodyBehind.TabIndex = 27;
            this.lDistanceToBodyBehind.Text = "0";
            // 
            // lDistanceToBodyAhead
            // 
            this.lDistanceToBodyAhead.Location = new System.Drawing.Point(184, 234);
            this.lDistanceToBodyAhead.Name = "lDistanceToBodyAhead";
            this.lDistanceToBodyAhead.Size = new System.Drawing.Size(100, 23);
            this.lDistanceToBodyAhead.TabIndex = 26;
            this.lDistanceToBodyAhead.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "DistanceToBodyPart - LEFT";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "DistanceToBodyPart - RIGHT";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "DistanceToBodyPart - BEHIND";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 234);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "DistanceToBodyPart - AHEAD";
            // 
            // DebugView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 409);
            this.Controls.Add(this.lDistanceToBodyLeft);
            this.Controls.Add(this.lDistanceToBodyRight);
            this.Controls.Add(this.lDistanceToBodyBehind);
            this.Controls.Add(this.lDistanceToBodyAhead);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lIsAlive);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lDistanceToFoodLeft);
            this.Controls.Add(this.lDistanceToFoodRight);
            this.Controls.Add(this.lDistanceToFoodBehind);
            this.Controls.Add(this.lDistanceToFoodAhead);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lCurrentHeading);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lWallLeft);
            this.Controls.Add(this.LWallRight);
            this.Controls.Add(this.LWallBehind);
            this.Controls.Add(this.LWallAhead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DebugView";
            this.Text = "DebugView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LWallAhead;
        private System.Windows.Forms.Label LWallBehind;
        private System.Windows.Forms.Label LWallRight;
        private System.Windows.Forms.Label lWallLeft;
        private System.Windows.Forms.Timer DataUpdateTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lCurrentHeading;
        private System.Windows.Forms.Label lDistanceToFoodLeft;
        private System.Windows.Forms.Label lDistanceToFoodRight;
        private System.Windows.Forms.Label lDistanceToFoodBehind;
        private System.Windows.Forms.Label lDistanceToFoodAhead;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lIsAlive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lDistanceToBodyLeft;
        private System.Windows.Forms.Label lDistanceToBodyRight;
        private System.Windows.Forms.Label lDistanceToBodyBehind;
        private System.Windows.Forms.Label lDistanceToBodyAhead;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}