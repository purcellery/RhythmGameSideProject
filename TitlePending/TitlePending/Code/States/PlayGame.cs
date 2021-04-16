using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TitlePending.Code.MainGame;
using TitlePending.Code.MainGame.Gameplay;
using Microsoft.Xna.Framework.Media;

namespace TitlePending.Code.States
{
    public class PlayGame : State
    {
        private Dictionary<NoteColor, HashSet<float>> notes;
        private Vector2 offScreen = new Vector2();
        private float hitterSpacing = 150;
        private float noteSpacing = 100;
        public Texture2D trackImage;
        private BasicEffect effect;
        private ContentManager noteContent;

        private GameSong thisSong;
        private List<float> deleteQueue;

        private ContentManager thisContent;

        public PlayGame() : base(StateID.MainMenu)
        {
            deleteQueue = new List<float>();

            GameObject backgroundImage = new GameObject(GameManager.centerpoint);
            backgroundImage.earlyContentLoad = (content) => {
                backgroundImage.SetTexture(content.Load<Texture2D>("MainMenu"));
            };

            GameScore score = new GameScore(new Vector2(16, 16));          //Fix this
            gameObjects.Add(score);
            GameManager.Score = score;

        }
        public override void Initialize()
        {
            InitializeHitters();
            InitializeOrigins();
        }

        public override void Load()
        {
            switch (GameManager.selectedSongID)
            {
                case MainGame.Gameplay.SongID.OneMustVibe:
                    thisSong = new Song_OneMustVibe(Vector2.Zero);
                    break;

                case MainGame.Gameplay.SongID.Shmovement:
                    thisSong = new Song_Shmovement(Vector2.Zero);
                    break;
            }
            gameObjects.Add(thisSong);
            thisSong.LoadContent(thisContent);

            TimeSpan bufferTest = TimeSpan.FromSeconds(0);
            MediaPlayer.Play(thisSong.song, bufferTest);
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            thisContent = content;
            noteContent = content;
            trackImage = content.Load<Texture2D>("Track");

            effect = new BasicEffect(GameManager.gameCore.GraphicsDevice)
            {
                TextureEnabled = true,
                VertexColorEnabled = true
            };

            effect.World = Matrix.CreateTranslation(0, 1220, 0) * Matrix.Identity; //1216 = starting y pos
            effect.View = Matrix.CreateRotationX(MathHelper.ToRadians(-44.88f)) * //angle of rotation looking at the track
                          Matrix.CreateLookAt(new Vector3(0, 3f, 10), new Vector3(0, -1, 6), Vector3.Up);
            effect.Projection = Matrix.CreatePerspective(GameManager.ScreenSize.X / 2, -GameManager.ScreenSize.Y / 2, 1f, 100f);

        }

        public override void Update()
        {
            base.Update();
            //SpawnNote();

            foreach (KeyValuePair<NoteColor, HashSet<float>> kvp in thisSong.notes)
            {
                foreach (float time in kvp.Value)
                {
                    if (MediaPlayer.PlayPosition.TotalSeconds >= time - Note.testSpeed) // so much to fix lmao
                    {
                        Note newQ = new Note(Vector2.Zero, kvp.Key);
                        newQ.LoadContent(noteContent);
                        gameObjects.Add(newQ);

                        deleteQueue.Add(time);
                    }
                }
                while (deleteQueue.Count > 0)
                {
                    kvp.Value.Remove(deleteQueue[0]);
                    deleteQueue.RemoveAt(0);
                }
            }
            if (InputManager.RPressed)
            {
                GameManager.SwitchState(StateID.PlayGame);
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(rasterizerState: RasterizerState.CullNone, effect: effect);
            //
            spriteBatch.Draw(trackImage, Vector2.Zero, null, Color.White, 0, trackImage.Bounds.Size.ToVector2() / 2f, 5.55f, SpriteEffects.None, 0.5f);

            spriteBatch.Draw(trackImage, new Vector2(0, -3600), null, Color.Black, 0, trackImage.Bounds.Size.ToVector2() / 2f, 6.08f, SpriteEffects.None, 1f);
            //
            spriteBatch.End();

            base.Draw(spriteBatch);
        }
        #region Initializing Hitters and Origins
        public void InitializeHitters()
        {
            // TODO: Add your initialization logic here
            for (int i = -2; i <= 2; i++)
            {
                NoteHitter newHitter = new NoteHitter(new Vector2(GameManager.ScreenSize.X / 2f + (hitterSpacing * i), 950));
                Color hitterColor = Color.White;
                switch (i)
                {
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

        public void InitializeOrigins()
        {
            GameManager.GreenOrigin = new Vector2(GameManager.centerpoint.X + noteSpacing * -2, 450);
            GameManager.RedOrigin = new Vector2(GameManager.centerpoint.X + noteSpacing * -1, 450);
            GameManager.YellowOrigin = new Vector2(GameManager.centerpoint.X, 450);
            GameManager.BlueOrigin = new Vector2(GameManager.centerpoint.X + noteSpacing, 450);
            GameManager.OrangeOrigin = new Vector2(GameManager.centerpoint.X + noteSpacing * 2, 450);

            float origScale = 0.5f / 2f;



            //gameObjects.Add(new Note(GameManager.GreenOrigin) { scale = origScale });
            //gameObjects.Add(new Note(GameManager.RedOrigin) { scale = origScale });
            //gameObjects.Add(new Note(GameManager.YellowOrigin) { scale = origScale });
            //gameObjects.Add(new Note(GameManager.BlueOrigin) { scale = origScale });
            //gameObjects.Add(new Note(GameManager.OrangeOrigin) { scale = origScale });
        }
        #endregion

        public void SpawnNote()
        {
            if (InputManager.QPressed)
            {
                Note newQ = new Note(Vector2.Zero, NoteColor.Green);
                newQ.LoadContent(noteContent);
                gameObjects.Add(newQ);
            }
            if (InputManager.WPressed)
            {
                Note newW = new Note(Vector2.Zero, NoteColor.Red);
                newW.LoadContent(noteContent);
                gameObjects.Add(newW);
            }
            if (InputManager.EPressed)
            {
                Note newE = new Note(Vector2.Zero, NoteColor.Yellow);
                newE.LoadContent(noteContent);
                gameObjects.Add(newE);
            }
            if (InputManager.RPressed)
            {
                Note newR = new Note(Vector2.Zero, NoteColor.Blue);
                newR.LoadContent(noteContent);
                gameObjects.Add(newR);
            }
            if (InputManager.TPressed)
            {
                Note newT = new Note(Vector2.Zero, NoteColor.Orange);
                newT.LoadContent(noteContent);
                gameObjects.Add(newT);
            }

        }
    }
}