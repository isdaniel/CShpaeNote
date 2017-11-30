using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CShapeNote
{
    /// <summary>
    /// 1.Dictionary<Type,List<ArrowType>>
    /// enum Arrow Random
    /// </summary>
    public enum DirectionType
    {
        UP = 1,
        DOWN = 2,
        LEFT = 4,
        RIGHT = 8
    }

    /// <summary>
    /// pic 100x100 
    /// 1,2,3,4,5,6,7,8
    /// (1,2) => 3
    /// (3,4) => 4
    /// 5 => 5
    /// ....
    /// 8 => 8
    /// 720x720
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<DirectionType>> dict =
              new Dictionary<string, List<DirectionType>>();
            dict["a1"] = new List<DirectionType>()
            {
                DirectionType.DOWN,
                DirectionType.UP,
                DirectionType.LEFT
            };

            dict["a2"] = new List<DirectionType>()
            {
                DirectionType.DOWN,
                DirectionType.UP
            };

            dict["a3"] = new List<DirectionType>()
            {
                DirectionType.DOWN,
                DirectionType.UP,
                DirectionType.LEFT,
                DirectionType.RIGHT
            };


            foreach (var d in dict.Values)
            {
                for (int i = 0; i < 10; i++)
                {
                    int seedVal = new Random().Next(0, d.Count);
                    Thread.Sleep(10);
                    Console.WriteLine($"{d[seedVal]}");
                }
            }

            Console.ReadKey();
        }
    }
}
