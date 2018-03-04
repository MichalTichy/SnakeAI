using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnakeAI.Evolution;
using SnakeBase;
using SnakeBase.Snake;
using SnakeBase.World;

namespace SnakeGame
{
    public class Evolution
    {
        protected List<Population> _populations=new List<Population>();
        public IReadOnlyList<Population> Populations => _populations.AsReadOnly();
        public Population CurrentPopulation => _populations.LastOrDefault();
        public Evolution(Population initialPopulation)
        {
            _populations.Add(initialPopulation);
        }

        public Evolution(int populationSize)
        {
            _populations.Add(new Population(populationSize,AiSimulationSize));
        }

        protected static Size AiSimulationSize => new Size(30,30);
         
        protected const int MaxNumberOfSteps = 1000;
        public static int CalcMaxNumberOfAiInstancesThatCanBeDisplayed(out int rows, out int columns)
        {
            var bounds = Screen.PrimaryScreen.Bounds;
            rows = bounds.Height / (AiSimulationSize.Height*GameVisualization.pointSize);
            columns = bounds.Width / (AiSimulationSize.Width*GameVisualization.pointSize);

            return rows * columns;
        }

        protected List<GameVisualization> VisualizeCurrentPopulation()
        {
            int rows, columns;

            var maximumNumberOfDisplayedSpecies = Evolution.CalcMaxNumberOfAiInstancesThatCanBeDisplayed(out rows, out columns);

            int currentRow = 0;
            int currentColumns = 0;

            var visualizations=new List<GameVisualization>();
            var i = 0;
            while (i<CurrentPopulation.Snakes.Count && i<maximumNumberOfDisplayedSpecies)
            {
                var snake = CurrentPopulation.Snakes.Skip(i).Take(1).First();
                var world = new World(AiSimulationSize);
                world.AddSnakes(new[] { snake });
                snake.Born(world,new Location(3,3));
                var gameVisualization = new GameVisualization(world,new []{snake},Evolution.MaxNumberOfSteps,speed:10);

                gameVisualization.Location=new Point((i%columns)*AiSimulationSize.Width*GameVisualization.pointSize,(i/columns)*AiSimulationSize.Height * GameVisualization.pointSize);
                gameVisualization.Show();
                visualizations.Add(gameVisualization);
                i++;
            }

            Task.Delay(1000);

            foreach (var gameVisualization in visualizations)
            {
                gameVisualization.Start();
            }

            return visualizations;
        }



        public async Task SimulateGeneration(bool showVisualizations)
        {
            var sw = new Stopwatch();
            sw.Start();
            var visualizations = new List<GameVisualization>();
            if (showVisualizations)
            {
                visualizations=VisualizeCurrentPopulation();
            }

            var nonDisplayed = CurrentPopulation.Snakes.Skip(visualizations.Count);

            var i = 0;

            var nonVisualizedWorld=new List<IWorld>();
            foreach (var snake in nonDisplayed)
            {
                var world = new World(AiSimulationSize);
                snake.Born(world,new Location(3,3));
                world.AddSnakes(new []{snake});
                nonVisualizedWorld.Add(world);
            }

            while (CurrentPopulation.Snakes.Skip(visualizations.Count).Any(t => t.IsAlive) && i++<=MaxNumberOfSteps)
            {
                foreach (var world in nonVisualizedWorld)
                {
                    world.PerformGameStep();
                }
            }

            while (visualizations.Any(t=>t.IsRunning))
            {
                await Task.Delay(10);
            }

            foreach (var gameVisualization in visualizations)
            {
                gameVisualization.Close();
            }
        }

        public void NextGeneration()
        {
            _populations.Add(CurrentPopulation.Evolve());
        }
    }
}