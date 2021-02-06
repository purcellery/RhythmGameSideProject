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
    public class NoteSprite
    {
        private Vector2 position;
        private Texture2D texture;
        private float scale;

        public Color Color { get; set; } = Color.White;

        public bool Past { get; set; } = false;

        private BoundingRectangle bounds;

        public NoteSprite(Vector2 position)
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

        public void Update(GameTime gameTime)
        {
            position += new Vector2(0, 10);
            Vector2 v = position - new Vector2(texture.Width / 2 * scale, 0);
            this.bounds.X = v.X;
            this.bounds.Y = v.Y;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //if (Past) return;
            //spriteBatch.Draw(texture, position, Color.White);
            spriteBatch.Draw(texture, position - new Vector2(texture.Width/2 * scale, 0), null, this.Color, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
        }
    }
}
