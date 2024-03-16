using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveBacktrackingMazeGenerator
{
    class Graph<T>
    {
        public List<Vertex<T>> Vertices { get; private set; }
        public List<Edge<T>> Edges { get; private set; }
        public int Count
        {
            get
            {
                return Vertices.Count;
            }

        }

        public void AddVertex(T value)
        {
            var vert = new Vertex<T>(value);
            if (VertexSearch(value) == null)
            {
                Vertices.Add(vert);
            }
        }
        public void AddVertex(Vertex<T> vertex)
        {
            if (VertexSearch(vertex.Value) == null && vertex != null && vertex.ConnectedVertices.Count == 0)
            {
                Vertices.Add(vertex);
            }
        }

        public void AddEdge(Vertex<T> a, Vertex<T> b, double weight)
        {
            if ((a == null || b == null) || (a.ConnectedVertices.Contains(b) || b.ConnectedVertices.Contains(a)) || (EdgeSearch(a, b) != null))
            {
                return;
            }
            a.ConnectedVertices.Add(b);
            b.ConnectedVertices.Add(a);
            Edges.Add(new Edge<T>(a, b, weight));
        }

        #region search_functions
        public Vertex<T> VertexSearch(T value) //given a value it returns the corresponding vertex, given that the vertex exists in the graph
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].Value.Equals(value))
                {
                    return Vertices[i];
                }
            }
            return null;
        }
        public Edge<T> EdgeSearch(Vertex<T> vertA, Vertex<T> vertB)
        {
            if (vertA == null || vertB == null)
            {
                return null;
            }
            for (int i = 0; i < Edges.Count; i++)
            {
                if (Edges[i].VertexA.Equals(vertA) && Edges[i].VertexB.Equals(vertB))
                {
                    return Edges[i];
                }
                else if (Edges[i].VertexA.Equals(vertB) && Edges[i].VertexB.Equals(vertA))
                {
                    return Edges[i];
                }
            }
            return null;
        }
        public Edge<T> EdgeSearch(T itemA, T itemB)
        {
            Vertex<T> vertA = VertexSearch(itemA);
            Vertex<T> vertB = VertexSearch(itemB);
            if (vertA == null || vertB == null)
            {
                return null;
            }
            for (int i = 0; i < Edges.Count; i++)
            {
                if (Edges[i].VertexA.Equals(vertA) && Edges[i].VertexB.Equals(vertB))
                {
                    return Edges[i];
                }
                else if (Edges[i].VertexA.Equals(vertB) && Edges[i].VertexB.Equals(vertA))
                {
                    return Edges[i];
                }
            }
            return null;
        }
        public int IndexOf(T value) //given a value or a vertex, this function returns the index of the corresponding vertex in the graph, given it exists
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].Value.Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        public int IndexOf(Vertex<T> vert)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].Equals(vert))
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
    }
}
