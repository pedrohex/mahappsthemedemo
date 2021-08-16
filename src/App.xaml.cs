using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ControlzEx.Theming;
using TestMahapps.Services;

namespace TestMahapps
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      MyConfiguration.ThemeSelector = new ThemeSelectorService();
      MyConfiguration.ThemeSelector.InitializeThemes(new [] { "pack://application:,,,/Styles/Themes/My.Light.Blue.xaml", "pack://application:,,,/Styles/Themes/My.Dark.Blue.xaml" });
    }
  }
}
