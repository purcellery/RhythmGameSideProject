using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TitlePending.Code.MainGame;

namespace TitlePending.Code.States
{
    public class SongSelection : State
    {
        private List<GameObject> gameObjects;
        public SongSelection() : base(StateID.MainMenu)
        {
            gameObjects = new List<GameObject>();
            GameObject backgroundImage = new GameObject(GameManager.centerpoint);
            backgroundImage.earlyContentLoad = (content) =>
            {
                backgroundImage.SetTexture(content.Load<Texture2D>("MainMenu"));
            };

        }
    }
}