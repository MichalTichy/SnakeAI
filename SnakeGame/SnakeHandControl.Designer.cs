namespace SnakeGame
{
    partial class SnakeHandControl
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
            this.butUp = new System.Windows.Forms.Button();
            this.butDown = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butUp
            // 
            this.butUp.Location = new System.Drawing.Point(12, 12);
            this.butUp.Name = "butUp";
            this.butUp.Size = new System.Drawing.Size(120, 50);
            this.butUp.TabIndex = 0;
            this.butUp.Text = "UP";
            this.butUp.UseVisualStyleBackColor = true;
            this.butUp.Click += new System.EventHandler(this.butUp_Click);
            // 
            // butDown
            // 
            this.butDown.Location = new System.Drawing.Point(12, 124);
            this.butDown.Name = "butDown";
            this.butDown.Size = new System.Drawing.Size(120, 50);
            this.butDown.TabIndex = 1;
            this.butDown.Text = "DOWN";
            this.butDown.UseVisualStyleBackColor = true;
            this.butDown.Click += new System.EventHandler(this.butDown_Click);
            // 
            // butLeft
            // 
            this.butLeft.Location = new System.Drawing.Point(12, 68);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(50, 50);
            this.butLeft.TabIndex = 2;
            this.butLeft.Text = "Left";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // butRight
            // 
            this.butRight.Location = new System.Drawing.Point(82, 68);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(50, 50);
            this.butRight.TabIndex = 3;
            this.butRight.Text = "Right";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // SnakeHandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 191);
            this.Controls.Add(this.butRight);
            this.Controls.Add(this.butLeft);
            this.Controls.Add(this.butDown);
            this.Controls.Add(this.butUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SnakeHandControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SnakeHandControl";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeHandControl_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butUp;
        private System.Windows.Forms.Button butDown;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butRight;
    }
}