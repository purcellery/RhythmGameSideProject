using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.XInput;
using TitlePending.Code.MainGame;
using TitlePending.Collisions;

namespace TitlePending
{
    public class TitlePending : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private State currentState;

        public Vector2 ScreenSize => new Vector2(_graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);

        public TitlePending()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            GameManager.gameCore = this;
    }

    protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            Time.SetDeltaTime(gameTime);
            InputManager.Update(gameTime);
            
            if (InputManager.Exit) Exit();



            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
