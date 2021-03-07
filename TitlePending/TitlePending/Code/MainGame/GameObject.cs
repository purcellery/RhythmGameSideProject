using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TitlePending
{
    public class GameObject
    {
        protected string textureName = "";
        protected Texture2D texture;
        public Vector2 position = Vector2.Zero;
        public Action<ContentManager> earlyContentLoad = (content) => { };
        public float scale = 1;

        public Color color = Color.White;
        public float rotation = 0;

        public GameObject(Vector2 position)
        {
            this.position = position;
        }

        public virtual void LoadContent(ContentManager content)
        {
            earlyContentLoad(content);
        }

        public virtual void Update()
        {

        }

        public virtual void Draw(SpriteBatch batch)
        {
            if(texture != null)
            {
                Vector2 drawPosition = position;
                drawPosition.X -= texture.Width / 2f * scale;
                drawPosition.Y -= texture.Height / 2f * scale;
                batch.Draw(texture, drawPosition, null, color, rotation, Vector2.Zero, scale, SpriteEffects.None, 0);
            }
        }

        public void SetTexture(Texture2D texture)
        {
            this.texture = texture;
        }
    }
}
