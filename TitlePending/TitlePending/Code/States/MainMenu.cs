using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using TitlePending.Code.MainGame;

namespace TitlePending.Code.States
{
    public class MainMenu : State
    {
        private List<GameObject> gameObjects;
        public MainMenu() : base(StateID.MainMenu)
        {
            gameObjects = new List<GameObject>();
            GameObject backgroundImage = new GameObject(GameManager.centerpoint);
            backgroundImage.earlyContentLoad = (content) =>
            {
                backgroundImage.SetTexture(content.Load<Texture2D>("MainMenu"));
            };
            
        }
        // background, title logo, buttons, song
    }
}
