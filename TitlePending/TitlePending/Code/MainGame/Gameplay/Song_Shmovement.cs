using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

namespace TitlePending.Code.MainGame.Gameplay
{
    public class Song_Shmovement : GameSong
    {

        public Song_Shmovement(Vector2 position) : base(position)
        {

        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            song = content.Load<Song>("ShmoveToTheGroove");
            endtime = (float)song.Duration.TotalSeconds;
        }

        public override void GetSongData(HashSet<float> greenNotesPositions, HashSet<float> redNotesPositions, HashSet<float> yellowNotesPositions,
        HashSet<float> blueNotesPositions, HashSet<float> orangeNotesPositions)
        {
            //EASY DIFFICULTY
            greenNotesPositions.Add(23.25f);
            redNotesPositions.Add(23.62f);
            yellowNotesPositions.Add(24f);
            redNotesPositions.Add(24.56f);
            greenNotesPositions.Add(25.12f);

            redNotesPositions.Add(26.25f);
            yellowNotesPositions.Add(26.62f);
            redNotesPositions.Add(27f);
            redNotesPositions.Add(27.56f);
            greenNotesPositions.Add(28.12f);

            yellowNotesPositions.Add(29.25f);
            redNotesPositions.Add(29.62f);
            greenNotesPositions.Add(30f);
            redNotesPositions.Add(30.56f);
            greenNotesPositions.Add(31.12f);
            greenNotesPositions.Add(31.87f);
            redNotesPositions.Add(32.25f);
            greenNotesPositions.Add(32.62f);

            greenNotesPositions.Add(34.87f);
            redNotesPositions.Add(35.25f);
            yellowNotesPositions.Add(35.62f);
            yellowNotesPositions.Add(36f);
            redNotesPositions.Add(36.56f);
            greenNotesPositions.Add(37.12f);

            redNotesPositions.Add(38.25f);
            yellowNotesPositions.Add(38.62f);
            redNotesPositions.Add(39f);
            redNotesPositions.Add(39.56f);
            greenNotesPositions.Add(40.12f);

            yellowNotesPositions.Add(41.25f);
            redNotesPositions.Add(41.62f);
            greenNotesPositions.Add(42f);
            redNotesPositions.Add(42.56f);
            greenNotesPositions.Add(43.12f);
            redNotesPositions.Add(43.87f);
            yellowNotesPositions.Add(44.25f);
            redNotesPositions.Add(44.62f);

            //bridge
            greenNotesPositions.Add(47.62f);
            redNotesPositions.Add(47.81f);
            yellowNotesPositions.Add(48f);
            greenNotesPositions.Add(49.87f);
            yellowNotesPositions.Add(50.25f);
            redNotesPositions.Add(50.62f);
            greenNotesPositions.Add(51f);
            redNotesPositions.Add(51.18f);
            greenNotesPositions.Add(51.37f);
            yellowNotesPositions.Add(52.12f);
            redNotesPositions.Add(52.12f);
            redNotesPositions.Add(52.68f);
            greenNotesPositions.Add(52.68f);

        }
    }
}
