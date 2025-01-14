using System;
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
        private static AudioFileReader audioFileReader;


        public static void PlayAudio()
        {
            try
            {   
                var audioStream = Properties.Resources.piano_calm;  
                                
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
                waveOutEvent.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas próby odtworzenia muzyki: " + ex.Message);
            }
        }
        public static void StopAudio()
        {
            waveOutEvent.Stop();
        }
        public static void ResumeAudio()
        {
            waveOutEvent.Play();
        }

        internal static void ChangeVolume(float value)
        {
            waveOutEvent.Volume = value / 100f;
        }
    }
}
