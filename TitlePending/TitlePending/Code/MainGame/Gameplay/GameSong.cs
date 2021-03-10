using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TitlePending.Code.MainGame;
using TitlePending.Code.MainGame.Gameplay;
using Microsoft.Xna.Framework.Media;

namespace TitlePending.Code.MainGame.Gameplay
{
    public class GameSong : GameObject
    {
        public float BPM;
        public Song song;
        public float timer;

        private SpriteFont youWinFont;
        public Dictionary<NoteColor, HashSet<float>> notes;

        public GameSong(Vector2 position) : base(position)
        {
            this.position = position;
            notes = new Dictionary<NoteColor, HashSet<float>>();
                                                                        //hard coded song

            HashSet<float> greenNotesPositions = new HashSet<float>();
            HashSet<float> redNotesPositions = new HashSet<float>();
            HashSet<float> yellowNotesPositions = new HashSet<float>();

            greenNotesPositions.Add(21.33f);
            redNotesPositions.Add(22.33f);
            greenNotesPositions.Add(23f);
            redNotesPositions.Add(23.33f);
            yellowNotesPositions.Add(24f);
            redNotesPositions.Add(25.33f);

            greenNotesPositions.Add(26.66f);
            redNotesPositions.Add(27f);
            yellowNotesPositions.Add(27.66f);
            redNotesPositions.Add(28.33f);
            greenNotesPositions.Add(28.66f);
            yellowNotesPositions.Add(29.33f);
            greenNotesPositions.Add(30.66f);

            greenNotesPositions.Add(32f);
            redNotesPositions.Add(33);
            greenNotesPositions.Add(33.66f);
            redNotesPositions.Add(34f);
            redNotesPositions.Add(34.66f);
            yellowNotesPositions.Add(36f);

            yellowNotesPositions.Add(37.33f);
            redNotesPositions.Add(37.66f);
            greenNotesPositions.Add(38.33f);
            redNotesPositions.Add(39f);
            yellowNotesPositions.Add(39.33f);
            redNotesPositions.Add(40f);

            yellowNotesPositions.Add(42.66f);
            redNotesPositions.Add(43.33f);
            greenNotesPositions.Add(43.66f);
            redNotesPositions.Add(44.66f);
            greenNotesPositions.Add(45.33f);
            yellowNotesPositions.Add(46.66f);

            greenNotesPositions.Add(48f);
            yellowNotesPositions.Add(49f);
            redNotesPositions.Add(49.66f);
            greenNotesPositions.Add(50f);
            yellowNotesPositions.Add(50.66f);
            redNotesPositions.Add(50.66f);
            redNotesPositions.Add(52f);
            greenNotesPositions.Add(52f);

            greenNotesPositions.Add(52.66f);
            redNotesPositions.Add(53.33f);
            redNotesPositions.Add(55f);
            yellowNotesPositions.Add(55.33f);
            redNotesPositions.Add(55.66f);
            greenNotesPositions.Add(56f);
            greenNotesPositions.Add(56.5f);
            greenNotesPositions.Add(57f);

            greenNotesPositions.Add(58.66f);
            redNotesPositions.Add(59f);
            yellowNotesPositions.Add(59.66f);
            redNotesPositions.Add(60.33f);
            greenNotesPositions.Add(61f);
            redNotesPositions.Add(61.33f);
            yellowNotesPositions.Add(61.66f);
            greenNotesPositions.Add(62.33f);
            yellowNotesPositions.Add(62.33f);

            greenNotesPositions.Add(64f);
            redNotesPositions.Add(65f);
            yellowNotesPositions.Add(66f);
            redNotesPositions.Add(66.33f);
            greenNotesPositions.Add(66.66f);
            redNotesPositions.Add(67.66f);

            greenNotesPositions.Add(69.33f);
            redNotesPositions.Add(69.66f);
            yellowNotesPositions.Add(70.33f);
            redNotesPositions.Add(71f);
            greenNotesPositions.Add(71.66f);
            yellowNotesPositions.Add(72f);
            redNotesPositions.Add(72f);
            redNotesPositions.Add(73.33f);
            greenNotesPositions.Add(73.33f);

            greenNotesPositions.Add(74.66f);
            redNotesPositions.Add(75.66f);
            yellowNotesPositions.Add(76.66f);
            redNotesPositions.Add(77f);
            greenNotesPositions.Add(77.33f);
            redNotesPositions.Add(78.33f);

            greenNotesPositions.Add(80f);
            redNotesPositions.Add(80.33f);
            yellowNotesPositions.Add(81f);
            greenNotesPositions.Add(81.66f);
            yellowNotesPositions.Add(82f);
            redNotesPositions.Add(82f);
            yellowNotesPositions.Add(82.66f);
            greenNotesPositions.Add(82.66f);

                                                    // End Hard Coded Song
            notes.Add(NoteColor.Green, greenNotesPositions);
            notes.Add(NoteColor.Red, redNotesPositions);
            notes.Add(NoteColor.Yellow, yellowNotesPositions);
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            song = content.Load<Song>("nevertheless, one must vibe");
            youWinFont = content.Load<SpriteFont>("arial");
        }

        public override void Update()
        {
            base.Update();
            if (MediaPlayer.PlayPosition.TotalSeconds >= 85.33)
            {
                MediaPlayer.Pause();
            }
        }
        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
            if(MediaPlayer.PlayPosition.TotalSeconds > 85.33)
            {
                batch.DrawString(youWinFont, "You win! Score: " + GameManager.Score.Score.ToString(), new Vector2(GameManager.centerpoint.X, GameManager.centerpoint.Y / 2), Color.MediumPurple);
                //FIX THE FORMATTING HERE
            }
        }
    }
}
