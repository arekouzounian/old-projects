using System;
using System.Drawing;

namespace RecursiveBacktrackingMazeGenerator
{
    public class Wall
    {
        public bool isUp;
        public Point StartPoint;
        public Point EndPoint;

        public Wall(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            isUp = true;
        }

        public static void TakeDownWall(Cell cell1, Cell cell2) //takes down the wall between cell1 and cell2
        {
            if (cell1.NorthWall.Equals(cell2.SouthWall))
            {
                cell1.NorthWall.isUp = false;
                cell2.SouthWall.isUp = false;
            }
            else if (cell1.WestWall.Equals(cell2.EastWall))
            {
                cell1.WestWall.isUp = false;
                cell2.EastWall.isUp = false;
            }
            else if (cell1.SouthWall.Equals(cell2.NorthWall))
            {
                cell1.SouthWall.isUp = false;
                cell2.NorthWall.isUp = false;
            }
            else if (cell1.EastWall.Equals(cell2.WestWall))
            {
                cell1.EastWall.isUp = false;
                cell2.WestWall.isUp = false;
            }
            else
            {
                throw new Exception("there is no wall between the given cells");
            }
        }
    }
}