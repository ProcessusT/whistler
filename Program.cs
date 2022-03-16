using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace popform
{
    static class Program
    {
        static public void Bipbip()
        {
            int frequency = 1000;
            int duration = 200000;
            Console.Beep(frequency, duration);
        }



        [STAThreadAttribute]
        public static void Main()
        {
            
            NAudio.CoreAudioApi.MMDeviceEnumerator MMDE = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            // on recupere tous les peripheriques audio
            NAudio.CoreAudioApi.MMDeviceCollection DevCol = MMDE.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.All);

            foreach (NAudio.CoreAudioApi.MMDevice dev in DevCol)
            {
                try
                {
                    System.Diagnostics.Debug.Print(dev.FriendlyName);
                    // on unmute le peripherique
                    dev.AudioEndpointVolume.Mute = false;
                    System.Diagnostics.Debug.Print(dev.AudioEndpointVolume.MasterVolumeLevel.ToString());
                    // on augmente le volume jusqu'a 100%
                    for (int i = 0; i < 100; i++)
                    {
                        dev.AudioEndpointVolume.VolumeStepUp();
                    }
                }
                catch (Exception ex)
                {
                    //Nothing here
                }
            }


            // on joue un petit son du diable
            Thread thread = new Thread(Bipbip);
            thread.Start();




            // on affiche un joli message
            string message = "Il ne faut jamais cliquer sur des fichiers qu'on ne connait pas !\nHeureusement je suis gentil :)";
            string caption = "HACKED BY PROC";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);


        }
    }
}
