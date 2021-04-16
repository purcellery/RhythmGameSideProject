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

            //verse 1
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
            greenNotesPositions.Add(43.87f);
            redNotesPositions.Add(43.87f);
            yellowNotesPositions.Add(44.25f);
            redNotesPositions.Add(44.25f);
            redNotesPositions.Add(44.62f);
            greenNotesPositions.Add(44.62f);

            //bridge 1
            greenNotesPositions.Add(47.62f);
            redNotesPositions.Add(47.81f);
            yellowNotesPositions.Add(48f);
            greenNotesPositions.Add(49.87f);
            yellowNotesPositions.Add(50.25f);
            redNotesPositions.Add(50.62f);
            greenNotesPositions.Add(51f);
            redNotesPositions.Add(51.18f);
            greenNotesPositions.Add(51.37f);
            redNotesPositions.Add(52.12f);
            greenNotesPositions.Add(52.68f);

            greenNotesPositions.Add(53.62f);
            redNotesPositions.Add(53.81f);
            yellowNotesPositions.Add(54f);
            greenNotesPositions.Add(55.87f);
            redNotesPositions.Add(56.25f);
            redNotesPositions.Add(56.62f);
            yellowNotesPositions.Add(57f);
            redNotesPositions.Add(58.12f); 
            greenNotesPositions.Add(58.5f);

            //chorus 1
            greenNotesPositions.Add(59.62f);
            yellowNotesPositions.Add(59.81f);
            redNotesPositions.Add(60f);
            greenNotesPositions.Add(60.56f);
            redNotesPositions.Add(60.75f);
            yellowNotesPositions.Add(61.12f);
            yellowNotesPositions.Add(61.87f);
            redNotesPositions.Add(62.25f);
            greenNotesPositions.Add(62.62f);
            redNotesPositions.Add(63f);
            yellowNotesPositions.Add(63.18f);
            redNotesPositions.Add(63.37f);
            redNotesPositions.Add(64.12f);
            greenNotesPositions.Add(64.68f);

            greenNotesPositions.Add(65.62f);
            yellowNotesPositions.Add(65.81f);
            redNotesPositions.Add(66f);
            greenNotesPositions.Add(66.56f);
            redNotesPositions.Add(66.75f);
            yellowNotesPositions.Add(67.12f);
            yellowNotesPositions.Add(67.87f);
            yellowNotesPositions.Add(68.25f);
            yellowNotesPositions.Add(68.62f);
            redNotesPositions.Add(69f);
            yellowNotesPositions.Add(69.18f);
            redNotesPositions.Add(69.37f);
            redNotesPositions.Add(70.12f);
            greenNotesPositions.Add(70.68f);

            //chorus 1 -- 2
            greenNotesPositions.Add(59.62f + 12f);
            yellowNotesPositions.Add(59.81f + 12f);
            redNotesPositions.Add(60f + 12f);
            greenNotesPositions.Add(60.56f + 12f);
            redNotesPositions.Add(60.75f + 12f);
            yellowNotesPositions.Add(61.12f + 12f);
            yellowNotesPositions.Add(61.87f + 12f);
            redNotesPositions.Add(62.25f + 12f);
            greenNotesPositions.Add(62.62f + 12f);
            redNotesPositions.Add(63f + 12f);
            yellowNotesPositions.Add(63.18f + 12f);
            redNotesPositions.Add(63.37f + 12f);
            redNotesPositions.Add(64.12f + 12f);
            greenNotesPositions.Add(64.68f + 12f);

            greenNotesPositions.Add(65.62f + 12f);
            yellowNotesPositions.Add(65.81f + 12f);
            redNotesPositions.Add(66f + 12f);
            greenNotesPositions.Add(66.56f + 12f);
            redNotesPositions.Add(66.75f + 12f);
            yellowNotesPositions.Add(67.12f + 12f);
            yellowNotesPositions.Add(67.87f + 12f);
            yellowNotesPositions.Add(68.25f + 12f);
            yellowNotesPositions.Add(68.62f + 12f);
            redNotesPositions.Add(69f + 12f);
            yellowNotesPositions.Add(69.18f + 12f);
            redNotesPositions.Add(69.37f + 12f);
            redNotesPositions.Add(70.12f + 12f);
            greenNotesPositions.Add(70.68f + 12f);

            //verse 2 + 60f
            yellowNotesPositions.Add(83.25f);
            redNotesPositions.Add(83.62f);
            yellowNotesPositions.Add(24f + 60f);
            redNotesPositions.Add(24.56f + 60f);
            greenNotesPositions.Add(25.12f + 60f);

            redNotesPositions.Add(26.25f + 60f);
            yellowNotesPositions.Add(26.62f + 60f);
            redNotesPositions.Add(27f + 60f);
            redNotesPositions.Add(27.56f + 60f);
            greenNotesPositions.Add(28.12f + 60f);

            yellowNotesPositions.Add(29.25f + 60f);
            redNotesPositions.Add(29.62f + 60f);
            greenNotesPositions.Add(30f + 60f);
            redNotesPositions.Add(30.56f + 60f);
            greenNotesPositions.Add(31.12f + 60f);
            greenNotesPositions.Add(31.87f + 60f);
            redNotesPositions.Add(32.25f + 60f);
            greenNotesPositions.Add(32.62f + 60f);

            greenNotesPositions.Add(34.87f + 60f);
            redNotesPositions.Add(35.25f + 60f);
            yellowNotesPositions.Add(35.62f + 60f);
            yellowNotesPositions.Add(36f + 60f);
            redNotesPositions.Add(36.56f + 60f);
            greenNotesPositions.Add(37.12f + 60f);

            redNotesPositions.Add(38.25f + 60f);
            yellowNotesPositions.Add(38.62f + 60f);
            redNotesPositions.Add(39f + 60f);
            redNotesPositions.Add(39.56f + 60f);
            greenNotesPositions.Add(40.12f + 60f);

            yellowNotesPositions.Add(41.25f + 60f);
            redNotesPositions.Add(41.62f + 60f);
            greenNotesPositions.Add(42f + 60f);
            redNotesPositions.Add(42.56f + 60f);
            greenNotesPositions.Add(43.12f + 60f);
            greenNotesPositions.Add(43.87f + 60f);
            redNotesPositions.Add(43.87f + 60f);
            yellowNotesPositions.Add(44.25f + 60f);
            redNotesPositions.Add(44.25f + 60f);
            redNotesPositions.Add(44.62f + 60f);
            greenNotesPositions.Add(44.62f + 60f);

            //bridge 2
            greenNotesPositions.Add(47.62f + 60f);
            redNotesPositions.Add(47.81f + 60f);
            yellowNotesPositions.Add(48f + 60f);
            greenNotesPositions.Add(49.87f + 60f);
            yellowNotesPositions.Add(50.25f + 60f);
            redNotesPositions.Add(50.62f + 60f);
            greenNotesPositions.Add(51f + 60f);
            redNotesPositions.Add(51.18f + 60f);
            greenNotesPositions.Add(51.37f + 60f);
            redNotesPositions.Add(52.12f + 60f);
            greenNotesPositions.Add(52.68f + 60f);

            greenNotesPositions.Add(53.62f + 60f);
            redNotesPositions.Add(53.81f + 60f);
            yellowNotesPositions.Add(54f + 60f);
            greenNotesPositions.Add(55.87f + 60f);
            redNotesPositions.Add(56.25f + 60f);
            redNotesPositions.Add(56.62f + 60f);
            yellowNotesPositions.Add(57f + 60f);
            redNotesPositions.Add(58.12f + 60f);
            greenNotesPositions.Add(58.5f + 60f);

            // chorus 2
            greenNotesPositions.Add(59.62f + 60f);
            yellowNotesPositions.Add(59.81f + 60f);
            redNotesPositions.Add(60f + 60f);
            greenNotesPositions.Add(60.56f + 60f);
            redNotesPositions.Add(60.75f + 60f);
            yellowNotesPositions.Add(61.12f + 60f);
            yellowNotesPositions.Add(61.87f + 60f);
            redNotesPositions.Add(62.25f + 60f);
            greenNotesPositions.Add(62.62f + 60f);
            redNotesPositions.Add(63f + 60f);
            yellowNotesPositions.Add(63.18f + 60f);
            redNotesPositions.Add(63.37f + 60f);
            redNotesPositions.Add(64.12f + 60f);
            greenNotesPositions.Add(64.68f + 60f);

            greenNotesPositions.Add(65.62f + 60f);
            yellowNotesPositions.Add(65.81f + 60f);
            redNotesPositions.Add(66f + 60f);
            greenNotesPositions.Add(66.56f + 60f);
            redNotesPositions.Add(66.75f + 60f);
            yellowNotesPositions.Add(67.12f + 60f);
            yellowNotesPositions.Add(67.87f + 60f);
            yellowNotesPositions.Add(68.25f + 60f);
            yellowNotesPositions.Add(68.62f + 60f);
            redNotesPositions.Add(69f + 60f);
            yellowNotesPositions.Add(69.18f + 60f);
            redNotesPositions.Add(69.37f + 60f);
            redNotesPositions.Add(70.12f + 60f);
            greenNotesPositions.Add(70.68f + 60f);

            //chorus 2 -- 2
            greenNotesPositions.Add(59.62f + 60f + 12f);
            yellowNotesPositions.Add(59.81f + 60f + 12f);
            redNotesPositions.Add(60f + 60f + 12f);
            greenNotesPositions.Add(60.56f + 60f + 12f);
            redNotesPositions.Add(60.75f + 60f + 12f);
            yellowNotesPositions.Add(61.12f + 60f + 12f);
            yellowNotesPositions.Add(61.87f + 60f + 12f);
            redNotesPositions.Add(62.25f + 60f + 12f);
            greenNotesPositions.Add(62.62f + 60f + 12f);
            redNotesPositions.Add(63f + 60f + 12f);
            yellowNotesPositions.Add(63.18f + 60f + 12f);
            redNotesPositions.Add(63.37f + 60f + 12f);
            redNotesPositions.Add(64.12f + 60f + 12f);
            greenNotesPositions.Add(64.68f + 60f + 12f);

            greenNotesPositions.Add(65.62f + 60f + 12f);
            yellowNotesPositions.Add(65.81f + 60f + 12f);
            redNotesPositions.Add(66f + 60f + 12f);
            greenNotesPositions.Add(66.56f + 60f + 12f);
            redNotesPositions.Add(66.75f + 60f + 12f);
            yellowNotesPositions.Add(67.12f + 60f + 12f);
            yellowNotesPositions.Add(67.87f + 60f + 12f);
            yellowNotesPositions.Add(68.25f + 60f + 12f);
            yellowNotesPositions.Add(68.62f + 60f + 12f);
            redNotesPositions.Add(69f + 60f + 12f);
            yellowNotesPositions.Add(69.18f + 60f + 12f);
            redNotesPositions.Add(69.37f + 60f + 12f);
            redNotesPositions.Add(70.12f + 60f + 12f);
            greenNotesPositions.Add(70.68f + 60f + 12f);

            //bridge 3
            greenNotesPositions.Add(47.62f + 96f);
            redNotesPositions.Add(47.81f + 96f);
            yellowNotesPositions.Add(48f + 96f);
            greenNotesPositions.Add(49.87f + 96f);
            yellowNotesPositions.Add(50.25f + 96f);
            redNotesPositions.Add(50.62f + 96f);
            greenNotesPositions.Add(51f + 96f);
            redNotesPositions.Add(51.18f + 96f);
            greenNotesPositions.Add(51.37f + 96f);
            redNotesPositions.Add(52.12f + 96f);
            yellowNotesPositions.Add(52.12f + 96f);
            greenNotesPositions.Add(52.68f + 96f);
            yellowNotesPositions.Add(52.68f + 96f);

            greenNotesPositions.Add(53.62f + 96f);
            redNotesPositions.Add(53.81f + 96f);
            yellowNotesPositions.Add(54f + 96f);
            greenNotesPositions.Add(55.87f + 96f);
            redNotesPositions.Add(56.25f + 96f);
            redNotesPositions.Add(56.62f + 96f);
            yellowNotesPositions.Add(57f + 96f);
            redNotesPositions.Add(58.12f + 96f);
            greenNotesPositions.Add(58.5f + 96f);

            //interlude then final chorus
            greenNotesPositions.Add(59.62f + 108f);
            yellowNotesPositions.Add(59.81f + 108f);
            redNotesPositions.Add(60f + 108f);
            greenNotesPositions.Add(60.56f + 108f);
            redNotesPositions.Add(60.75f + 108f);
            yellowNotesPositions.Add(61.12f + 108f);
            yellowNotesPositions.Add(61.87f + 108f);
            redNotesPositions.Add(62.25f + 108f);
            greenNotesPositions.Add(62.62f + 108f);
            redNotesPositions.Add(63f + 108f);
            yellowNotesPositions.Add(63.18f + 108f);
            redNotesPositions.Add(63.37f + 108f);
            redNotesPositions.Add(64.12f + 108f);
            greenNotesPositions.Add(64.68f + 108f);

            greenNotesPositions.Add(65.62f + 108f);
            yellowNotesPositions.Add(65.81f + 108f);
            redNotesPositions.Add(66f + 108f);
            greenNotesPositions.Add(66.56f + 108f);
            redNotesPositions.Add(66.75f + 108f);
            yellowNotesPositions.Add(67.12f + 108f);
            yellowNotesPositions.Add(67.87f + 108f);
            yellowNotesPositions.Add(68.25f + 108f);
            yellowNotesPositions.Add(68.62f + 108f);
            redNotesPositions.Add(69f + 108f);
            yellowNotesPositions.Add(69.18f + 108f);
            redNotesPositions.Add(69.37f + 108f);
            redNotesPositions.Add(70.12f + 108f);
            greenNotesPositions.Add(70.68f + 108f);

            //chorus final -- 2
            greenNotesPositions.Add(59.62f + 108f + 12f);
            yellowNotesPositions.Add(59.81f + 108f + 12f);
            redNotesPositions.Add(60f + 108f + 12f);
            greenNotesPositions.Add(60.56f + 108f + 12f);
            redNotesPositions.Add(60.75f + 108f + 12f);
            yellowNotesPositions.Add(61.12f + 108f + 12f);
            yellowNotesPositions.Add(61.87f + 108f + 12f);
            redNotesPositions.Add(62.25f + 108f + 12f);
            greenNotesPositions.Add(62.62f + 108f + 12f);
            redNotesPositions.Add(63f + 108f + 12f);
            yellowNotesPositions.Add(63.18f + 108f + 12f);
            redNotesPositions.Add(63.37f + 108f + 12f);
            redNotesPositions.Add(64.12f + 108f + 12f);
            greenNotesPositions.Add(64.68f + 108f + 12f);

            greenNotesPositions.Add(65.62f + 108f + 12f);
            yellowNotesPositions.Add(65.81f + 108f + 12f);
            redNotesPositions.Add(66f + 108f + 12f);
            greenNotesPositions.Add(66.56f + 108f + 12f);
            redNotesPositions.Add(66.75f + 108f + 12f);
            yellowNotesPositions.Add(67.12f + 108f + 12f);
            yellowNotesPositions.Add(67.87f + 108f + 12f);
            yellowNotesPositions.Add(68.25f + 108f + 12f);
            yellowNotesPositions.Add(68.62f + 108f + 12f);
            redNotesPositions.Add(69f + 108f + 12f);
            yellowNotesPositions.Add(69.18f + 108f + 12f);
            redNotesPositions.Add(69.37f + 108f + 12f);
            redNotesPositions.Add(70.12f + 108f + 12f);
            greenNotesPositions.Add(70.68f + 108f + 12f);

            //chorus final -- 3

            greenNotesPositions.Add(59.62f + 108f + 24f);
            yellowNotesPositions.Add(59.81f + 108f + 24f);
            redNotesPositions.Add(60f + 108f + 24f);
            greenNotesPositions.Add(60.56f + 108f + 24f);
            redNotesPositions.Add(60.75f + 108f + 24f);
            yellowNotesPositions.Add(61.12f + 108f + 24f);
            yellowNotesPositions.Add(61.87f + 108f + 24f);
            redNotesPositions.Add(62.25f + 108f + 24f);
            greenNotesPositions.Add(62.62f + 108f + 24f);
            redNotesPositions.Add(63f + 108f + 24f);
            yellowNotesPositions.Add(63.18f + 108f + 24f);
            redNotesPositions.Add(63.37f + 108f + 24f);
            redNotesPositions.Add(64.12f + 108f + 24f);
            greenNotesPositions.Add(64.68f + 108f + 24f);

            greenNotesPositions.Add(65.62f + 108f + 24f);
            yellowNotesPositions.Add(65.81f + 108f + 24f);
            redNotesPositions.Add(66f + 108f + 24f);
            greenNotesPositions.Add(66.56f + 108f + 24f);
            redNotesPositions.Add(66.75f + 108f + 24f);
            yellowNotesPositions.Add(67.12f + 108f + 24f);
            yellowNotesPositions.Add(67.87f + 108f + 24f);
            yellowNotesPositions.Add(68.25f + 108f + 24f);
            yellowNotesPositions.Add(68.62f + 108f + 24f);
            redNotesPositions.Add(69f + 108f + 24f);
            yellowNotesPositions.Add(69.18f + 108f + 24f);
            redNotesPositions.Add(69.37f + 108f + 24f);
            redNotesPositions.Add(70.12f + 108f + 24f);
            greenNotesPositions.Add(70.68f + 108f + 24f);

            //chorus final -- 4
            greenNotesPositions.Add(59.62f + 108f + 36f);
            yellowNotesPositions.Add(59.81f + 108f + 36f);
            redNotesPositions.Add(60f + 108f + 36f);
            greenNotesPositions.Add(60.56f + 108f + 36f);
            redNotesPositions.Add(60.75f + 108f + 36f);
            yellowNotesPositions.Add(61.12f + 108f + 36f);
            yellowNotesPositions.Add(61.87f + 108f + 36f);
            redNotesPositions.Add(62.25f + 108f + 36f);
            greenNotesPositions.Add(62.62f + 108f + 36f);
            redNotesPositions.Add(63f + 108f + 36f);
            yellowNotesPositions.Add(63.18f + 108f + 36f);
            redNotesPositions.Add(63.37f + 108f + 36f);
            redNotesPositions.Add(64.12f + 108f + 36f);
            greenNotesPositions.Add(64.68f + 108f + 36f);

            greenNotesPositions.Add(65.62f + 108f + 36f);
            yellowNotesPositions.Add(65.81f + 108f + 36f);
            redNotesPositions.Add(66f + 108f + 36f);
            greenNotesPositions.Add(66.56f + 108f + 36f);
            redNotesPositions.Add(66.75f + 108f + 36f);
            yellowNotesPositions.Add(67.12f + 108f + 36f);
            yellowNotesPositions.Add(67.87f + 108f + 36f);
            yellowNotesPositions.Add(68.25f + 108f + 36f);
            yellowNotesPositions.Add(68.62f + 108f + 36f);
            redNotesPositions.Add(69f + 108f + 36f);
            yellowNotesPositions.Add(69.18f + 108f + 36f);
            redNotesPositions.Add(69.37f + 108f + 36f);
            redNotesPositions.Add(70.12f + 108f + 36f);
            greenNotesPositions.Add(70.68f + 108f + 36f);

            greenNotesPositions.Add(228f);
            yellowNotesPositions.Add(228f);
        }
    }
}
