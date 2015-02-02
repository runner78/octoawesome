﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OctoAwesome.Components
{
    internal class GamePadInput : IInputSet
    {
        public float MoveX { get; private set; }
        public float MoveY { get; private set; }
        public float HeadX { get; private set; }
        public float HeadY { get; private set; }

        public bool Interact { get; private set; }

        public void Update()
        {
            GamePadState gamePadState = GamePad.GetState(PlayerIndex.One);

            Interact = gamePadState.Buttons.A == ButtonState.Pressed;
            MoveX = gamePadState.ThumbSticks.Left.X;
            MoveY = gamePadState.ThumbSticks.Left.Y;
            HeadX = gamePadState.ThumbSticks.Right.X;
            HeadY = gamePadState.ThumbSticks.Right.Y;
        }
    }
}
