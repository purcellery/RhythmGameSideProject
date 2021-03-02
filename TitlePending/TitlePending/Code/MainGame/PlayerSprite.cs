using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using TitlePending.Collisions;

namespace TitlePending
{
    public class PlayerSprite
    {
        private Vector2 position;
        private Texture2D texture;
        private float scale;

        public Color Color { get; set; } = Color.Red;
        public bool Past { get; set; } = false;

        private BoundingRectangle bounds;

        public PlayerSprite(Vector2 position)
        {
            this.position = position;
            scale = 0.5f;
        }

        public BoundingRectangle Bounds => bounds;

        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("square");
            this.bounds = new BoundingRectangle(position - new Vector2(texture.Width / 2 * scale, 0), texture.Width * scale, texture.Height * scale);
        }

        public void Update(NoteSprite[] notes, bool pressed)
        {
            foreach(var note in notes)
            {
                if (CollisionHelper.Collides(this.bounds, note.Bounds) && pressed)
                {
                    note.Color = Color.Transparent;
                }
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Past) return;
            spriteBatch.Draw(texture, position - new Vector2(texture.Width / 2 * scale, 0), null, this.Color, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
        }
    }
}
