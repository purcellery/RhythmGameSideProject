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
        private Action activate;
        public int orderID;
        public ButtonType buttonType;
        
        public Button(Vector2 position, int orderID, Action onClick, ButtonType type) : base(position)
        {
            this.activate = onClick;
            this.orderID = orderID;
            buttonType = type;
        }

        public void CheckClick()
        {
            if(GameManager.currentlySelected == orderID)
            {
                this.color = Color.Gray;
                if (InputManager.SpacePressed)
                {
                    activate();
                }
            }
            else
            {
                this.color = Color.White;
            }
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            
            switch (buttonType)
            {
                case ButtonType.StartGame:
                    texture = content.Load<Texture2D>("StartGame");
                    break;

                case ButtonType.Options:
                    texture = content.Load<Texture2D>("OptionsMenu");
                    break;

                case ButtonType.ExitGame:
                    texture = content.Load<Texture2D>("ExitGame");
                    break;

                case ButtonType.VolumeDown:
                    texture = content.Load<Texture2D>("VolumeDown");
                    break;

                case ButtonType.VolumeUp:
                    texture = content.Load<Texture2D>("VolumeUp");
                    break;
                case ButtonType.Back:
                    texture = content.Load<Texture2D>("Done");
                    break;
            }
        }

        public override void Update()
        {
            CheckClick();
        }
    }
    public enum ButtonType{
        StartGame,
        Options,
        ExitGame,
        VolumeUp,
        VolumeDown,
        Back
    }
}
