using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TitlePending.Code.MainGame;
using TitlePending.Code.MainGame.Gameplay;

namespace TitlePending.Code.MainGame.Gameplay
{
    public class GameSong : GameObject
    {
        public float BPM;
        private Dictionary<NoteColor, HashSet<float>> notes;

        public GameSong(Vector2 position) : base(position)
        {
            this.position = position;
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
