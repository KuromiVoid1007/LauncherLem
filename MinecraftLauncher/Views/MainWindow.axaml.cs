using Avalonia.Controls;
using Avalonia.Interactivity;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ModLoaders.FabricMC;
using CmlLib.Core.ProcessBuilder;
using MinecraftLauncherLem;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using CmlLib.Core.Auth.Microsoft;
using static System.Collections.Specialized.BitVector32;
using System.Diagnostics;

namespace MinecraftLauncherLem.Views
{
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
        }
        private async void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            RunFullFabricSetupAndLaunch();
        }

        private void WebSite_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "http://176.124.202.23/",
                UseShellExecute = true
            });
        }
        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            var profileWindow = new ProfileForm();
            profileWindow.Show();
        }

        private async Task InstallFabricAsync()
        {
            using var httpClient = new HttpClient();
            var fabricInstaller = new FabricInstaller(httpClient);

            string gameVersion = "1.20.1";
            string loaderVersion = "0.16.9";

            var minecraftPath = new MinecraftPath();
            await fabricInstaller.Install(gameVersion, loaderVersion, minecraftPath);
        }
        private async Task InstallFabricApiModAsync()
        {
            var launcher = new MinecraftLauncher();
            var modsPath = Path.Combine(launcher.MinecraftPath.BasePath, "mods");
            Directory.CreateDirectory(modsPath);

            var fabricApiFile = Path.Combine(modsPath, "fabric-api-0.92.2+1.20.1.jar");
            if (!File.Exists(fabricApiFile))
            {
                using var client = new HttpClient();
                var data = await client.GetByteArrayAsync("http://176.124.202.23/fabric-api-0.92.2+1.20.1.jar");
                await File.WriteAllBytesAsync(fabricApiFile, data);
            }
        }

        private async Task StartMinecraftLemFabric()
        {
            var launcher = new MinecraftLauncher();

            var options = new MLaunchOption
            {
               Session = MSession.CreateOfflineSession("Weelklai"),
                MaximumRamMb = 2048
            };

            var versionName = "fabric-loader-0.16.9-1.20.1";
            var process = await launcher.InstallAndBuildProcessAsync(versionName, options);
            process.Start();
        }

        private async void RunFullFabricSetupAndLaunch()
        {
            await InstallFabricAsync();
            await InstallFabricApiModAsync();
            await StartMinecraftLemFabric();
        }
    }
}
