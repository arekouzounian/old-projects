using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveBacktrackingMazeGenerator
{
    class Edge<T>
    {
        //an edge that connects Vertex A and Vertex B bidirectionally
        public Vertex<T> VertexA;
        public Vertex<T> VertexB;

        public double Weight;

        public Edge(Vertex<T> A, Vertex<T> B, double weight)
        {
            VertexA = A;
            VertexB = B;
            Weight = weight;
        }
    }
}
