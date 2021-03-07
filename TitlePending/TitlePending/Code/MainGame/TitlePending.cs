using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TitlePending.Code.MainGame;
using TitlePending.Collisions;
using TitlePending.Code.States;

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
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.HardwareModeSwitch = false;
            _graphics.ToggleFullScreen();
    }

    protected override void Initialize()
        {
            base.Initialize();
            State menuState = new MainMenu();
            currentState = menuState;
            currentState.Initialize();
            currentState.LoadContent(Content);
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

            currentState.Update();



            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            currentState.Draw(_spriteBatch);

            base.Draw(gameTime);
        }

        public void SwitchState(StateID stateID)
        {
            switch (stateID)
            {
                case StateID.MainMenu:
                    currentState = new MainMenu();
                    break;

                case StateID.OptionMenu:
                    currentState = new OptionsMenu();
                    break;

                case StateID.SongSelection:
                    currentState = new SongSelection();
                    break;

                case StateID.PlayGame:
                    currentState = new PlayGame();
                    break;
            }
            GameManager.currentState = currentState;
            currentState.Initialize();
            currentState.LoadContent(Content);


        }
    }
}
