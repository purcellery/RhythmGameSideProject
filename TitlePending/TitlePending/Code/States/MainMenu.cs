using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using TitlePending.Code.MainGame;
using TitlePending.Code.MainGame.UI;

namespace TitlePending.Code.States
{
    public class MainMenu : State
    {
        public MainMenu() : base(StateID.MainMenu)
        {
            gameObjects = new List<GameObject>();
            GameObject backgroundImage = new GameObject(GameManager.centerpoint);
            backgroundImage.earlyContentLoad = (content) =>
            {
                backgroundImage.SetTexture(content.Load<Texture2D>("MainMenu"));
            };
            gameObjects.Add(backgroundImage);
            gameObjects.Add(new Button(new Vector2(128, 128), 0, () => {
                GameManager.SwitchState(StateID.PlayGame);
                }
            ));
            
        }
    }
}