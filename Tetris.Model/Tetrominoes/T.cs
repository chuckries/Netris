using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris.Model.Tetrominoes
{
    public class T : Tetromino
    {
        static T()
        {
            s_blockCoordinates = new[]
            {
                new Coordinate(1, 2),
                new Coordinate(0, 1),
                new Coordinate(1, 1),
                new Coordinate(2, 1)
            };
        }

        public override TetrominoType Type => TetrominoType.T;

        public override bool IsT() => true;
    }
}
