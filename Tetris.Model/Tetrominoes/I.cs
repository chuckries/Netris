using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris.Model.Tetrominoes
{
    public class I : Tetromino
    {
        static I()
        {
            s_blockCoordinates = new[]
            {
                new Coordinate(0, 2),
                new Coordinate(1, 2),
                new Coordinate(2, 2),
                new Coordinate(3, 2)
            };
        }

        public override TetrominoType Type => TetrominoType.I;

        public override bool IsI() => true;
    }
}
