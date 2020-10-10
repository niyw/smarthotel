using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHotel.Common
{
    public abstract class Worker
    {
        public string Name { get; set; }

        public abstract double TotalReward { get; }
        public abstract double Hours { get; }
        public double Salary => TotalReward / Hours;
        public List<string> Tools { get; set; }
    }

    public class Plumber : Worker
    {
        public Plumber()
        {
            Tools = new List<string>()
            {
                "螺丝刀",
                "扳子",
                "钳子"
            };
        }
        public override double TotalReward => 200;
        public override double Hours => 3;
    }
    public class Programmer : Worker
    {
        public override double TotalReward => 1000;
        public override double Hours => 3.5;
    }

    public class WorkerFactory
    {
        public Worker Create(string name, bool isProgrammer = false)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (isProgrammer)
            {
                return new Programmer { Name = name };
            }
            return new Plumber { Name = name };
        }
    }
}
