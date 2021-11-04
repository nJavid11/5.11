using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public abstract class Animal
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract string Eat();
    }
}
