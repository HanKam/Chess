﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Chess
{
    internal class AudioManager
    {
        private static WaveOutEvent waveOutEvent;


        public static void PlayAudio()
        {
            try
            {   
                var audioStream = Properties.Resources.piano_calm;  
                                
                // Getting background audio from files
                byte[] audioData;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    audioStream.CopyTo(memoryStream);
                    audioData = memoryStream.ToArray();
                }

                WaveStream wav = new RawSourceWaveStream(new MemoryStream(audioData), new WaveFormat(44100, 16, 2));

                waveOutEvent = new WaveOutEvent();
                waveOutEvent.Init(wav);
                waveOutEvent.Volume = 1f;

                waveOutEvent.PlaybackStopped += (sender, e) =>
                {
                    // looping playing audio
                    wav = new RawSourceWaveStream(new MemoryStream(audioData), new WaveFormat(44100, 16, 2));
                    waveOutEvent.Init(wav);
                    waveOutEvent.Play();
                };

                waveOutEvent.Play();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas próby odtworzenia muzyki: " + ex.Message);
            }
        }
        public static void StopAudio()
        {
            waveOutEvent.Volume = 0f;
        }
        public static void ResumeAudio(float value)
        {
            ChangeVolume(value);
        }

        internal static void ChangeVolume(float value)
        {
            waveOutEvent.Volume = value / 100f;
        }
    }
}
