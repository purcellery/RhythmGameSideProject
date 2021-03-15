using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TitlePending.Code.MainGame
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


        public static bool QPressed { get; private set; }
        public static bool WPressed { get; private set; }
        public static bool EPressed { get; private set; }
        public static bool RPressed { get; private set; }
        public static bool TPressed { get; private set; }





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

            #region Main Menu & Options Menu Input
            if ((currentKeyboardState.IsKeyDown(Keys.Up) && priorKeyboardState.IsKeyUp(Keys.Up)) && GameManager.currentState.stateID == StateID.MainMenu)
            {
                // goes up a button, if at top loops to bottom button
                if(GameManager.currentlySelected == 0)
                {
                    GameManager.currentlySelected = 2;
                }
                else
                {
                    GameManager.currentlySelected -= 1;
                }
            }

            if (GameManager.currentState.stateID == StateID.MainMenu)
            {
                if ((currentKeyboardState.IsKeyDown(Keys.Down) && priorKeyboardState.IsKeyUp(Keys.Down)))
                {
                    // goes down a button, if at bottom loops to top button
                    if (GameManager.currentlySelected == 2)
                    {
                        GameManager.currentlySelected = 0;
                    }
                    else
                    {
                        GameManager.currentlySelected += 1;
                    }
                }
            }
            else if(GameManager.currentState.stateID == StateID.OptionMenu)
            {
                if ((currentKeyboardState.IsKeyDown(Keys.Left) && priorKeyboardState.IsKeyUp(Keys.Left)) && GameManager.currentState.stateID == StateID.OptionMenu)
                {
                    if (GameManager.currentlySelected == 0)
                    {
                        GameManager.currentlySelected = 2;
                    }
                    else
                    {
                        GameManager.currentlySelected -= 1;
                    }
                }
                if ((currentKeyboardState.IsKeyDown(Keys.Right) && priorKeyboardState.IsKeyUp(Keys.Right)) && GameManager.currentState.stateID == StateID.OptionMenu)
                {
                    if (GameManager.currentlySelected == 2)
                    {
                        GameManager.currentlySelected = 0;
                    }
                    else
                    {
                        GameManager.currentlySelected += 1;
                    }
                }
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

            #region Test Input
            if (currentKeyboardState.IsKeyDown(Keys.Q) && !priorKeyboardState.IsKeyDown(Keys.Q))
            {
                QPressed = true;
            }
            else
            {
                QPressed = false;
            }

            if (currentKeyboardState.IsKeyDown(Keys.W) && !priorKeyboardState.IsKeyDown(Keys.W))
            {
                WPressed = true;
            }
            else
            {
                WPressed = false;
            }

            if (currentKeyboardState.IsKeyDown(Keys.E) && !priorKeyboardState.IsKeyDown(Keys.E))
            {
                EPressed = true;
            }
            else
            {
                EPressed = false;
            }

            if (currentKeyboardState.IsKeyDown(Keys.R) && !priorKeyboardState.IsKeyDown(Keys.R))
            {
                RPressed = true;
            }
            else
            {
                RPressed = false;
            }
            if (currentKeyboardState.IsKeyDown(Keys.T) && !priorKeyboardState.IsKeyDown(Keys.T))
            {
                TPressed = true;
            }
            else
            {
                TPressed = false;
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
