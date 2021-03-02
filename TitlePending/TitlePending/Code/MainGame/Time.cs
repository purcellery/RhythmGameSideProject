using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TitlePending.Code.MainGame
{
    public static class Time
    {
        public static float deltaTime
        {
            private set; get;
        }

        public static void SetDeltaTime(GameTime gameTime)
        {
            deltaTime = (float) gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
