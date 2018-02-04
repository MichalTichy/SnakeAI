namespace SnakeGame
{
    partial class GameVisualization
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
            this.GameUpdate = new System.Windows.Forms.Timer(this.components);
            this.butStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameUpdate
            // 
            this.GameUpdate.Interval = 250;
            this.GameUpdate.Tick += new System.EventHandler(this.GameUpdate_Tick);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(12, 98);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(259, 23);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // GameVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.butStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameVisualization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameVisualization";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameVisualization_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameUpdate;
        private System.Windows.Forms.Button butStart;
    }
}