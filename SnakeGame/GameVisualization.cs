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

namespace SnakeGame
{
    public partial class GameVisualization : Form
    {
        private readonly IWorld _world;
        private readonly ICollection<ISnake> _snakes;
        private const int pointSize = 10;
        public GameVisualization(IWorld world,ICollection<ISnake> snakes)
        {
            _world = world;
            _snakes = snakes;
            InitializeComponent();

            InitGameBoard();
        }

        private void InitGameBoard()
        {
            Size = new Size(_world.Size.Width * pointSize, _world.Size.Height* pointSize);
        }

        private void GameUpdate_Tick(object sender, EventArgs e)
        {
            _world.PerformGameStep();
            Refresh();
        }

        private void DrawWorld()
        {
            var graphics = CreateGraphics();
            
            graphics.Clear(Color.Black);

            DrawFood(graphics);

            foreach (var snake in _snakes)
                DrawSnake(graphics, snake);
        }

        private void DrawSnake(Graphics graphics,ISnake snake)
        {
            var headBrush = new SolidBrush(Color.GreenYellow);
            graphics.FillRectangle(headBrush,TransferPointToRectangle(snake.HeadPossition));

            var bodyBrush = new SolidBrush(Color.LimeGreen);
            if (snake.BodyPossition.Any())
            {
                var body = snake.BodyPossition.Select(TransferPointToRectangle).ToArray();
                graphics.FillRectangles(bodyBrush, body);
            }
        }

        private void DrawFood(Graphics graphics)
        {
            var brush=new SolidBrush(Color.Red);
            graphics.FillRectangle(brush,TransferPointToRectangle(_world.FoodPossition));
        }

        private Rectangle TransferPointToRectangle(Location location)
        {
            return new Rectangle(location.X*pointSize,location.Y*pointSize,pointSize, pointSize);
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            butStart.Visible = false;
            GameUpdate.Start();
        }

        private void GameVisualization_Paint(object sender, PaintEventArgs e)
        {
            DrawWorld();
        }
    }
}
