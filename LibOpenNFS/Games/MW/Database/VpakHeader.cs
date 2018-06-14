﻿using System.Runtime.InteropServices;

namespace LibOpenNFS.Games.MW.Database
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VpakHeader
    {
        public readonly uint Magic;

        public readonly uint FileCount;

        public readonly uint FileTableLocation;
        
        public readonly uint FileTableLength;
    }
}