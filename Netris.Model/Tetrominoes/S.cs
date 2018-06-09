using System;
using System.Collections.Generic;
using System.Text;

namespace Netris.Model.Tetrominoes
{
    public class S : Tetromino
    {
        static S()
        {
            s_blockCoordinates = new[]
            {
                new Coordinate(1, 2),
                new Coordinate(2, 2),
                new Coordinate(0, 1),
                new Coordinate(1, 1)
            };
        }

        public override TetrominoType Type => TetrominoType.S;

        public override bool IsS() => true;
    }
}
