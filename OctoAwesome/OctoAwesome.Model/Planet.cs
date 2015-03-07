﻿using Microsoft.Xna.Framework;
using OctoAwesome.Model.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OctoAwesome.Model
{
    internal class Planet : IPlanet
    {
        private IMapGenerator generator;

        private IChunk[, ,] chunks;

        public int Seed { get; private set; }

        public Index3 Size { get; private set; }

        public Planet(Index3 size, IMapGenerator generator, int seed)
        {
            this.generator = generator;
            Size = size;
            Seed = seed;

            chunks = new Chunk[Size.X, Size.Y, Size.Z];

            for (int x = 0; x < Size.X; x++)
            {
                for (int y = 0; y < Size.Y; y++)
                {
                    for (int z = 0; z < Size.Z; z++)
                    {
                        chunks[x, y, z] = generator.GenerateChunk(this, new Index3(x, y, z));
                    }
                }
            }
        }

        public IChunk GetChunk(Index3 index)
        {
            if (chunks[index.X, index.Y, index.Z] == null)
            {
                // TODO: Load from disk
            }

            return chunks[index.X, index.Y, index.Z];
        }

        public IBlock GetBlock(Index3 index)
        {
            Coordinate coordinate = new Coordinate(0, index, Vector3.Zero);
            IChunk chunk = GetChunk(coordinate.ChunkIndex);
            return chunk.GetBlock(coordinate.LocalBlockIndex);
        }

        public void SetBlock(Index3 index, IBlock block, TimeSpan time)
        {
            Coordinate coordinate = new Coordinate(0, index, Vector3.Zero);
            IChunk chunk = GetChunk(coordinate.ChunkIndex);
            chunk.SetBlock(coordinate.LocalBlockIndex, block, time);
        }
    }
}