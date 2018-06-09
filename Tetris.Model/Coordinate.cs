using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris.Model
{
    public struct Coordinate
    {
        public readonly int X;
        public readonly int Y;

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Coordinate operator +(Coordinate lhs, Coordinate rhs) =>
            new Coordinate(lhs.X + rhs.X, lhs.Y + rhs.Y);
    }
}
