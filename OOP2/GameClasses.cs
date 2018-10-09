using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class GameClasses
    {
        public class Thing
        {
            private string _name;
            public string Name { get => _name; set => _name = value; }

            private string _discription;
            public string Discription { get => _discription; set => _discription = value; }

            public Thing(string aName, string aDiscription)
            {
                _name = aName;
                _discription = aDiscription;
            }


        }
        public class Treasure : Thing
        {
            private double _value;

            public Treasure(string aName, string aDiscription, double aValue)
            : base(aName, aDiscription)
            {
                _value = aValue;
            }

            public double Value { get => _value; set => _value = value; }
        }

        public class Room : Thing
        {
            private int _n;
            private int _e;
            private int _s;
            private int _w;

            public Room(string aName, string aDiscription, int aN, int aE, int aS, int aW)
            : base(aName, aDiscription)
            {
                _n = aN;
                _e = aE;
                _s = aS;
                _w = aW;
            }
            public int N
            {
                get { return _n; }
                set { _n = value; }
            }


            public int E
            {
                get { return _e; }
                set { _e = value; }
            }
            public int S
            {
                get { return _s; }
                set { _s = value; }
            }
            public int W
            {
                get { return _w; }
                set { _w = value; }
            }
        }
    }
}
