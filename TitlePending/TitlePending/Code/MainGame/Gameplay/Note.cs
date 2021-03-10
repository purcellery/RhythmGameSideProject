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
        public bool RegisteredPast { get; set; } = false;

        private BoundingRectangle bounds;

        public float originalScale = 0.25f;
        public float finalScale = 0.5f;
        public Vector2 noteOrigin;
        public Vector2 noteDestination;

        private float progression = 0;
        public static float testSpeed = 1.8f;

        private float timer = 0;
        private bool done = false;


        public Note(Vector2 position, NoteColor color): base(position)
        {
            scale = originalScale;
            switch (color)
            {
                case NoteColor.Green:
                    noteOrigin = GameManager.GreenOrigin;
                    noteDestination = GameManager.GreenHitter;
                    this.color = Color.SpringGreen;
                    break;
                case NoteColor.Red:
                    noteOrigin = GameManager.RedOrigin;
                    noteDestination = GameManager.RedHitter;
                    this.color = Color.Red;
                    break;
                case NoteColor.Yellow:
                    noteOrigin = GameManager.YellowOrigin;
                    noteDestination = GameManager.YellowHitter;
                    this.color = Color.Yellow;
                    break;
                case NoteColor.Blue:
                    noteOrigin = GameManager.BlueOrigin;
                    noteDestination = GameManager.BlueHitter;
                    this.color = Color.RoyalBlue;
                    break;
                case NoteColor.Orange:
                    noteOrigin = GameManager.OrangeOrigin;
                    noteDestination = GameManager.OrangeHitter;
                    this.color = Color.MonoGameOrange;
                    break;
            }

            this.position = noteOrigin;
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

            progression += Time.deltaTime;
            position = Vector2.Lerp(noteOrigin, noteDestination, progression/testSpeed);
            float distanceFraction = Vector2.Distance(position, noteDestination) / Vector2.Distance(noteOrigin, noteDestination);

            bool localDone = distanceFraction <= 0.01f;

            if (localDone)
            {
                done = true;
                scale = finalScale;
            }

            if (scale < finalScale && !done)
            {
                scale = MathHelper.Lerp(finalScale, originalScale, distanceFraction);
            }
            if (scale == finalScale) 
            {
                timer += Time.deltaTime;
            }

            CheckPast();
            this.Bounds.ResetValues(position, texture.Bounds.Size.ToVector2() * scale);

        }

        public void CheckPast()
        {
            if(timer >= 1)
            {
                //if note misses
                this.Past = true;
                GameManager.Score.NotesHitInARow = 0;
                GameManager.Score.Multiplier = 1;
                this.RegisteredPast = true;

                // FIX THIS LATER
                GameManager.currentState.RemoveObject(this);
            }
        }
    }
    public enum NoteColor
    {
        Green, Red, Yellow, Blue, Orange
    };
}
