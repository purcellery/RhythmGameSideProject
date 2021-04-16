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
    public enum SongID
    {
        Shmovement,
        OneMustVibe
    }

    public abstract class GameSong : GameObject
    {
        public float BPM;
        public SongID songID;
        public Song song;
        public float timer;
        public float endtime;

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
            HashSet<float> blueNotesPositions = new HashSet<float>();
            HashSet<float> orangeNotesPositions = new HashSet<float>();

            MediaPlayer.Volume = GameManager.origVolume;
            MediaPlayer.IsRepeating = false;
            GetSongData(greenNotesPositions, redNotesPositions, yellowNotesPositions, blueNotesPositions, orangeNotesPositions);

            notes.Add(NoteColor.Green, greenNotesPositions);
            notes.Add(NoteColor.Red, redNotesPositions);
            notes.Add(NoteColor.Yellow, yellowNotesPositions);
            notes.Add(NoteColor.Blue, blueNotesPositions);
            notes.Add(NoteColor.Orange, orangeNotesPositions);
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            youWinFont = content.Load<SpriteFont>("arial");
        }

        public override void Update()
        {
            base.Update();
            if (MediaPlayer.PlayPosition.TotalSeconds >= endtime)
            {
                MediaPlayer.Pause();
            }
        }
        public override void Draw(SpriteBatch batch)
        {
            base.Draw(batch);
            if(MediaPlayer.PlayPosition.TotalSeconds >= endtime)
            {
                batch.DrawString(youWinFont, "You win! Score: " + GameManager.Score.Score.ToString() + " Press R to play again.\n Press Esc to Exit.", new Vector2(GameManager.centerpoint.X, GameManager.centerpoint.Y / 2), Color.MediumPurple);
                //FIX THE FORMATTING HERE
            }
        }

        public abstract void GetSongData(HashSet<float> greenNotesPositions, HashSet<float> redNotesPositions, HashSet<float> yellowNotesPositions,
            HashSet<float> blueNotesPositions, HashSet<float> orangeNotesPositions);


    }
}
