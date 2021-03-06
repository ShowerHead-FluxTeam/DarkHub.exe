using System;
using System.IO;
using System.Net;
using MessageBox = System.Windows.Forms.MessageBox;
using Application = System.Windows.Forms.Application;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using System.Drawing;

namespace Dark_Hub.Classes
{
    public static class Extentions
    {
        public static Task start(this Storyboard storyBoard)
        {
            TaskCompletionSource<bool> status = new TaskCompletionSource<bool>();

            EventHandler sbHandler = null;

            sbHandler = (sender, eeeeeeeeeeee) =>
            {
                storyBoard.Completed -= sbHandler;
                status.SetResult(true);
            };

            storyBoard.Completed += sbHandler;
            storyBoard.Begin();

            return status.Task;
        }
    }

    public static class Functions
    {
        public static BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Png);
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }



        public static async Task<bool> downloadFiles()
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    if (!File.Exists("DACInject.exe"))
                        await wc.DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/760268029304635412/802770180148559892/PuppyMilkV3.exe", "DACInject.exe");

                   await wc.DownloadFileTaskAsync("http://ksapi.xyz/DarkHub/FluxusTeamAPI.dll", "FluxusTeamAPI.dll");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error while downloading files!\r\n" + e);
                    return false;
                }
                wc.Dispose();
            }

            using (StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "/Inject.bat", false))
                streamWriter.WriteLine($"DACInject.exe \"" + Application.StartupPath + "\\FluxusTeamAPI.dll\"");

            return true;
        }
    }
}
