using System;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace Upload_It_
{
    class Uploader
    {

        public static void UploadFile(String file)
        {
            // Some vars 4 web and sound
            SoundPlayer uploaded = new SoundPlayer(@"c:\Windows\Media\Speech On.wav");
            WebClient myWebClient = new WebClient();

            // Get server response
            byte[] responseArray = myWebClient.UploadFile("https://api.anonfiles.com/upload", @file);
            string response = System.Text.Encoding.ASCII.GetString(responseArray);

            // Get short url
            response = response.Substring(response.LastIndexOf("https://"), response.IndexOf("}") - response.LastIndexOf("https://") - 1);

            // Copy url and play sound notification
            Clipboard.SetText(response, TextDataFormat.Text);
            uploaded.Play();
        }
    }
}
