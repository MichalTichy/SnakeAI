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

namespace SnakeGame
{
    public partial class DebugView : Form
    {
        private readonly SnakeDistanceSence distanceSence;
        private readonly ISnake _snake;

        public DebugView(SnakeDistanceSence distanceSence,ISnake snake)
        {
            this.distanceSence = distanceSence;
            _snake = snake;
            InitializeComponent();
            DataUpdateTimer.Start();
        }

        private void DataUpdateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                lCurrentHeading.Text = _snake.Heading.ToString();
                lIsAlive.Text = _snake.IsAlive.ToString();
                lScore.Text = _snake.BodyPossition.Count.ToString();

                LWallAhead.Text = distanceSence.DistanceToWallAhead().ToString();
                LWallBehind.Text = distanceSence.DistanceToWallBehind().ToString();
                LWallRight.Text = distanceSence.DistanceToWallRight().ToString();
                lWallLeft.Text = distanceSence.DistanceToWallLeft().ToString();

                lDistanceToFoodAhead.Text = distanceSence.DistanceToFoodAhead().ToString();
                lDistanceToFoodBehind.Text = distanceSence.DistanceToFoodBehind().ToString();
                lDistanceToFoodRight.Text = distanceSence.DistanceToFoodRight().ToString();
                lDistanceToFoodLeft.Text = distanceSence.DistanceToFoodLeft().ToString();

                lDistanceToBodyAhead.Text = distanceSence.DistanceToBodyAhead().ToString();
                lDistanceToBodyBehind.Text = distanceSence.DistanceToBodyBehind().ToString();
                lDistanceToBodyRight.Text = distanceSence.DistanceToBodyRight().ToString();
                lDistanceToBodyLeft.Text = distanceSence.DistanceToBodyLeft().ToString();
            }
            catch
            {
            }
        }
    }
}
