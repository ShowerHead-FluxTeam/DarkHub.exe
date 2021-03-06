using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using Dark_Hub.Classes;
namespace Dark_Hub
{

    public partial class MainWindow : Window
    {
        public MainWindow() =>
            InitializeComponent();

        private void onClosing(object sender, System.ComponentModel.CancelEventArgs e) =>
         Process.GetCurrentProcess().Kill();

        private async void onLoaded(object sender, RoutedEventArgs e)
        {   
            InjectionWindow window = new InjectionWindow();
            Storyboard s = (Storyboard)TryFindResource("loading");
            await s.start();
            await Task.Delay(200);

            Topmost = false;

            window.user = new User();
            await window.user.setUser("2");           
            window.Show();
            await Task.Delay(300);
            Hide();
        }

     
    }
}
