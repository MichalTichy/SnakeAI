using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            var snakes = new List<ISnake>(){new UserControlledSnake(World,new SnakeBase.Location(10,10))};
            World.AddSnakes(snakes);
            
            var display=new GameVisualization(World,snakes);
            display.Show();

            var controlsPossition=new Point(display.Location.X,display.Location.Y+display.Size.Height);
            var controls=new SnakeHandControl(controlsPossition,snakes.First());
            controls.Show();
        }
    }
}
