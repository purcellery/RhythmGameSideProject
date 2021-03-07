using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TitlePending
{
    public static class InputManager
    {
        static KeyboardState currentKeyboardState;
        static KeyboardState priorKeyboardState;
        static MouseState currentMouseState;
        static MouseState priorMouseState;
        static GamePadState currentGamePadState;
        static GamePadState priorGamePadState;

        public static Vector2 Direction { get; private set; }

        public static bool SpacePressed { get; private set; }
        public static bool APressed { get; private set; }
        public static bool SPressed { get; private set; }
        public static bool DPressed { get; private set; }
        public static bool FPressed { get; private set; }
        public static bool GPressed { get; private set; }


        public static bool Exit { get; private set; } = false;

        public static void Update(GameTime gameTime)
        {
            #region State Updating

            priorKeyboardState = currentKeyboardState;
            currentKeyboardState = Keyboard.GetState();

            priorMouseState = currentMouseState;
            currentMouseState = Mouse.GetState();

            priorGamePadState = currentGamePadState;
            currentGamePadState = GamePad.GetState(0);

            #endregion

            #region Direction Input

            Direction = currentGamePadState.ThumbSticks.Right * 100 * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (currentKeyboardState.IsKeyDown(Keys.Left) || currentKeyboardState.IsKeyDown(Keys.A))
            {
                Direction += new Vector2(-100 * (float)gameTime.ElapsedGameTime.TotalSeconds, 0);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Right) || currentKeyboardState.IsKeyDown(Keys.D))
            {
                Direction += new Vector2(100 * (float)gameTime.ElapsedGameTime.TotalSeconds, 0);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Up) || currentKeyboardState.IsKeyDown(Keys.W))
            {
                Direction += new Vector2(0, -100 * (float)gameTime.ElapsedGameTime.TotalSeconds);
            }
            if (currentKeyboardState.IsKeyDown(Keys.Down) || currentKeyboardState.IsKeyDown(Keys.S))
            {
                Direction += new Vector2(0, 100 * (float)gameTime.ElapsedGameTime.TotalSeconds);
            }

            #endregion

            #region Space Bar Input

            if (currentKeyboardState.IsKeyDown(Keys.Space) && !priorKeyboardState.IsKeyDown(Keys.Space))
            {
                SpacePressed = true;
            }
            else
            {
                SpacePressed = false;
            }

            #endregion

            #region Note Input

            if (currentKeyboardState.IsKeyDown(Keys.A))
            {
                APressed = true;
            }
            else
            {
                APressed = false;
            }

            if (currentKeyboardState.IsKeyDown(Keys.S))
            {
                SPressed = true;
            }
            else
            {
                SPressed = false;
            }

            if (currentKeyboardState.IsKeyDown(Keys.D))
            {
                DPressed = true;
            }
            else
            {
                DPressed = false;
            }

            if (currentKeyboardState.IsKeyDown(Keys.F))
            {
                FPressed = true;
            }
            else
            {
                FPressed = false;
            }

            if (currentKeyboardState.IsKeyDown(Keys.G))
            {
                GPressed = true;
            }
            else
            {
                GPressed = false;
            }

            #endregion

            #region Exit Input
            if (currentGamePadState.Buttons.Back == ButtonState.Pressed || currentKeyboardState.IsKeyDown(Keys.Escape))
            {
                Exit = true;
            }
            #endregion
        }
    }
}
