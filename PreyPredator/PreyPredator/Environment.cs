﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан инструментальным средством
//     В случае повторного создания кода изменения, внесенные в этот файл, будут потеряны.
// </auto-generated>
//------------------------------------------------------------------------------
namespace PreyPreadtor
{
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Text;

	/// <summary>
	/// Двумерная плоскость для агентов
	/// </summary>
	public class Environment
	{
		/// <summary>
		/// список ссылок на все агенты в среде
		/// </summary>
		public List<Agent> agents;

		/// <summary>
		/// количество итераций симуляции
		/// </summary>
		public int timer;

		/// <summary>
		/// ширина плоскости
		/// </summary>
		public readonly int width;

		/// <summary>
		/// высота плоскости
		/// </summary>
		public readonly int height;

		/// <summary>
		/// полотно для отрисовки агентов среды. 500*500px
		/// </summary>
		public readonly Graphics canvas;


        /// <summary>
        /// размер агентов
        /// </summary>
        private readonly int scale=30;



		/// <summary>
		/// одна итерация симуляции. Запускать таймером
		/// 
		/// </summary>
		public void RunSimulation()
		{
            var copy = agents.ToArray();
            foreach(var ag in copy)
            {
                if (ag is Grass)
                    ((Grass)ag).Behaviour();
                else if (ag is Prey)
                    ((Prey)ag).Behaviour();
                else if (ag is Predator)
                    ((Predator)ag).Behaviour();
            }

            drawEnvironment();

            timer++;
		}

		/// <summary>
		/// создание среды на полотне. Ширина и высота опредлеются из размеров полотна
		/// </summary>
		public Environment(Graphics canvas)
		{
            agents = new List<Agent>();
            timer = 0;

            width = (int)(canvas.VisibleClipBounds.Width / scale);
            height = (int)(canvas.VisibleClipBounds.Height / scale);

            this.canvas = canvas;
		}

		/// <summary>
		/// метод прорисовка агентов на полотне, после действий
		/// </summary>
		private void drawEnvironment()
		{
            canvas.Clear(Color.Brown);

            foreach (var ag in agents)
            {
                if ((ag is Grass))
                    canvas.FillRectangle(new SolidBrush(ag.color), scale * ag.x, scale * ag.y, scale, scale);
            }

			foreach(var ag in agents)
            {
                if (!(ag is Grass))
                    canvas.FillRectangle(new SolidBrush(ag.color), scale * ag.x, scale * ag.y, scale, scale);
            }
		}

		public Environment()
		{
            agents = new List<Agent>();
		}


        /// <summary>
        /// создает заданное количество травы, травоядных, хищников
        /// </summary>
        /// <param name="grasses">колво травы</param>
        /// <param name="preys">колво травоядных</param>
        /// <param name="predators">колво хищников</param>
        public void initAgents(int grasses, int preys, int predators)
        {
            Random rand=new Random();

            for (int i = 0; i < grasses; i++)
            {
                var ag = new Grass(this, rand.Next(10,15));
                agents.Add(ag);
            }

            for (int i = 0; i < preys; i++)
            {
                var ag = new Prey(this, rand.Next(40, 55));
                agents.Add(ag);
            }

            for (int i = 0; i < predators; i++)
            {
                var ag = new Predator(this, rand.Next(40, 55));
                agents.Add(ag);
            }

        }

	}
}
