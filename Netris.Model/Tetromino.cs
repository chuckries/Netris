using System;
using System.Collections.Generic;
using System.Text;

namespace Netris.Model
{
    public abstract class Tetromino
    {
        public abstract TetrominoType Type { get; }

        public static Tetromino I => new Tetrominoes.I();
        public static Tetromino O => new Tetrominoes.O();
        public static Tetromino T => new Tetrominoes.T();
        public static Tetromino S => new Tetrominoes.S();
        public static Tetromino Z => new Tetrominoes.Z();
        public static Tetromino J => new Tetrominoes.J();
        public static Tetromino L => new Tetrominoes.L();

        /// <summary>
        /// Returns the coordinates of the blocks of this piece relative to the bounding box as pictured here:http://tetris.wikia.com/wiki/SRS
        /// X increases from left to right starting at 0
        /// Y increases from bottom to top starting at 0
        /// </summary>
        /// <returns></returns>
        public Coordinate[] GetBlockCoordinates() => s_blockCoordinates;

        public virtual bool IsI() => false;
        public virtual bool IsO() => false;
        public virtual bool IsT() => false;
        public virtual bool IsS() => false;
        public virtual bool IsZ() => false;
        public virtual bool IsJ() => false;
        public virtual bool IsL() => false;

        protected static Coordinate[] s_blockCoordinates;
    }
}
