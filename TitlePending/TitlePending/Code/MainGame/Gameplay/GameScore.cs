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
    public class GameScore : GameObject
    {
        private SpriteFont scoreFont;
        public int Score { get; set; }
        public int NotesHitInARow { get; set; }

        public int Multiplier { get; set; }
        public GameScore(Vector2 position) : base(position)
        {
            this.position = new Vector2((GameManager.centerpoint.X / 2) - 100f, GameManager.centerpoint.Y);
            this.Score = 0;
            this.NotesHitInARow = 0;
            this.Multiplier = 1;
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            scoreFont = content.Load<SpriteFont>("arial");      // CHANGE LATER
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
            batch.DrawString(scoreFont, this.Score.ToString(), position, Color.MediumPurple);
        }
    }
}
