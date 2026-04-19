using Langston_s_Ant.Domain;
using LangstonsAnt.Domain;
using System;
using System.Collections.Generic;

namespace Langston_s_Ant.Application
{
    public class Simulation
    {
        private readonly IGrid grid;
        private readonly AntRules rules;

        public List<Ant> Ants { get; }
        public long Steps { get; private set; }

        public Simulation(IGrid grid, AntRules rules, int antCount)
        {
            this.grid = grid;
            this.rules = rules;

            Ants = new List<Ant>();
            var rand = new Random();

            int centerX = grid.Width / 2;
            int centerY = grid.Height / 2;

            for (int i = 0; i < antCount; i++)
            {
                //prima furnica porneste din centru
                //restul la cateva celule in jurul centrului
                int x = centerX + (i == 0 ? 0 : rand.Next(-5, 6));
                int y = centerY + (i == 0 ? 0 : rand.Next(-5, 6));
                Ants.Add(new Ant(x, y));
            }
        }

        public int GetState(int x, int y) => grid.GetState(x, y);

        public void Step()
        {
            foreach (var ant in Ants)
                StepAnt(ant);

            Steps++;
        }

        private void StepAnt(Ant ant)
        {
            int state = grid.GetState(ant.X, ant.Y);
            char turn = rules.GetTurn(state);

            if (turn == 'R') ant.TurnRight();
            else ant.TurnLeft();

            int newState = (state + 1) % rules.StatesCount;
            grid.SetState(ant.X, ant.Y, newState);

            ant.Move();
            ant.Wrap(grid.Width, grid.Height);
        }
    }
}
