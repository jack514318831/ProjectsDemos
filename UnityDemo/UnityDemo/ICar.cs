using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo
{
    public interface ICar
    {
        string Name { get; set; }
        string ShowName();
        int Run(int d);
        int ShowMeil();
    }
}
