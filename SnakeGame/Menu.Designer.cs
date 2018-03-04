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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butAiStart = new System.Windows.Forms.Button();
            this.lSizeWarning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chDebug = new System.Windows.Forms.CheckBox();
            this.butStartUserControlled = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.worldSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.chShow = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lAverageScore = new System.Windows.Forms.Label();
            this.lGeneration = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 165);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lGeneration);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lAverageScore);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chShow);
            this.tabPage1.Controls.Add(this.butAiStart);
            this.tabPage1.Controls.Add(this.lSizeWarning);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numPopulationSize);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // butAiStart
            // 
            this.butAiStart.Location = new System.Drawing.Point(9, 60);
            this.butAiStart.Name = "butAiStart";
            this.butAiStart.Size = new System.Drawing.Size(324, 23);
            this.butAiStart.TabIndex = 7;
            this.butAiStart.Text = "Start";
            this.butAiStart.UseVisualStyleBackColor = true;
            this.butAiStart.Click += new System.EventHandler(this.butAiStart_Click);
            // 
            // lSizeWarning
            // 
            this.lSizeWarning.AutoSize = true;
            this.lSizeWarning.ForeColor = System.Drawing.Color.Red;
            this.lSizeWarning.Location = new System.Drawing.Point(6, 29);
            this.lSizeWarning.Name = "lSizeWarning";
            this.lSizeWarning.Size = new System.Drawing.Size(321, 13);
            this.lSizeWarning.TabIndex = 2;
            this.lSizeWarning.Text = "Given size is too big for current screen. Only same will be displayed";
            this.lSizeWarning.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Population size";
            // 
            // numPopulationSize
            // 
            this.numPopulationSize.Location = new System.Drawing.Point(214, 6);
            this.numPopulationSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPopulationSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationSize.Name = "numPopulationSize";
            this.numPopulationSize.Size = new System.Drawing.Size(120, 20);
            this.numPopulationSize.TabIndex = 0;
            this.numPopulationSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopulationSize.ValueChanged += new System.EventHandler(this.PopulationSize_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chDebug);
            this.tabPage2.Controls.Add(this.butStartUserControlled);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.worldSizeNumericUpDown);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Controlled";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chDebug
            // 
            this.chDebug.AutoSize = true;
            this.chDebug.Location = new System.Drawing.Point(277, 76);
            this.chDebug.Name = "chDebug";
            this.chDebug.Size = new System.Drawing.Size(58, 17);
            this.chDebug.TabIndex = 7;
            this.chDebug.Text = "Debug";
            this.chDebug.UseVisualStyleBackColor = true;
            // 
            // butStartUserControlled
            // 
            this.butStartUserControlled.Location = new System.Drawing.Point(11, 38);
            this.butStartUserControlled.Name = "butStartUserControlled";
            this.butStartUserControlled.Size = new System.Drawing.Size(324, 23);
            this.butStartUserControlled.TabIndex = 6;
            this.butStartUserControlled.Text = "Start";
            this.butStartUserControlled.UseVisualStyleBackColor = true;
            this.butStartUserControlled.Click += new System.EventHandler(this.butStartUserControlled_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "World size";
            // 
            // worldSizeNumericUpDown
            // 
            this.worldSizeNumericUpDown.Location = new System.Drawing.Point(214, 6);
            this.worldSizeNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.worldSizeNumericUpDown.Name = "worldSizeNumericUpDown";
            this.worldSizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.worldSizeNumericUpDown.TabIndex = 4;
            this.worldSizeNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // chShow
            // 
            this.chShow.AutoSize = true;
            this.chShow.Location = new System.Drawing.Point(9, 89);
            this.chShow.Name = "chShow";
            this.chShow.Size = new System.Drawing.Size(113, 17);
            this.chShow.TabIndex = 8;
            this.chShow.Text = "Show visualization";
            this.chShow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Average score:";
            // 
            // lAverageScore
            // 
            this.lAverageScore.AutoSize = true;
            this.lAverageScore.Location = new System.Drawing.Point(87, 109);
            this.lAverageScore.Name = "lAverageScore";
            this.lAverageScore.Size = new System.Drawing.Size(0, 13);
            this.lAverageScore.TabIndex = 10;
            // 
            // lGeneration
            // 
            this.lGeneration.AutoSize = true;
            this.lGeneration.Location = new System.Drawing.Point(248, 109);
            this.lGeneration.Name = "lGeneration";
            this.lGeneration.Size = new System.Drawing.Size(0, 13);
            this.lGeneration.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Generation:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 170);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Menu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulationSize)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chDebug;
        private System.Windows.Forms.Button butStartUserControlled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown worldSizeNumericUpDown;
        private System.Windows.Forms.Label lSizeWarning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPopulationSize;
        private System.Windows.Forms.Button butAiStart;
        private System.Windows.Forms.Label lAverageScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chShow;
        private System.Windows.Forms.Label lGeneration;
        private System.Windows.Forms.Label label5;
    }
}

