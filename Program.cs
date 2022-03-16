using AudioSwitcher.AudioApi.CoreAudio;

namespace popform;

static class Program
{
    [STAThread]
    static void Main()
    {


        string message = "Il ne faut jamais cliquer sur des fichiers qu'on ne connait pas !\nHeureusement je suis gentil :)";
        string caption = "HACKED BY PROC";
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        DialogResult result;

        result = MessageBox.Show(message, caption, buttons);


    }    
}