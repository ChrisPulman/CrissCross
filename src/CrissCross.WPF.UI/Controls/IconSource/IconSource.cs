// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

////   This file has been borrowed from Wpf-UI.

//// This Source Code Form is subject to the terms of the MIT License.
//// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
//// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
//// All Rights Reserved.

using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace CrissCross.WPF.UI.Controls;

/// <summary>
/// Represents the base class for an icon source.
/// </summary>
public abstract class IconSource : DependencyObject
{
    /// <summary>
    /// Property for <see cref="Foreground"/>.
    /// </summary>
    public static readonly DependencyProperty ForegroundProperty = DependencyProperty.Register(
        nameof(Foreground),
        typeof(Brush),
        typeof(IconSource),
        new FrameworkPropertyMetadata(SystemColors.ControlTextBrush));

    /// <summary>
    /// Gets or sets the foreground.
    /// </summary>
    /// <value>
    /// The foreground.
    /// </value>
    public Brush Foreground
    {
        get => (Brush)GetValue(ForegroundProperty);
        set => SetValue(ForegroundProperty, value);
    }

    /// <summary>
    /// Creates the icon element.
    /// </summary>
    /// <returns>A IconElement.</returns>
    public abstract IconElement CreateIconElement();
}
