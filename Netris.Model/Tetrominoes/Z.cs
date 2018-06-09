using System;
using System.Collections.Generic;
using System.Text;

namespace Netris.Model.Tetrominoes
{
    public class Z : Tetromino
    {
        static Z()
        {
            s_blockCoordinates = new[]
            {
                new Coordinate(0, 2),
                new Coordinate(1, 2),
                new Coordinate(1, 1),
                new Coordinate(2, 1)
            };
        }

        public override TetrominoType Type => TetrominoType.Z;

        public override bool IsZ() => true;
    }
}
