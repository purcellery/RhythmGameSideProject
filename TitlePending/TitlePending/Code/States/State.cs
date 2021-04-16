using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TitlePending
{
    public abstract class State
    {
        public StateID stateID;
        public List<GameObject> gameObjects;
        private List<GameObject> deleteQueue;

        public State(StateID stateID)
        {
            this.stateID = stateID;
            gameObjects = new List<GameObject>();
            deleteQueue = new List<GameObject>();
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
            while (deleteQueue.Count > 0)
            {
                gameObjects.Remove(deleteQueue[0]);
                deleteQueue.RemoveAt(0);
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

        public void RemoveObject(GameObject thing)
        {
            deleteQueue.Add(thing);
        }

        public virtual void Load()
        {

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
