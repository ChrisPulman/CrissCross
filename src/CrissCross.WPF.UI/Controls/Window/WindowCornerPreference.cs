// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

////   This file has been borrowed from Wpf-UI.

//// This Source Code Form is subject to the terms of the MIT License.
//// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
//// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
//// All Rights Reserved.

// ReSharper disable once CheckNamespace
namespace CrissCross.WPF.UI.Controls;

/// <summary>
/// Ways you can round windows.
/// </summary>
public enum WindowCornerPreference
{
    /// <summary>
    /// Determined by system or application preference.
    /// </summary>
    Default,

    /// <summary>
    /// Do not round the corners.
    /// </summary>
    DoNotRound,

    /// <summary>
    /// Round the corners.
    /// </summary>
    Round,

    /// <summary>
    /// Round the corners slightly.
    /// </summary>
    RoundSmall
}
