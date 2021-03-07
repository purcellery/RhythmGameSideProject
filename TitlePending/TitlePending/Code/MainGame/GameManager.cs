using SharpDX.MediaFoundation.DirectX;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Text;
using TitlePending.Code.States;

namespace TitlePending.Code.MainGame
{
    public static class GameManager
    {
        public static int currentlySelected = 0;

        public static TitlePending gameCore { get; set; }

        public static Vector2 GreenHitter { get; set; }
        public static Vector2 RedHitter { get; set; }
        public static Vector2 YellowHitter { get; set; }
        public static Vector2 BlueHitter { get; set; }
        public static Vector2 OrangeHitter { get; set; }

        public static State currentState;

        public static Vector2 GreenOrigin { get; set; }
        public static Vector2 RedOrigin { get; set; } 
        public static Vector2 YellowOrigin { get; set; } 
        public static Vector2 BlueOrigin { get; set; } 
        public static Vector2 OrangeOrigin { get; set; } 

        public static Vector2 centerpoint => gameCore.GraphicsDevice.Viewport.Bounds.Center.ToVector2();
        public static Vector2 ScreenSize => gameCore.GraphicsDevice.Viewport.Bounds.Size.ToVector2();
        public static float AspectRatio => gameCore.GraphicsDevice.Viewport.AspectRatio;

        public static void Exit()
        {
            gameCore.Exit();
        }

        public static void SwitchState(StateID stateID)
        {
            gameCore.SwitchState(stateID);
        }
    }
}
