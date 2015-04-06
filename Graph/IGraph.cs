using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    interface IGraph
    {

        int V { get; }
        int E { get; }
        bool IsDirected { get; }
        int Insert();


    }
}
