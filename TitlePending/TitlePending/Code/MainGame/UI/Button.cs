using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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
                if (InputManager.Pressed)
                {
                    onClick();
                }
            }
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
