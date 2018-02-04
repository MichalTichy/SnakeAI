namespace SnakeGame
{
    partial class Menu
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
            this.worldSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.butStartUserControlled = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worldSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // worldSizeNumericUpDown
            // 
            this.worldSizeNumericUpDown.Location = new System.Drawing.Point(220, 12);
            this.worldSizeNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.worldSizeNumericUpDown.Name = "worldSizeNumericUpDown";
            this.worldSizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.worldSizeNumericUpDown.TabIndex = 0;
            this.worldSizeNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "World size";
            // 
            // butStartUserControlled
            // 
            this.butStartUserControlled.Location = new System.Drawing.Point(16, 51);
            this.butStartUserControlled.Name = "butStartUserControlled";
            this.butStartUserControlled.Size = new System.Drawing.Size(324, 23);
            this.butStartUserControlled.TabIndex = 2;
            this.butStartUserControlled.Text = "User controlled";
            this.butStartUserControlled.UseVisualStyleBackColor = true;
            this.butStartUserControlled.Click += new System.EventHandler(this.butStartUserControlled_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 118);
            this.Controls.Add(this.butStartUserControlled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.worldSizeNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.worldSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown worldSizeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butStartUserControlled;
    }
}

