using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule12
{
    public abstract class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Position { get; set; }

        public event EventHandler Finished;

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
            Position = 0;
        }

        public void Move()
        {
            Position += Speed;

            Console.WriteLine($"{Model} находится на позиции {Position}");

            if (Position >= 100)
            {
                OnFinished();
            }
        }

        protected virtual void OnFinished()
        {
            Finished?.Invoke(this, EventArgs.Empty);
        }

        public abstract void GoToStart();
    }
}
