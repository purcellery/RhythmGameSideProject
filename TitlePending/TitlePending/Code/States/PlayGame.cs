using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TitlePending.Code.MainGame;

namespace TitlePending.Code.States
{
    public class PlayGame : State
    {
        private List<GameObject> gameObjects;
        private PlayerSprite player;
        private int notesLeft;
        private string fillerAdvice;
        private int fillerNumber = 10;
        private NoteSprite[] notes;
        private Vector2 offScreen = new Vector2();

        public PlayGame() : base(StateID.MainMenu)
        {
            gameObjects = new List<GameObject>();
            GameObject backgroundImage = new GameObject(GameManager.centerpoint);
            backgroundImage.earlyContentLoad = (content) =>
            {
                backgroundImage.SetTexture(content.Load<Texture2D>("MainMenu"));
            };
            notes = new NoteSprite[fillerNumber];
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            for (int i = 0; i < fillerNumber; i++)
            {
                notes[i] = new NoteSprite(new Vector2(GameManager.ScreenSize.X / 2, i * -200));
            }
            notesLeft = notes.Length;
            player = new PlayerSprite(new Vector2(GameManager.ScreenSize.X / 2, 300));
        }

        protected override void LoadContent(ContentManager content)
        {
            foreach (var note in notes) note.LoadContent(content);
            player.LoadContent(content);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update()
        {
            foreach (var note in notes) note.Update();
            player.Update(notes, InputManager.Pressed);
        }

        protected override void Draw(SpriteBatch spriteBatch)
        {
            player.Draw(spriteBatch);
            foreach (var note in notes) note.Draw(spriteBatch);
        }
    }
}
