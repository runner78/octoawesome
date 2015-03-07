﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OctoAwesome.Model
{
    public struct Index3
    {
        public int X;

        public int Y;

        public int Z;

        public Index3(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Index3 operator +(Index3 i1, Index3 i2)
        {
            return new Index3(i1.X + i2.X, i1.Y + i2.Y, i1.Z + i2.Z);
        }

        public static bool operator ==(Index3 i1, Index3 i2)
        {
            return i1.Equals(i2);
        }

        public static bool operator !=(Index3 i1, Index3 i2)
        {
            return !i1.Equals(i2);
        }

        public override string ToString()
        {
            return "(" + X.ToString() + "/" + Y.ToString() + "/" + Z.ToString() + ")";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Index3))
                return false;

            Index3 other = (Index3)obj;
            return (
                other.X == this.X && 
                other.Y == this.Y && 
                other.Z == this.Z);
        }
    }
}