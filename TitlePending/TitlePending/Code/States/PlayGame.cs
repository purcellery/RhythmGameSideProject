using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TitlePending.Code.MainGame;
using TitlePending.Code.MainGame.Gameplay;

namespace TitlePending.Code.States {
    public class PlayGame : State {
        private Dictionary<NoteColor, HashSet<float>> notes;
        private Vector2 offScreen = new Vector2();
        private float hitterSpacing = 150;
        private float noteSpacing = 100;
        public Texture2D trackImage;
        private BasicEffect effect;

        private float xfuck = 0;


        public PlayGame() : base(StateID.MainMenu) {

            GameObject backgroundImage = new GameObject(GameManager.centerpoint);
            backgroundImage.earlyContentLoad = (content) => {
                backgroundImage.SetTexture(content.Load<Texture2D>("MainMenu"));
            };
        }
        public override void Initialize() {
            InitializeHitters();
            InitializeOrigins();
        }

        public override void LoadContent(ContentManager content) {
            base.LoadContent(content);
            trackImage = content.Load<Texture2D>("Track");

            effect = new BasicEffect(GameManager.gameCore.GraphicsDevice) {
                TextureEnabled = true,
                VertexColorEnabled = true
            };

            effect.Projection = Matrix.CreatePerspectiveOffCenter(0, GameManager.ScreenSize.X, GameManager.ScreenSize.Y, 0, 8.0f, 100);
            effect.View = Matrix.CreateLookAt(new Vector3(0, 5, 50), new Vector3(-2f, -0.5f, 0), Vector3.Up); //Matrix.CreateRotationX(0.001f);
            effect.World = Matrix.Identity;
        }

        public override void Draw(SpriteBatch spriteBatch) {
            if (InputManager.APressed) xfuck -= 1;
            else if (InputManager.DPressed) xfuck += 1;
            effect.World = Matrix.CreateTranslation(xfuck, 0, 0) * Matrix.Identity;
            

            spriteBatch.Begin(rasterizerState: RasterizerState.CullNone, effect: effect);
            spriteBatch.Draw(trackImage, Vector2.Zero, Color.White);

            spriteBatch.End();

            base.Draw(spriteBatch);
            //Matrix.CreateRotationX(-.6981f)
        }
        #region Initializing Hitters and Origins
        public void InitializeHitters() {
            // TODO: Add your initialization logic here
            for (int i = -2; i <= 2; i++) {
                NoteHitter newHitter = new NoteHitter(new Vector2(GameManager.ScreenSize.X / 2f + (hitterSpacing * i), 950));
                Color hitterColor = Color.White;
                switch (i) {
                    case -2:
                        hitterColor = Color.SpringGreen;
                        GameManager.GreenHitter = newHitter.position;
                        newHitter.onTrigger = () => {
                            return InputManager.APressed;
                        };
                        break;

                    case -1:
                        hitterColor = Color.Red;
                        GameManager.RedHitter = newHitter.position;
                        newHitter.onTrigger = () => {
                            return InputManager.SPressed;
                        };
                        break;

                    case 0:
                        hitterColor = Color.Yellow;
                        GameManager.YellowHitter = newHitter.position;
                        newHitter.onTrigger = () => {
                            return InputManager.DPressed;
                        };
                        break;

                    case 1:
                        hitterColor = Color.RoyalBlue;
                        GameManager.BlueHitter = newHitter.position;
                        newHitter.onTrigger = () => {
                            return InputManager.FPressed;
                        };
                        break;

                    case 2:
                        hitterColor = Color.MonoGameOrange;
                        GameManager.OrangeHitter = newHitter.position;
                        newHitter.onTrigger = () => {
                            return InputManager.GPressed;
                        };
                        break;
                }
                newHitter.color = hitterColor;
                gameObjects.Add(newHitter);
            }
        }

        public void InitializeOrigins() {
            GameManager.GreenOrigin = new Vector2(GameManager.centerpoint.X + noteSpacing * -2, 450);
            GameManager.RedOrigin = new Vector2(GameManager.centerpoint.X + noteSpacing * -1, 450);
            GameManager.YellowOrigin = new Vector2(GameManager.centerpoint.X, 450);
            GameManager.BlueOrigin = new Vector2(GameManager.centerpoint.X + noteSpacing, 450);
            GameManager.OrangeOrigin = new Vector2(GameManager.centerpoint.X + noteSpacing * 2, 450);

            gameObjects.Add(new Note(GameManager.GreenOrigin));
            gameObjects.Add(new Note(GameManager.RedOrigin));
            gameObjects.Add(new Note(GameManager.YellowOrigin));
            gameObjects.Add(new Note(GameManager.BlueOrigin));
            gameObjects.Add(new Note(GameManager.OrangeOrigin));
        }
        #endregion
    }
}