using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

namespace TitlePending.Code.MainGame.Gameplay
{
    public class Song_OneMustVibe : GameSong
    {

        public Song_OneMustVibe(Vector2 position) : base(position)
        {

        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            song = content.Load<Song>("nevertheless, one must vibe");
            endtime = (float)song.Duration.TotalSeconds;
        }

        public override void GetSongData(HashSet<float> greenNotesPositions, HashSet<float> redNotesPositions, HashSet<float> yellowNotesPositions,
    HashSet<float> blueNotesPositions, HashSet<float> orangeNotesPositions)
        {
            // Hard Coded Song (EASY)

            // verse 1
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


            //bridge
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

            //chorus 1

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


            //chorus 1 -- 2  
            greenNotesPositions.Add(85.33f);
            redNotesPositions.Add(86.33f);
            yellowNotesPositions.Add(87.33f);
            redNotesPositions.Add(87.66f);
            greenNotesPositions.Add(88f);
            redNotesPositions.Add(89f);

            greenNotesPositions.Add(90.66f);
            redNotesPositions.Add(91f);
            yellowNotesPositions.Add(70.33f + 21.33f);
            redNotesPositions.Add(71f + 21.33f);
            greenNotesPositions.Add(71.66f + 21.33f);
            yellowNotesPositions.Add(72f + 21.33f);
            redNotesPositions.Add(72f + 21.33f);
            redNotesPositions.Add(73.33f + 21.33f);
            greenNotesPositions.Add(73.33f + 21.33f);

            greenNotesPositions.Add(74.66f + 21.33f);
            redNotesPositions.Add(75.66f + 21.33f);
            yellowNotesPositions.Add(76.66f + 21.33f);
            redNotesPositions.Add(77f + 21.33f);
            greenNotesPositions.Add(77.33f + 21.33f);
            redNotesPositions.Add(78.33f + 21.33f);

            greenNotesPositions.Add(80f + 21.33f);
            redNotesPositions.Add(80.33f + 21.33f);
            yellowNotesPositions.Add(81f + 21.33f);
            greenNotesPositions.Add(81.66f + 21.33f);
            yellowNotesPositions.Add(82f + 21.33f);
            redNotesPositions.Add(82f + 21.33f);
            yellowNotesPositions.Add(104f);
            greenNotesPositions.Add(104f);

            //verse 2

            yellowNotesPositions.Add(106.66f);
            redNotesPositions.Add(107f);
            greenNotesPositions.Add(107.66f);
            redNotesPositions.Add(108.66f);
            yellowNotesPositions.Add(109f);
            redNotesPositions.Add(109.33f);
            yellowNotesPositions.Add(110f);
            redNotesPositions.Add(110.33f);
            greenNotesPositions.Add(111f);

            greenNotesPositions.Add(112f);
            yellowNotesPositions.Add(112.33f);
            redNotesPositions.Add(113f);
            greenNotesPositions.Add(113.66f);
            redNotesPositions.Add(114f);
            yellowNotesPositions.Add(114.66f);
            redNotesPositions.Add(114.66f);
            redNotesPositions.Add(116f);
            greenNotesPositions.Add(116f);

            yellowNotesPositions.Add(106.66f + 10.66f);
            redNotesPositions.Add(107f + 10.66f);
            greenNotesPositions.Add(107.66f + 10.66f);
            redNotesPositions.Add(108.66f + 10.66f);
            yellowNotesPositions.Add(109f + 10.66f);
            redNotesPositions.Add(109.33f + 10.66f);
            yellowNotesPositions.Add(110f + 10.66f);
            redNotesPositions.Add(110.33f + 10.66f);
            greenNotesPositions.Add(111f + 10.66f);

            greenNotesPositions.Add(112f + 10.66f);
            yellowNotesPositions.Add(112.33f + 10.66f);
            redNotesPositions.Add(112.66f + 10.66f);
            greenNotesPositions.Add(113f + 10.66f);
            redNotesPositions.Add(124.33f);
            yellowNotesPositions.Add(124.66f);
            redNotesPositions.Add(124.66f);
            redNotesPositions.Add(125.33f);
            greenNotesPositions.Add(125.33f);

            //bridge 2
            yellowNotesPositions.Add(42.66f + 85.33f);
            redNotesPositions.Add(43.33f + 85.33f);
            greenNotesPositions.Add(43.66f + 85.33f);
            redNotesPositions.Add(44.66f + 85.33f);
            greenNotesPositions.Add(45.33f + 85.33f);
            yellowNotesPositions.Add(46.66f + 85.33f);

            greenNotesPositions.Add(48f + 85.33f);
            yellowNotesPositions.Add(49f + 85.33f);
            redNotesPositions.Add(49.66f + 85.33f);
            greenNotesPositions.Add(50f + 85.33f);
            yellowNotesPositions.Add(50.66f + 85.33f);
            redNotesPositions.Add(50.66f + 85.33f);
            redNotesPositions.Add(52f + 85.33f);
            greenNotesPositions.Add(52f + 85.33f);

            greenNotesPositions.Add(52.66f + 85.33f);
            redNotesPositions.Add(53.33f + 85.33f);
            redNotesPositions.Add(55f + 85.33f);
            yellowNotesPositions.Add(55.33f + 85.33f);
            redNotesPositions.Add(55.66f + 85.33f);
            greenNotesPositions.Add(56f + 85.33f);
            greenNotesPositions.Add(56.5f + 85.33f);
            greenNotesPositions.Add(57f + 85.33f);

            greenNotesPositions.Add(58.66f + 85.33f);
            redNotesPositions.Add(59f + 85.33f);
            yellowNotesPositions.Add(59.66f + 85.33f);
            redNotesPositions.Add(60.33f + 85.33f);
            greenNotesPositions.Add(61f + 85.33f);
            redNotesPositions.Add(61.33f + 85.33f);
            yellowNotesPositions.Add(61.66f + 85.33f);
            greenNotesPositions.Add(62.33f + 85.33f);
            yellowNotesPositions.Add(62.33f + 85.33f);

            //chorus 2
            greenNotesPositions.Add(64f + 85.33f);
            redNotesPositions.Add(65f + 85.33f);
            yellowNotesPositions.Add(66f + 85.33f);
            redNotesPositions.Add(66.33f + 85.33f);
            greenNotesPositions.Add(66.66f + 85.33f);
            redNotesPositions.Add(67.66f + 85.33f);

            greenNotesPositions.Add(69.33f + 85.33f);
            redNotesPositions.Add(69.66f + 85.33f);
            yellowNotesPositions.Add(70.33f + 85.33f);
            redNotesPositions.Add(71f + 85.33f);
            greenNotesPositions.Add(71.66f + 85.33f);
            yellowNotesPositions.Add(72f + 85.33f);
            redNotesPositions.Add(72f + 85.33f);
            redNotesPositions.Add(73.33f + 85.33f);
            greenNotesPositions.Add(73.33f + 85.33f);

            greenNotesPositions.Add(74.66f + 85.33f);
            redNotesPositions.Add(75.66f + 85.33f);
            yellowNotesPositions.Add(76.66f + 85.33f);
            redNotesPositions.Add(77f + 85.33f);
            greenNotesPositions.Add(77.33f + 85.33f);
            redNotesPositions.Add(78.33f + 85.33f);

            greenNotesPositions.Add(80f + 85.33f);
            redNotesPositions.Add(80.33f + 85.33f);
            yellowNotesPositions.Add(81f + 85.33f);
            greenNotesPositions.Add(81.66f + 85.33f);
            yellowNotesPositions.Add(82f + 85.33f);
            redNotesPositions.Add(82f + 85.33f);
            yellowNotesPositions.Add(82.66f + 85.33f);
            greenNotesPositions.Add(82.66f + 85.33f);

            //chorus 2 -- 2

            greenNotesPositions.Add(64f + 106.66f);
            redNotesPositions.Add(65f + 106.66f);
            yellowNotesPositions.Add(66f + 106.66f);
            redNotesPositions.Add(66.33f + 106.66f);
            greenNotesPositions.Add(66.66f + 106.66f);
            redNotesPositions.Add(67.66f + 106.66f);

            greenNotesPositions.Add(69.33f + 106.66f);
            redNotesPositions.Add(69.66f + 106.66f);
            yellowNotesPositions.Add(70.33f + 106.66f);
            redNotesPositions.Add(71f + 106.66f);
            greenNotesPositions.Add(71.66f + 106.66f);
            yellowNotesPositions.Add(72f + 106.66f);
            redNotesPositions.Add(72f + 106.66f);
            redNotesPositions.Add(73.33f + 106.66f);
            greenNotesPositions.Add(73.33f + 106.66f);

            greenNotesPositions.Add(74.66f + 106.66f);
            redNotesPositions.Add(75.66f + 106.66f);
            yellowNotesPositions.Add(76.66f + 106.66f);
            redNotesPositions.Add(77f + 106.66f);
            greenNotesPositions.Add(77.33f + 106.66f);
            redNotesPositions.Add(78.33f + 106.66f);

            greenNotesPositions.Add(80f + 106.66f);
            redNotesPositions.Add(80.33f + 106.66f);
            yellowNotesPositions.Add(81f + 106.66f);
            greenNotesPositions.Add(81.66f + 106.66f);
            yellowNotesPositions.Add(82f + 106.66f);
            redNotesPositions.Add(82f + 106.66f);
            yellowNotesPositions.Add(82.66f + 106.66f);
            greenNotesPositions.Add(82.66f + 106.66f);

            // chorus 2 -- 3

            greenNotesPositions.Add(64f + 128f);
            redNotesPositions.Add(65f + 128f);
            yellowNotesPositions.Add(66f + 128f);
            redNotesPositions.Add(66.33f + 128f);
            greenNotesPositions.Add(66.66f + 128f);
            redNotesPositions.Add(67.66f + 128f);

            greenNotesPositions.Add(69.33f + 128f);
            redNotesPositions.Add(69.66f + 128f);
            yellowNotesPositions.Add(70.33f + 128f);
            redNotesPositions.Add(71f + 128f);
            greenNotesPositions.Add(71.66f + 128f);
            yellowNotesPositions.Add(72f + 128f);
            redNotesPositions.Add(72f + 128f);
            redNotesPositions.Add(73.33f + 128f);
            greenNotesPositions.Add(73.33f + 128f);

            greenNotesPositions.Add(74.66f + 128f);
            redNotesPositions.Add(75.66f + 128f);
            yellowNotesPositions.Add(76.66f + 128f);
            redNotesPositions.Add(77f + 128f);
            greenNotesPositions.Add(77.33f + 128f);
            redNotesPositions.Add(78.33f + 128f);

            greenNotesPositions.Add(80f + 128f);
            redNotesPositions.Add(80.33f + 128f);
            yellowNotesPositions.Add(81f + 128f);
            greenNotesPositions.Add(81.66f + 128f);
            yellowNotesPositions.Add(82f + 128f);
            redNotesPositions.Add(82f + 128f);
            yellowNotesPositions.Add(82.66f + 128f);
            greenNotesPositions.Add(82.66f + 128f);
            // End Hard Coded Song (EASY)

        }
    }
}
