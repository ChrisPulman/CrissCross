// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

// <auto-generated>
//   This file has been borrowed from Wpf-UI.
// </auto-generated>

#nullable enable

// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

// ReSharper disable once CheckNamespace
namespace CrissCross.WPF.UI.Controls;

/// <summary>
/// TODO
/// </summary>
public class RichTextBox : System.Windows.Controls.RichTextBox
{
    /// <summary>
    /// Property for <see cref="IsTextSelectionEnabledProperty"/>.
    /// </summary>
    public static readonly DependencyProperty IsTextSelectionEnabledProperty = DependencyProperty.Register(
        nameof(IsTextSelectionEnabled),
        typeof(bool),
        typeof(RichTextBox),
        new PropertyMetadata(false)
    );

    /// <summary>
    /// TODO
    /// </summary>
    public bool IsTextSelectionEnabled
    {
        get => (bool)GetValue(IsTextSelectionEnabledProperty);
        set => SetValue(IsTextSelectionEnabledProperty, value);
    }
}