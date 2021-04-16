using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using TitlePending.Code.MainGame;
using TitlePending.Code.MainGame.UI;


namespace TitlePending.Code.States
{
    public class OptionsMenu : State
    {
        public Song mainMenuSong;
        public Song mainMenuIntro;

        public OptionsMenu() : base(StateID.OptionMenu)
        {

            gameObjects = new List<GameObject>();

            GameObject backgroundImage = new GameObject(GameManager.centerpoint);
            backgroundImage.earlyContentLoad = (content) =>
            {
                backgroundImage.SetTexture(content.Load<Texture2D>("MainMenu"));
            };
            gameObjects.Add(backgroundImage);

            gameObjects.Add(new Button(new Vector2(GameManager.centerpoint.X - 600, GameManager.centerpoint.Y), 0, () =>
            {
                //Turn down volume
                GameManager.SwitchState(StateID.MainMenu);

            }, ButtonType.Back
            ));

            gameObjects.Add(new Button(new Vector2(GameManager.centerpoint.X - 200, GameManager.centerpoint.Y), 1, () =>
            {
                //Turn down volume
                MediaPlayer.Volume -= 0.1f;
                GameManager.origVolume = MediaPlayer.Volume;

            }, ButtonType.VolumeDown
            ));

            gameObjects.Add(new Button(new Vector2(GameManager.centerpoint.X + 200, GameManager.centerpoint.Y), 2, () =>
            {
                //Turn up volume
                MediaPlayer.Volume += 0.1f;
                GameManager.origVolume = MediaPlayer.Volume;

            }, ButtonType.VolumeUp
            ));
        }

        public override void Load()
        {
            GameManager.currentState = this;
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            mainMenuIntro = content.Load<Song>("MainMenuIntro");
            mainMenuSong = content.Load<Song>("MainMenuLoop");

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
