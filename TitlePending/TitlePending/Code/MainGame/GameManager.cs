using SharpDX.MediaFoundation.DirectX;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using System.Text;
using TitlePending.Code.States;
using TitlePending.Code.MainGame.Gameplay;

namespace TitlePending
{
    public static class GameManager
    {
        public static int currentlySelected
        {
            get
            {
                return backupSelected;
            }
            set
            {
                backupSelected = value;
                if (currentState.stateID == StateID.SongSelection)
                {
                    //MediaPlayer.Stop();
                    switch (value)
                    {
                        case 0: // ONE MUST VIBE
                            minPreviewTime = 53.33f;
                            maxPreviewTime = 69.33f;
                            MediaPlayer.Play(songDictionary[SongID.OneMustVibe], TimeSpan.FromSeconds(minPreviewTime));
                            break;

                        case 1: // SHMOVE
                            minPreviewTime = 107.62f;
                            maxPreviewTime = 122.62f;
                            MediaPlayer.Play(songDictionary[SongID.Shmovement], TimeSpan.FromSeconds(minPreviewTime));
                            break;
                        
                    }
                    MediaPlayer.IsRepeating = true;
                }
            }
        }

        public static float minPreviewTime { get; set; }

        public static float maxPreviewTime { get; set; }

        public static float origVolume { get; set; }

        public static Dictionary<SongID, Song> songDictionary { get; set; }


        private static int backupSelected = 0;

        public static SongID selectedSongID { get; set; }

        public static TitlePending gameCore { get; set; }

        public static Vector2 GreenHitter { get; set; }
        public static Vector2 RedHitter { get; set; }
        public static Vector2 YellowHitter { get; set; }
        public static Vector2 BlueHitter { get; set; }
        public static Vector2 OrangeHitter { get; set; }

        public static State currentState;

        public static bool hasPlayedIntro = false;

        public static Vector2 GreenOrigin { get; set; }
        public static Vector2 RedOrigin { get; set; } 
        public static Vector2 YellowOrigin { get; set; } 
        public static Vector2 BlueOrigin { get; set; } 
        public static Vector2 OrangeOrigin { get; set; } 


        public static Vector2 centerpoint => gameCore.GraphicsDevice.Viewport.Bounds.Center.ToVector2();
        public static Vector2 ScreenSize => gameCore.GraphicsDevice.Viewport.Bounds.Size.ToVector2();
        public static float AspectRatio => gameCore.GraphicsDevice.Viewport.AspectRatio;

        public static GameScore Score;

        public static void Exit()
        {
            gameCore.Exit();
        }

        public static void SwitchState(StateID stateID)
        {
            gameCore.SwitchState(stateID);
        }
    }
}
