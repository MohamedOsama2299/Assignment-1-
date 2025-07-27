using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__1__
{
    internal class Car
    {
            private string model;
            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            private int speed;

            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            private int id;
            public int Id
            {
                get { return id; }
                set
                { id = value; }
            }


            //CLR ill generate a parameterless constructor constructor
            //this constructor do nothing
            //public Car()
            //{

            //}
            public override string ToString()
            {
                return $"ID {Id}::Spead: {speed}::Model {Model}";
            }

            public Car(int id, int speed, string model)
            {
                Id = id;
                Speed = speed;
                Model = model;
            }
        }
    }
