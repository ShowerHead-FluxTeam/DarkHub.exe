using System.Windows;
using System.Windows.Media.Animation;
using Dark_Hub.Classes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System;
using System.Text;
using System.Management;
using System.Globalization;
using System.Threading;
using System.IO.Pipes;

namespace Dark_Hub
{

    public partial class InjectionWindow : Window
    {
        public delegate void EventHandler(string e);
        public event EventHandler EventHandlera;
        public InjectionWindow()
        {
            InitializeComponent();
            grid.Opacity = 0;

            if (!(HttpGet("https://ksapi.xyz/DarkHub/Verify.php?HardwareID=" + this.HWID) != this.HWID))
            {
                ksGrid.Visibility = Visibility.Hidden;
            }

            StreamReader Read = null;

            new Thread(() =>
            {
                NamedPipeClientStream pipe = new NamedPipeClientStream(".", "DARKHUB_IPC", PipeDirection.InOut);
                pipe.Connect();
                Read = new StreamReader(pipe, Encoding.UTF8);
                while (true)
                {

                    EventHandlera?.Invoke(Read.ReadToEnd());
                    Read.Close();
                    pipe.Dispose();

                    pipe = new NamedPipeClientStream(".", "DARKHUB_IPC", PipeDirection.InOut);
                    pipe.Connect();

                    Read = new StreamReader(pipe, Encoding.UTF8);
                }
            }).Start();

            EventHandlera += delegate (string Input)
            {
                Dispatcher.Invoke(() =>
                {       
                    if(Input == "Key")
                    {
                        MessageBox.Show("Looks like your key expired. You need a new one!");
                        ksGrid.Visibility = Visibility.Visible;
                        foreach (var Proc in Process.GetProcessesByName("RobloxPlayerBeta"))
                        {
                            Proc.Kill();
                        }
                    }
                    else
                    {
                        window.user = new User();
                        window.user.setUserNonAsync(Input);
                        UserName.Text = $"Username: {user.Username}";
                        IDBOX.Text = $"ID: {user.ID}";

                        using (WebClient wc = new WebClient())
                        {
                            byte[] DataBytes = wc.DownloadData(user.ImageURL);

                            using (Bitmap a = new Bitmap(Image.FromStream(new MemoryStream(DataBytes))))
                                ImageBox.Source = Functions.BitmapToImageSource(a);

                            wc.Dispose();
                        }

                        setStatus("Idle.");
                    }              
                });
            };
        }

        private void setStatus(string stat) =>
            statusBox.Text = $"Status : {stat}";
        
        private void closeUI(object sender, RoutedEventArgs e) =>
            Process.GetCurrentProcess().Kill();

        private void minimizeUI(object sender, RoutedEventArgs e) =>
            WindowState = WindowState.Minimized;

        private void moveUI(object sender, System.Windows.Input.MouseButtonEventArgs e) =>
            DragMove();

        public User user;

   
        private async void onClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            e.Cancel = true;
            closeBtn.IsEnabled = false;
            Storyboard s = (Storyboard)TryFindResource("Closing");
            await s.start();
            Process.GetCurrentProcess().Kill();
        }


        private async void onLoaded(object sender, RoutedEventArgs e)
        {
            UserName.Text = $"Username: {user.Username}";
            IDBOX.Text = $"ID: {user.ID}";

            using (WebClient wc = new WebClient())
            {
                byte[] DataBytes = await wc.DownloadDataTaskAsync(user.ImageURL);

                using (Bitmap a = new Bitmap(Image.FromStream(new MemoryStream(DataBytes))))
                    ImageBox.Source = Functions.BitmapToImageSource(a);
                wc.Dispose();

            }

            Storyboard s = (Storyboard)TryFindResource("loading");
            await s.start();
        }

        private async void doInjection(object sender, RoutedEventArgs e)
        {
            setStatus("Downloading Files...");
            if (await Functions.downloadFiles())
            {
                await Task.Delay(500);
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length < 1)
                {
                    setStatus("Roblox isnt open!");
                    await Task.Delay(500);
                    setStatus("Awaiting Injection");
                    return;
                }
                Process.Start("Inject.bat");

                await Task.Delay(100);
                setStatus("Done! Injecting...");
            }

        }

        public string HWID = Base64Encode(Environment.UserName + long.Parse(new ManagementObject("win32_logicaldisk.deviceid=\"c:\"")["VolumeSerialNumber"].ToString(), NumberStyles.HexNumber).ToString());
        public static string Base64Encode(string plainText)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText)).Replace("=", "1");
        }
        public static string HttpGet(string Url)
        {
            WebClient webClient = new WebClient();
            string result = webClient.DownloadString(Url);
            webClient.Dispose();
            return result;
        }

        int FailedTries = 0;
        private void VerifyKey(object sender, RoutedEventArgs e)
        {

            if (this.textBox.Text == "")
            {
                System.Windows.MessageBox.Show("Please enter something as a key.", "Key", MessageBoxButton.OK, MessageBoxImage.Hand);
                return;
            }

            if (!(HttpGet("https://ksapi.xyz/DarkHub/Verify.php?HardwareID=" + this.HWID) != this.HWID))
            {
                ksGrid.Visibility = Visibility.Hidden;
                return;
            }
            this.FailedTries++;
            if (this.FailedTries == 3)
            {
                System.Windows.MessageBox.Show("Your key was incorrect again. If you need help, please join our discord server & then create a support ticket. https://discord.com/invite/darkhub", "Key", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                this.FailedTries = 0;
                return;
            }
            System.Windows.MessageBox.Show("The key: \"" + this.textBox.Text + "\" is invalid.", "Key", MessageBoxButton.OK, MessageBoxImage.Hand);
        }

        private void getKey(object sender, RoutedEventArgs e)
        {
            Process.Start("https://ksapi.xyz/DarkHub/Start.php?HardwareID=" + this.HWID);
        }
    }
}
