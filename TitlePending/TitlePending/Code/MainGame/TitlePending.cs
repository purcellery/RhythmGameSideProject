using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using TitlePending.Code.MainGame;
using TitlePending.Code.MainGame.Gameplay;
using TitlePending.Collisions;
using TitlePending.Code.States;

namespace TitlePending
{
    public class TitlePending : Game
    {
        private Dictionary<StateID, State> states;
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

            states = new Dictionary<StateID, State>();
            states.Add(StateID.MainMenu, new MainMenu());
            states.Add(StateID.OptionMenu, new OptionsMenu());
            states.Add(StateID.SongSelection, new SongSelection());
            states.Add(StateID.PlayGame, new PlayGame());

            foreach(KeyValuePair<StateID, State> s in states)
            {
                s.Value.Initialize();
                s.Value.LoadContent(Content);
            }

            //State menuState = new MainMenu();
            //currentState = menuState;
            //currentState.Initialize();
            //currentState.LoadContent(Content);

            SwitchState(StateID.MainMenu);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            GameManager.songDictionary = new Dictionary<SongID, Song>();
            GameManager.songDictionary.Add(SongID.OneMustVibe, Content.Load<Song>("nevertheless, one must vibe"));
            GameManager.songDictionary.Add(SongID.Shmovement, Content.Load<Song>("ShmoveToTheGroove"));
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
            currentState = states[stateID];

            GameManager.currentState = currentState;

            currentState.Load();

        }
    }
}
