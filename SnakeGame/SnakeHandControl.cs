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
    public partial class SnakeHandControl : Form
    {
        protected readonly GameVisualization _gameVisualization;
        protected UserControlledSnakeBrain SnakeBrain;

        public SnakeHandControl(Point possition,ISnake snake,GameVisualization gameVisualization)
        {
            if (!(snake.Head.Brain is UserControlledSnakeBrain brain))
                throw new Exception($"Only snakes with {nameof(UserControlledSnakeBrain)} brain can be controlled.");
            _gameVisualization = gameVisualization;

            SnakeBrain = brain;

            InitializeComponent();

            Location = possition;
        }

        public void GoUp()
        {
            ResetButtonColors();
            butUp.BackColor=Color.GreenYellow;
            SnakeBrain.GoUp();
        }
        public void GoDown()
        {
            ResetButtonColors();
            butDown.BackColor = Color.GreenYellow;
            SnakeBrain.GoDown();;
        }
        public void GoRight()
        {
            ResetButtonColors();
            butRight.BackColor = Color.GreenYellow;
            SnakeBrain.GoRight();
        }
        public void GoLeft()
        {
            ResetButtonColors();
            butLeft.BackColor = Color.GreenYellow;
            SnakeBrain.GoLeft();
        }

        private void butUp_Click(object sender, EventArgs e)
        {
            GoUp();
        }

        private void butDown_Click(object sender, EventArgs e)
        {
            GoDown();
        }

        private void butLeft_Click(object sender, EventArgs e)
        {
            GoLeft();
        }

        private void butRight_Click(object sender, EventArgs e)
        {
            GoRight();
        }

        private void ResetButtonColors()
        {
            butUp.ResetBackColor();
            butDown.ResetBackColor();
            butRight.ResetBackColor();
            butLeft.ResetBackColor();
        }

        private void SnakeHandControl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    GoUp();
                    break;
                case Keys.S:
                    GoDown();
                    break;
                case Keys.A:
                    GoLeft();
                    break;
                case Keys.D:
                    GoRight();
                    break;
            }
        }

        private void butStartPause_Click(object sender, EventArgs e)
        {
            if (!_gameVisualization.IsRunning)
                _gameVisualization.Start();
            else
                _gameVisualization.Stop();
        }
    }
}
