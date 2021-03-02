using SharpDX.MediaFoundation.DirectX;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Text;

namespace TitlePending.Code.MainGame
{
    public static class GameManager
    {
        public static int currentlySelected = 0;

        public static TitlePending gameCore { private get; set; }

        public static Vector2 centerpoint => gameCore.GraphicsDevice.Viewport.Bounds.Center.ToVector2();
        public static Vector2 ScreenSize => gameCore.GraphicsDevice.Viewport.Bounds.Size.ToVector2();
    }
}
