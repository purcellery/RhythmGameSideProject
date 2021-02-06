using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TitlePending.Collisions;

namespace TitlePending
{
    public class TitlePending : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private InputManager inputManager;

        private PlayerSprite player;
        private int notesLeft;
        private string fillerAdvice;
        private int fillerNumber = 10;
        private NoteSprite[] notes;
        private Vector2 offScreen = new Vector2();

        public Vector2 ScreenSize => new Vector2(_graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);

        public TitlePending()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            notes = new NoteSprite[fillerNumber];
    }

    protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            inputManager = new InputManager();
            for(int i = 0; i < fillerNumber; i++)
            {
                notes[i] = new NoteSprite(new Vector2(ScreenSize.X / 2, i * -200));
            }
            notesLeft = notes.Length;
            player = new PlayerSprite(new Vector2(ScreenSize.X / 2, 300));
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            foreach (var note in notes) note.LoadContent(Content);
            player.LoadContent(Content);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            inputManager.Update(gameTime);

            if (inputManager.Exit) Exit();
            foreach (var note in notes) note.Update(gameTime);
            player.Update(gameTime, notes, inputManager.Pressed);



            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            player.Draw(gameTime, _spriteBatch);
            foreach (var note in notes) note.Draw(gameTime, _spriteBatch); 
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
