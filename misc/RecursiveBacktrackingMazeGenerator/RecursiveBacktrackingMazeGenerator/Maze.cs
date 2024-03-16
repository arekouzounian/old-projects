using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace RecursiveBacktrackingMazeGenerator
{
    internal class Maze
    {
        //rows, columns
        private readonly Cell[,] maze;
        private readonly List<Wall> walls;
        public int Width;
        public int Height;
        public int CellSideLength;
        public Point StartPos;
        public Maze(int width, int height, int cellSideLength, Point startPos)
        {
            Width = width;
            Height = height;
            CellSideLength = cellSideLength;
            StartPos = startPos;
            //set up the 2d array and initialize each cell
            maze = new Cell[height, width];
            walls = new List<Wall>();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    maze[i, j] = new Cell(new Rectangle((j * CellSideLength) + StartPos.X, (i * CellSideLength) + StartPos.Y, CellSideLength, CellSideLength));
                }
            }
            //set each cell's left, right, north, and south node
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Cell currCell = maze[i, j];
                    if (i < 1)
                    {
                        currCell.NorthCell = null;
                        currCell.NorthWall = null;
                    }
                    else
                    {
                        currCell.NorthCell = maze[i - 1, j];
                        currCell.NorthWall = maze[i - 1, j].SouthWall;
                    }

                    if (i == (Height - 1))
                    {
                        currCell.SouthCell = null;
                        currCell.SouthWall = null;
                    }
                    else
                    {
                        currCell.SouthCell = maze[i + 1, j];
                        currCell.SouthWall = maze[i + 1, j].NorthWall;
                    }

                    if (j < 1)
                    {
                        currCell.WestCell = null;
                        currCell.WestWall = null;
                    }
                    else
                    {
                        currCell.WestCell = maze[i, j - 1];
                        currCell.WestWall = maze[i, j - 1].EastWall;
                    }

                    if (j == (Width - 1))
                    {
                        currCell.EastCell = null;
                        currCell.EastWall = null;
                    }
                    else
                    {
                        currCell.EastCell = maze[i, j + 1];
                        currCell.EastWall = maze[i, j + 1].WestWall;
                    }
                }
            }
        }

        public void RecursiveBacktrack(Random gen)
        {
            Cell currCell = maze[0, 0];
            Stack<Cell> cells = new Stack<Cell>();
            cells.Push(currCell);
            Cell prevCell;
            while (cells.Count > 0)
            {
                currCell = cells.Pop();
                currCell.isVisited = true;
                if (!currCell.AllVisitedOrNull())
                {
                    cells.Push(currCell);
                    prevCell = currCell;
                    currCell = currCell.getUnvisitedNeighbor(gen);
                    //Wall.TakeDownWall(prevCell, currCell);
                    currCell.isVisited = true;
                    cells.Push(currCell);
                }
            }
        }

        /*
        public void rightHandRuleSolver(Graphics gfx)
        {
            //keep going to the right until you hit a dead end
            //if you hit a dead end then go back to the last right turn you made, and make the next most right turn
            Cell currCell = maze[0, 0];
            Stack<Cell> intersections = new Stack<Cell>();
            while (!currCell.Equals(maze[Height - 1, Width - 1]))
            {
                drawSolvePath(gfx, currCell, Brushes.DarkRed);

                Cell mostRight = currCell.MostRightCell();
                if (mostRight == null)
                {
                    currCell = intersections.Pop();
                    continue;
                }
                if (currCell.IsIntersection())
                {
                    intersections.Push(currCell);
                }
                currCell.isSolved = true;
                currCell = mostRight;
                //rather than recording each individual cell that the algo visits,
                //every time you go onto a new square, check if it has more than one option (if it's an intersection)
                //if so, then add it to the stack
                //once you hit a dead end, pop off once on the stack and check that intersection for the next choice
            }
        }
        */

        public void AStarSolver()
        {
            //init
            PriorityQueue priorityQueue = new PriorityQueue();
            Graph<Cell> cellGraph = new Graph<Cell>();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    cellGraph.AddVertex(new Vertex<Cell>(maze[i, j]));
                    maze[i, j].isSolved = false;
                    maze[i, j].KnownDistance = double.PositiveInfinity;
                    maze[i, j].FinalDistance = double.PositiveInfinity;
                    maze[i, j].FounderCell = null;
                }
            }
            //creating edges
            foreach (Vertex<Cell> vert in cellGraph.Vertices)
            {
                if (!vert.Value.NorthWall.isUp && vert.Value.NorthCell != null)
                {
                    cellGraph.AddEdge(vert, cellGraph.VertexSearch(vert.Value.NorthCell), 1);
                }
                if (!vert.Value.EastWall.isUp && vert.Value.EastCell != null)
                {
                    cellGraph.AddEdge(vert, cellGraph.VertexSearch(vert.Value.EastCell), 1);
                }
                if (!vert.Value.SouthWall.isUp && vert.Value.SouthCell != null)
                {
                    cellGraph.AddEdge(vert, cellGraph.VertexSearch(vert.Value.SouthCell), 1);
                }
                if (!vert.Value.WestWall.isUp && vert.Value.WestCell != null)
                {
                    cellGraph.AddEdge(vert, cellGraph.VertexSearch(vert.Value.WestCell), 1);
                }
            }
            Vertex<Cell> startVertex = cellGraph.VertexSearch(maze[0, 0]);
            startVertex.Value.KnownDistance = 0;
            startVertex.Value.FinalDistance = ((startVertex.Value.PosRect.X - maze[Height - 1, Width - 1].PosRect.X) + (startVertex.Value.PosRect.Y - maze[Height - 1, Width - 1].PosRect.Y));
            priorityQueue.Enqueue(startVertex.Value);
            while (priorityQueue.Count > 0)
            {
                Vertex<Cell> currVertex = cellGraph.VertexSearch(priorityQueue.Dequeue());

            }
        }

        public void drawSolvePath(Graphics gfx, Cell currCell, Brush color)
        {
            Rectangle rect = new Rectangle(currCell.PosRect.X + 1, currCell.PosRect.Y + 1, (currCell.PosRect.Width - 1), currCell.PosRect.Height - 1);
            gfx.FillRectangle(color, rect);
            Thread.Sleep(100);
        }

        public void drawMaze(Graphics gfx)
        {
            gfx.DrawRectangle(Pens.Black, StartPos.X - 1, StartPos.Y - 1, (Width * CellSideLength) + 1, (Height * CellSideLength) + 1);
            //need to draw walls (needs grid)
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    gfx.FillRectangle(Brushes.Blue, maze[i, j].PosRect);

                    Pen wallColor = Pens.Black;
                    if (maze[i, j].NorthWall != null)
                    {
                        if (!maze[i, j].NorthWall.isUp || (i == 0 && j == 0))
                        {
                            wallColor = Pens.Blue;
                        }
                        gfx.DrawLine(wallColor, maze[i, j].NorthWall.StartPoint, maze[i, j].NorthWall.EndPoint);
                        wallColor = Pens.Black;
                    }
                    if (maze[i, j].EastWall != null)
                    {
                        if (!maze[i, j].EastWall.isUp)
                        {
                            wallColor = Pens.Blue;
                        }
                        gfx.DrawLine(wallColor, maze[i, j].EastWall.StartPoint, maze[i, j].EastWall.EndPoint);
                        wallColor = Pens.Black;
                    }
                    if (maze[i, j].SouthWall != null)
                    {
                        if (!maze[i, j].SouthWall.isUp)
                        {
                            wallColor = Pens.Blue;
                        }
                        gfx.DrawLine(wallColor, maze[i, j].SouthWall.StartPoint, maze[i, j].SouthWall.EndPoint);
                        wallColor = Pens.Black;
                    }
                    if (maze[i, j].WestWall != null)
                    {
                        if (!maze[i, j].WestWall.isUp)
                        {
                            wallColor = Pens.Blue;
                        }
                        gfx.DrawLine(wallColor, maze[i, j].WestWall.StartPoint, maze[i, j].WestWall.EndPoint);
                        wallColor = Pens.Black;
                    }
                }
            }
            gfx.DrawLine(Pens.Blue, StartPos.X - 1, StartPos.Y - 1, StartPos.X + (CellSideLength - 1), StartPos.Y + (CellSideLength - 1));
        }
    }
}