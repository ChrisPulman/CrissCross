// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

////   This file has been borrowed from Wpf-UI.

//// This Source Code Form is subject to the terms of the MIT License.
//// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
//// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
//// All Rights Reserved.

namespace CrissCross.WPF.UI;

/// <summary>
/// Allows to get the WPF UI assembly through <see cref="Assembly"/>.
/// </summary>
public static class UiAssembly
{
    /// <summary>
    /// Gets the WPF UI assembly.
    /// </summary>
    public static Assembly Assembly => Assembly.GetExecutingAssembly();
}
