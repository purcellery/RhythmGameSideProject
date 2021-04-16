using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TitlePending.Code.MainGame;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using TitlePending.Code.MainGame.UI;
using TitlePending.Code.MainGame.Gameplay;

namespace TitlePending.Code.States
{
    public class SongSelection : State
    {
        float fadeTime = 1.0f;

        public SongSelection() : base(StateID.SongSelection)
        {


            gameObjects = new List<GameObject>();
            GameObject backgroundImage = new GameObject(GameManager.centerpoint);
            backgroundImage.earlyContentLoad = (content) =>
            {
                backgroundImage.SetTexture(content.Load<Texture2D>("MainMenu"));
            };
            gameObjects.Add(backgroundImage);

            gameObjects.Add(new Button(new Vector2(GameManager.centerpoint.X, GameManager.centerpoint.Y), 0, () =>
            {
                GameManager.selectedSongID = MainGame.Gameplay.SongID.OneMustVibe;
                GameManager.SwitchState(StateID.PlayGame);
            }, ButtonType.OneMustVibe
            ));

            gameObjects.Add(new Button(new Vector2(GameManager.centerpoint.X, GameManager.centerpoint.Y + 100), 1, () =>
            {
                GameManager.selectedSongID = MainGame.Gameplay.SongID.Shmovement;
                GameManager.SwitchState(StateID.PlayGame);
            }, ButtonType.Shmovement
            ));

            gameObjects.Add(new Button(new Vector2(GameManager.centerpoint.X, GameManager.centerpoint.Y + 300), 2, () =>
            {
               // GameManager.currentlySelected = GameManager.currentlySelected
                GameManager.SwitchState(StateID.MainMenu);
                //((MainMenu)GameManager.currentState).playAfterBack();
            }, ButtonType.Back
            ));

        }

        public override void Load()
        {
            GameManager.currentState = this;
            GameManager.currentlySelected = 0;
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
        }

        public override void Update()
        {
            base.Update();

            /*if(MediaPlayer.PlayPosition.TotalSeconds <= GameManager.minPreviewTime + fadeTime)
            {
                MediaPlayer.Volume = GameManager.origVolume * ( (float) MediaPlayer.PlayPosition.TotalSeconds - GameManager.minPreviewTime) / fadeTime;
            }
            if (MediaPlayer.PlayPosition.TotalSeconds >= GameManager.maxPreviewTime - fadeTime)
            {
                MediaPlayer.Volume = GameManager.origVolume * (GameManager.maxPreviewTime - (float)MediaPlayer.PlayPosition.TotalSeconds) / fadeTime;
            }

            if (MediaPlayer.PlayPosition.TotalSeconds >= GameManager.maxPreviewTime)
            {
                GameManager.currentlySelected = GameManager.currentlySelected;

            }*/
        }
    }

}