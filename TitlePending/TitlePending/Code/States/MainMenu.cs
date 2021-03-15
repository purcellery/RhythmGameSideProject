using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using TitlePending.Code.MainGame;
using TitlePending.Code.MainGame.UI;

namespace TitlePending.Code.States
{
    public class MainMenu : State
    {

        public Song mainMenuSong;
        public Song mainMenuIntro;

        public MainMenu() : base(StateID.MainMenu)
        {
            GameManager.currentState = this;

            gameObjects = new List<GameObject>();
            GameObject backgroundImage = new GameObject(GameManager.centerpoint);
            backgroundImage.earlyContentLoad = (content) =>
            {
                backgroundImage.SetTexture(content.Load<Texture2D>("MainMenu"));
            };
            gameObjects.Add(backgroundImage);

            gameObjects.Add(new Button(new Vector2(GameManager.centerpoint.X, GameManager.centerpoint.Y), 0, () =>
            {
                GameManager.SwitchState(StateID.PlayGame);
            }, ButtonType.StartGame
            ));

            gameObjects.Add(new Button(new Vector2(GameManager.centerpoint.X, GameManager.centerpoint.Y + 100), 1, () =>
            {
                GameManager.SwitchState(StateID.OptionMenu);
            }, ButtonType.Options
            ));

            gameObjects.Add(new Button(new Vector2(GameManager.centerpoint.X, GameManager.centerpoint.Y + 200), 2, () =>
            {
                GameManager.Exit();
            }, ButtonType.ExitGame
            ));
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            mainMenuIntro = content.Load<Song>("MainMenuIntro");
            mainMenuSong = content.Load<Song>("MainMenuLoop");

            if (MediaPlayer.PlayPosition.TotalSeconds == 0)
            {
                MediaPlayer.Volume = 0.5f;
                MediaPlayer.Play(mainMenuIntro);
            }
        }

        public override void Update()
        {
            base.Update();
            if (MediaPlayer.PlayPosition.TotalSeconds >= 7.64 && !GameManager.hasPlayedIntro)
            {
                MediaPlayer.Play(mainMenuSong);
                MediaPlayer.IsRepeating = true;
                GameManager.hasPlayedIntro = true;
            }
        }
    }
}