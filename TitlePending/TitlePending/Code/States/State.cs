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
        public List<GameObject> gameObjects;

        public State(StateID stateID)
        {
            this.stateID = stateID;
            gameObjects = new List<GameObject>();
        }

        public virtual void Initialize()
        {

        }

        public virtual void LoadContent(ContentManager content)
        {
            foreach (GameObject go in gameObjects)
            {
                go.LoadContent(content);
            }
        }

        public virtual void Update() 
        {
            foreach (GameObject go in gameObjects)
            {
                go.Update();
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            foreach (GameObject go in gameObjects)
            {
                go.Draw(spriteBatch);
            }

            spriteBatch.End();
        }

    }
    public enum StateID
    {
        MainMenu,
        OptionMenu,
        SongSelection,
        PlayGame
    }
}
