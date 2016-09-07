﻿using System;
using System.Drawing;

namespace OctoAwesome.Basics.Definitions.Blocks
{
    public sealed class RedstoneBlockDefinition : BlockDefinition
    {
        public override string Name
        {
            get { return Languages.OctoBasics.Redstone; }
        }

        public override string Icon
        {
            get { return "redstone"; }
        }


        public override string[] Textures
        {
            get
            {
                return new[] {
                    "redstone",
                };
            }
        }

        public override PhysicalProperties GetProperties(ILocalChunkCache manager, int x, int y, int z)
        {
            return new PhysicalProperties()
            {
                Density = 2.5f,
                FractureToughness = 0.1f,
                Granularity = 0.1f,
                Hardness = 0.9f
            };
        }

        public override void Hit(IBlockDefinition block, PhysicalProperties itemProperties)
        {
            throw new NotImplementedException();
        }
    }
}
