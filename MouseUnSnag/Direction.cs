﻿using System;

namespace MouseUnSnag
{
    [Flags]
    public enum Direction
    {
        None  = 0x0,
        Left  = 0x1,
        Right = 0x2,
        Up    = 0x4,
        Down  = 0x8,
    }
}
