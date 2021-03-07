using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace TitlePending.Code.MainGame.UI
{
    public class Button : GameObject
    {
        private Action onClick;
        public int orderID;
        
        public Button(Vector2 position, int orderID, Action onClick) : base(position)
        {
            this.onClick = onClick;
            this.orderID = orderID;
        }

        public void CheckClick()
        {
            if(GameManager.currentlySelected == orderID)
            {
                if (InputManager.SpacePressed)
                {
                    onClick();
                }
            }
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            texture = content.Load<Texture2D>("PlaceholderButton");
        }

        public override void Update()
        {
            CheckClick();
        }
    }
    //public enum Buttons{
    //    StartGame,
    //    Options,
    //    ExitGame,

    //}
}
