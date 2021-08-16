using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ControlzEx.Theming;
using MahApps.Metro.Theming;

namespace TestMahapps.Services
{
  public class ThemeSelectorService
  {
    public void InitializeThemes(IEnumerable<string> themes)
    {
      foreach (var theme in themes)
      {
        ThemeManager.Current.AddLibraryTheme(new LibraryTheme(new Uri(theme), MahAppsLibraryThemeProvider.DefaultInstance));
      }

      var currentlyAppliedTheme = MyConfiguration.Theme;
      ApplyTheme(currentlyAppliedTheme);
    }

    public void ApplyTheme(AppTheme theme)
    {
      ThemeManager.Current.ThemeSyncMode = ThemeSyncMode.SyncWithHighContrast;
      ThemeManager.Current.SyncTheme();
      ThemeManager.Current.ChangeTheme(Application.Current, $"My.{theme}.Blue", SystemParameters.HighContrast);

      MyConfiguration.Theme = theme;
    }
  }
}
