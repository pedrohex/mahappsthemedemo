using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using ControlzEx.Theming;
using MahApps.Metro.Theming;

namespace TestMahapps.Services
{
  public class ThemeSelectorService
  {
    public void InitializeThemes(IEnumerable<string> themes)
    {

      var currentlyAppliedTheme = MyConfiguration.Theme;
      ApplyTheme(currentlyAppliedTheme, Colors.Blue);
    }

    public void ApplyTheme(AppTheme theme, Color accent)
    {
            var newTheme = new Theme("MyTheme", "MyTheme", theme == AppTheme.Light ? "Light" : "Dark", accent.ToString(), accent, new SolidColorBrush(accent), true, true);

            newTheme.Resources["MahApps.Brushes.ThemeBackground"] = new SolidColorBrush(new HSLColor(accent).GetTintedColor(theme == AppTheme.Light ? +0.8 : -0.8));

      ThemeManager.Current.ChangeTheme(Application.Current,newTheme);

      MyConfiguration.Theme = theme;
    }
  }
}
