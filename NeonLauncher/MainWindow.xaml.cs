using NeonLauncher.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeonLauncher
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string VersionString = "v0.0.1 ALPHA";

        public MainWindow()
        {
            InitializeComponent();

            this.Title = this.Title.Replace("{{VERSION}}", VersionString);
            this.ListViewGames.ItemsSource = new SteamGameData[]
            {
                new SteamGameData{AppID=708420, Name="Broken Ground", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\Broken Ground\BrokenGround.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=339800, Name="HuniePop", Icon=GetIconFromExe(@"S:\Program Files (x86)\SteamLibrary\steamapps\common\HuniePop\HuniePop.exe")},
                new SteamGameData{AppID=12900, Name="Audiosurf", Icon=GetIconFromExe(@"P:\Program Files (x86)\Steam\steamapps\common\Audiosurf\Audiosurf.exe")}
            };
        }

        public Icon GetIconFromExe(string filePath)
        {
            return System.Drawing.Icon.ExtractAssociatedIcon(filePath);
        }

        private void OnDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Assuming you have one file that you care about, pass it off to whatever
                // handling code you have defined.
                //HandleFileOpen(files[0]);
                MessageBox.Show(files[0]);
            }
        }
    }
}
