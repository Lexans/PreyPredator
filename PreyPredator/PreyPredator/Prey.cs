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
    /// травоядное
    /// </summary>
    public sealed class Prey : Agent
    {
        public Prey(Environment environment, int satiety)
            : base(environment, satiety, Color.White)
        {
        }

        public void Behaviour()
        {

            var nearAg = nearAgents(2.5);
            if (nearAg.Count > 0) //находим еду
            {
                foreach (var ag in nearAg)
                    if ((ag is Grass) && ag.satiety > 1)
                    {
                        MoveTo(ag.x, ag.y);
                        Eat(ag);
                        return;
                    }
            }
            MoveRand();

            //смерть
            if (satiety < 0)
            {
                environment.agents.Remove(this);
            }

            //размножение
            if (satiety > 80)
            {
                var ag = new Prey(environment, rand.Next(40, 55));
                ag.x = x;
                ag.y = y;
                environment.agents.Add(ag);
                satiety -= 40;
            }
        }

    }
}

