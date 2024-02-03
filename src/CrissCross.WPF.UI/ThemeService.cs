// <auto-generated>
//   This file has been borrowed from Wpf-UI.
// </auto-generated>

#nullable enable

// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using CrissCross.WPF.UI.Appearance;

namespace CrissCross.WPF.UI;

/// <summary>
/// Lets you set the app theme.
/// </summary>
public partial class ThemeService : IThemeService
{
    /// <inheritdoc />
    public virtual ApplicationTheme GetTheme() => ApplicationThemeManager.GetAppTheme();

    /// <inheritdoc />
    public virtual SystemTheme GetNativeSystemTheme() => ApplicationThemeManager.GetSystemTheme();

    /// <inheritdoc />
    public virtual ApplicationTheme GetSystemTheme()
    {
        var systemTheme = ApplicationThemeManager.GetSystemTheme();

        return systemTheme switch
        {
            SystemTheme.Light => ApplicationTheme.Light,
            SystemTheme.Dark => ApplicationTheme.Dark,
            SystemTheme.Glow => ApplicationTheme.Dark,
            SystemTheme.CapturedMotion => ApplicationTheme.Dark,
            SystemTheme.Sunrise => ApplicationTheme.Light,
            SystemTheme.Flow => ApplicationTheme.Light,
            SystemTheme.HCBlack => ApplicationTheme.HighContrast,
            SystemTheme.HC1 => ApplicationTheme.HighContrast,
            SystemTheme.HC2 => ApplicationTheme.HighContrast,
            SystemTheme.HCWhite => ApplicationTheme.HighContrast,
            _ => ApplicationTheme.Unknown
        };
    }

    /// <inheritdoc />
    public virtual bool SetTheme(ApplicationTheme applicationTheme)
    {
        if (ApplicationThemeManager.GetAppTheme() == applicationTheme)
        {
            return false;
        }

        ApplicationThemeManager.Apply(applicationTheme);

        return true;
    }

    /// <inheritdoc />
    public bool SetSystemAccent()
    {
        ApplicationAccentColorManager.ApplySystemAccent();

        return true;
    }

    /// <inheritdoc />
    public bool SetAccent(Color accentColor)
    {
        ApplicationAccentColorManager.Apply(accentColor);

        return true;
    }

    /// <inheritdoc />
    public bool SetAccent(SolidColorBrush accentSolidBrush)
    {
        var color = accentSolidBrush.Color;
        color.A = (byte)Math.Round(accentSolidBrush.Opacity * Byte.MaxValue);

        ApplicationAccentColorManager.Apply(color);

        return true;
    }
}
