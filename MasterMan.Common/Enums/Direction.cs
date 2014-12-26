﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMan.Common.Enums
{
    public enum Direction
    {
        [Description("none")]
        None,
        [Description("up")]
        Up,
        [Description("down")]
        Down,
        [Description("left")]
        Left,
        [Description("right")]
        Right,
        [Description("upleft")]
        UpLeft,
        [Description("downleft")]
        DownLeft,
        [Description("upright")]
        UpRight,
        [Description("downright")]
        DownRight
    }

    public static class DirectionHelper
    {
        public static Direction GetOppositeDirection(Direction direction)
        {
            Direction opposite = Direction.None;

            switch(direction)
            {
                case Direction.Up:
                    opposite = Direction.Down;
                    break;
                case Direction.Down:
                    opposite = Direction.Up;
                    break;
                case Direction.Left:
                    opposite = Direction.Right;
                    break;
                case Direction.Right:
                    opposite = Direction.Left;
                    break;
                case Direction.UpLeft:
                    opposite = Direction.DownRight;
                    break;
                case Direction.UpRight:
                    opposite = Direction.DownLeft;
                    break;
                case Direction.DownLeft:
                    opposite = Direction.UpRight;
                    break;
                case Direction.DownRight:
                    opposite = Direction.UpLeft;
                    break;
            }

            return opposite;
        }
    }
    
}
