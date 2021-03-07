using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TitlePending.Collisions;

namespace TitlePending.Code.MainGame.Gameplay
{
    public class NoteHitter : GameObject
    {
        public NoteColor hitterType;

        private BoundingRectangle bounds;
        public bool Past { get; set; } = false;

        public delegate bool BoolReturner();
        public BoolReturner onTrigger;

        private Texture2D darkTexture;
        private Texture2D lightTexture;
        public NoteHitter(Vector2 position) : base(position)
        {
            scale = 0.5f;
        }
        public BoundingRectangle Bounds => bounds;

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            lightTexture = content.Load<Texture2D>("square");
            darkTexture = content.Load<Texture2D>("darksquare");
            texture = lightTexture;
            this.bounds = new BoundingRectangle(position - new Vector2(texture.Width / 2 * scale, 0), texture.Width * scale, texture.Height * scale);
        }
        public override void Update()
        {
            base.Update();

            if (onTrigger())
            {
                texture = darkTexture;
                if (InputManager.SpacePressed)
                {

                }
            }
            else
            {
                texture = lightTexture;
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (Past) return;
            base.Draw(spriteBatch);
        }
    }
}
