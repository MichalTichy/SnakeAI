using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeBase;
using SnakeBase.Snake;
using SnakeBase.World;
using SnakeUserControlled;

namespace SnakeGame
{
    public partial class Menu : Form
    {
        public IWorld World { get; set; }


        public Menu()
        {
            InitializeComponent();
        }

        private void butStartUserControlled_Click(object sender, EventArgs e)
        {
            var size = new Size((int) worldSizeNumericUpDown.Value, (int) worldSizeNumericUpDown.Value);
            World=new World(size);

            var snake = new UserControlledSnake();
            snake.Born(World,new Location(0,0));
            var snakes = new List<ISnake>(){snake};
            World.AddSnakes(snakes);
            
            var display=new GameVisualization(World,snakes,null,chDebug.Checked);
            display.Show();

            var controlsPossition=new Point(display.Location.X,display.Location.Y+display.Size.Height);
            var controls=new SnakeHandControl(controlsPossition,snake,display);
            controls.Show();

            if (chDebug.Checked)
            {
                var debugger=new DebugView(new SnakeDistanceSence(World,snake), snake);
                debugger.Show();
            }
        }

        private void PopulationSize_ValueChanged(object sender, EventArgs e)
        {
            int rows, columns;
            var maxCount = Evolution.CalcMaxNumberOfAiInstancesThatCanBeDisplayed(out rows, out columns);
            lSizeWarning.Visible = chShow.Checked && numPopulationSize.Value > maxCount;
        }

        private async void butAiStart_Click(object sender, EventArgs e)
        {
            var evolution=new Evolution((int) numPopulationSize.Value);
            var i = 0;
            while (true)
            {
                await evolution.SimulateGeneration(chShow.Checked);
                lAverageScore.Text = evolution.CurrentPopulation.Snakes.Average(t => t.CalcFitness()).ToString();
                lGeneration.Text = i++.ToString();
                await Task.Delay(100);
                evolution.NextGeneration();
            }
        }
    }
}
