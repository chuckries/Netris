using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netris.Model
{
    public class RandomGenerator
    {
        public RandomGenerator()
        {
            _random = new Random();
            _queue = new Queue<Tetromino>();
        }

        public RandomGenerator(int seed)
        {
            _random = new Random(seed);
            _queue = new Queue<Tetromino>();
        }

        public Tetromino Peek()
        {
            EnsureQueue();
            return _queue.Peek();
        }

        public Tetromino Get()
        {
            EnsureQueue();
            return _queue.Dequeue();
        }

        private void EnsureQueue()
        {
            if (_queue.Count == 0)
            {
                foreach (var piece in GetBag())
                {
                    _queue.Enqueue(piece);
                }
            }
        }

        private Tetromino[] GetBag()
        {
            Tetromino[] bag = new[]
            {
                Tetromino.I,
                Tetromino.O,
                Tetromino.T,
                Tetromino.S,
                Tetromino.Z,
                Tetromino.J,
                Tetromino.L
            };

            for (int i = 0; i < bag.Length - 1; i++)
            {
                int swapIndex = _random.Next(i, bag.Length);

                Tetromino temp = bag[swapIndex];
                bag[swapIndex] = bag[i];
                bag[i] = temp;
            }

            return bag;
        }

        private Random _random;
        private Queue<Tetromino> _queue;
    }
}
