// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

////   This file has been borrowed from Wpf-UI.

//// This Source Code Form is subject to the terms of the MIT License.
//// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
//// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
//// All Rights Reserved.

namespace CrissCross.WPF.UI.Appearance;

/// <summary>
/// Theme in which an application using WPF UI is displayed.
/// </summary>
public enum ApplicationTheme
{
    /// <summary>
    /// Unknown application theme.
    /// </summary>
    Unknown,

    /// <summary>
    /// Dark application theme.
    /// </summary>
    Dark,

    /// <summary>
    /// Light application theme.
    /// </summary>
    Light,

    /// <summary>
    /// High contract application theme.
    /// </summary>
    HighContrast
}
