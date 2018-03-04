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
        protected readonly bool debug;

        private readonly IWorld _world;
        private readonly ICollection<ISnake> _snakes;
        private readonly int? _maxNumberOfSteps;
        public const int pointSize = 10;

        public int NumberOfElapsedSteps { get; protected set; } = 0;
        public GameVisualization(IWorld world,ICollection<ISnake> snakes, int? maxNumberOfSteps = null ,bool debug = false,int speed=250)
        {
            _world = world;
            _snakes = snakes;
            _maxNumberOfSteps = maxNumberOfSteps;
            this.debug = debug;

            InitializeComponent();

            GameUpdate.Interval = speed;

            InitGameBoard();
        }

        public bool IsRunning => GameUpdate.Enabled;

        private void InitGameBoard()
        {
            Size = new Size(_world.Size.Width * pointSize, _world.Size.Height* pointSize);
        }

        private void GameUpdate_Tick(object sender, EventArgs e)
        {
            if (_maxNumberOfSteps.HasValue && NumberOfElapsedSteps>=_maxNumberOfSteps)
            {
                GameUpdate.Stop();
                return;
            }

            if (!_snakes.Any(t=>t.IsAlive))
            {
                GameUpdate.Stop();
            }
            _world.PerformGameStep();
            NumberOfElapsedSteps++;
            Refresh();
        }

        private void DrawWorld()
        {
            var graphics = CreateGraphics();
            
            graphics.Clear(Color.Black);

            DrawFood(graphics);

            foreach (var snake in _snakes)
                DrawSnake(graphics, snake);

            if (debug)
            {
                DrawGrid(graphics);
            }
            DrawBorder(graphics);
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

        private void DrawGrid(Graphics graphics)
        {
            for (int i = 0; i < _world.Size.Height; i++)
            {
                var pen=new Pen(Color.White);
                graphics.DrawLine(pen,new Point(0,i*pointSize),new Point(_world.Size.Width*pointSize,i*pointSize) );
            }

            for (int i = 0; i < _world.Size.Width; i++)
            {
                var pen = new Pen(Color.White);
                graphics.DrawLine(pen, new Point(i * pointSize,0), new Point(i * pointSize,_world.Size.Height*pointSize));
            }
        }

        private void DrawBorder(Graphics graphics)
        {
            var pen=new Pen(Color.White);
            graphics.DrawRectangle(pen,0,0,_world.Size.Width*pointSize,_world.Size.Height*pointSize);
        }

        private Rectangle TransferPointToRectangle(Location location)
        {
            return new Rectangle(location.X*pointSize,location.Y*pointSize,pointSize, pointSize);
        }

        public void Start()
        {
            GameUpdate.Start();
        }

        public void Stop()
        {
            GameUpdate.Stop();
        }

        private void GameVisualization_Paint(object sender, PaintEventArgs e)
        {
            DrawWorld();
        }
    }
}
