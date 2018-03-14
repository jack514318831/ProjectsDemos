using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo
{
    public class BMW : ICar
    {
        public string Name { get; set; }
        private int meil = 0;

        public BMW()
        {
            Name = "BMW";
        }

        public int Run(int d)
        {
            meil = d + meil;
            return meil;
        }

        public string ShowName()
        {
            return Name;
        }

        public int ShowMeil()
        {
            return meil;
        }
    }

    public class Audi : ICar
    {
        public string Name { get; set; }
        private int meil = 0;

        public Audi()
        {
            Name = "Audi";
        }

        public int Run(int d)
        {
            meil = d + meil;
            return meil;
        }

        public string ShowName()
        {
            return Name;
        }

        public int ShowMeil()
        {
            return meil;
        }
    }
}
