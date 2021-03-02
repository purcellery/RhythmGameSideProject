using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TitlePending.Code.States
{
    public abstract class State
    {
        public StateID stateID;
        public State(StateID stateID)
        {
            this.stateID = stateID;
        }

        protected virtual void Initialize()
        {

        }

        protected virtual void LoadContent(ContentManager content)
        {
            
        }

        protected virtual void Update() 
        {

        }

        protected virtual void Draw(SpriteBatch spriteBatch)
        {

        }

    }
    public enum StateID
    {
        MainMenu,
        OptionMenu,
        SongSelect,
        SongPlay
    }
}
