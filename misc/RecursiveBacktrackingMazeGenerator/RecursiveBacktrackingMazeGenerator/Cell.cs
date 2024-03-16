using System;
using System.Drawing;

namespace RecursiveBacktrackingMazeGenerator
{
    public class Cell : IComparable
    {
        public Rectangle PosRect;
        public Point Pt;
        public bool isVisited = false;
        public Cell WestCell; //cells
        public Cell EastCell;
        public Cell NorthCell;
        public Cell SouthCell;
        //walls
        public Wall NorthWall;
        public Wall SouthWall;
        public Wall EastWall;
        public Wall WestWall;

        //A* vars
        public double KnownDistance;
        public Cell FounderCell;
        public double FinalDistance;
        public bool isSolved = false;

        public Cell(Rectangle posRect)
        {
            PosRect = posRect;
            Pt = PosRect.Location;
            NorthWall = new Wall(Pt, new Point(Pt.X + 10, Pt.Y));
            SouthWall = new Wall(new Point(Pt.X, Pt.Y + 10), new Point(Pt.X + 10, Pt.Y + 10));
            EastWall = new Wall(new Point(Pt.X + 10, Pt.Y), new Point(Pt.X + 10, Pt.Y + 10));
            WestWall = new Wall(Pt, new Point(Pt.X, Pt.Y + 10));
        }

        public Cell getRandomCell(Random gen)
        {
            //Random gen = new Random();
            int temp = gen.Next(0, 4);
            if (temp == 0)
            {
                return NorthCell;
            }
            else if (temp == 1)
            {
                return EastCell;
            }
            else if (temp == 2)
            {
                return SouthCell;
            }
            else
            {
                return WestCell;
            }
        }

        public bool AllVisitedOrNull()
        {

            Cell[] adjacentCells = new Cell[] { NorthCell, EastCell, SouthCell, WestCell };
            for (int i = 0; i < adjacentCells.Length; i++)
            {
                if (adjacentCells[i] != null && !adjacentCells[i].isVisited)
                {
                    return false;
                }
            }
            return true;
        }

        public Cell getUnvisitedNeighbor(Random gen)
        {
            Cell currCell;
            while (true)
            {
                currCell = getRandomCell(gen);
                if (currCell == null || currCell.isVisited)
                {
                    continue;
                }

                if (currCell.Equals(NorthCell))
                {
                    NorthWall.isUp = false;
                    NorthCell.SouthWall.isUp = false;
                }
                else if (currCell.Equals(EastCell))
                {
                    EastWall.isUp = false;
                    EastCell.WestWall.isUp = false;
                }
                else if (currCell.Equals(SouthCell))
                {
                    SouthWall.isUp = false;
                    SouthCell.NorthWall.isUp = false;
                }
                else if (currCell.Equals(WestCell))
                {
                    WestWall.isUp = false;
                    WestCell.EastWall.isUp = false;
                }
                return currCell;
            }
        }

        public Cell MostRightCell() //needs to be re-written; if your only options are north, west, and south, 
        {   //it should go north but as it stands currently, the program would go south 
            if (EastWall != null && !EastWall.isUp && !EastCell.isSolved)
            {
                return EastCell;
            }
            else if (NorthWall != null && !NorthWall.isUp && !NorthCell.isSolved)
            {
                return NorthCell;
            }
            else if (WestWall != null && !WestWall.isUp && !WestCell.isSolved)
            {
                return WestCell;
            }
            else if (SouthWall != null && !SouthWall.isUp && !SouthCell.isSolved)
            {
                return SouthCell;
            }
            else
            {
                return null;
            }
        }

        public bool IsIntersection()
        {
            int numOfWays = 0;
            if (NorthWall != null && !NorthWall.isUp && !NorthCell.isSolved)
            {
                numOfWays++;
            }
            if (EastWall != null && !EastWall.isUp && !EastCell.isSolved)
            {
                numOfWays++;
            }
            if (SouthWall != null && !SouthWall.isUp && !SouthCell.isSolved)
            {
                numOfWays++;
            }
            if (WestWall != null && !WestWall.isUp && !WestCell.isSolved)
            {
                numOfWays++;
            }

            if (numOfWays > 1)
            {
                return true;
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            if (obj.GetType().Equals(this.GetType()))
            {
                Cell cell = (Cell)obj;
                if (FinalDistance < cell.FinalDistance)
                {
                    return -1;
                }
                else if (FinalDistance > cell.FinalDistance)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}