using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TitlePending.Collisions;

namespace TitlePending.Code.MainGame.Gameplay
{
    public class Note : GameObject
    {
        public bool Past { get; set; } = false;

        private BoundingRectangle bounds;

        public Note(Vector2 position): base(position)
        {
            scale = 0.5f;
        }
        public BoundingRectangle Bounds => bounds;

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            texture = content.Load<Texture2D>("square");
            this.bounds = new BoundingRectangle(position - new Vector2(texture.Width / 2 * scale, 0), texture.Width * scale, texture.Height * scale);
        }

        public override void Update()
        {
            base.Update();
            this.Bounds.ResetValues(position, texture.Bounds.Size.ToVector2() * scale);

        }
    }
    public enum NoteColor
    {
        Green, Red, Yellow, Blue, Orange
    };
}
