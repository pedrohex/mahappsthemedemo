using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMahapps.Services;

namespace TestMahapps
{
  public static class MyConfiguration
  {
    public static AppTheme Theme { get; set; } = AppTheme.Light;
    public static ThemeSelectorService ThemeSelector { get; set; }
  }
}
