using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris.Model.Tetrominoes
{
    public class O : Tetromino
    {
        static O()
        {
            s_blockCoordinates = new[]
            {
                new Coordinate(0, 2),
                new Coordinate(0, 1),
                new Coordinate(1, 1),
                new Coordinate(2, 1)
            };
        }

        public override TetrominoType Type => TetrominoType.O;

        public override bool IsO() => true; 
    }
}
