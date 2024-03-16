using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveBacktrackingMazeGenerator
{
    class Vertex<T>
    {
        public T Value;
        public List<Vertex<T>> ConnectedVertices;

        public Vertex(T val)
        {
            Value = val;
            ConnectedVertices = new List<Vertex<T>>();
        }
    }
}
