// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

////   This file has been borrowed from Wpf-UI.

//// This Source Code Form is subject to the terms of the MIT License.
//// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
//// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
//// All Rights Reserved.

namespace CrissCross.WPF.UI;

/// <summary>
/// Set of properties used when creating a new simple content dialog.
/// </summary>
public class SimpleContentDialogCreateOptions
{
    /// <summary>
    /// Gets or sets a name at the top of the content dialog.
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// Gets or sets a message displayed in the content dialog.
    /// </summary>
    public required object Content { get; set; }

    /// <summary>
    /// Gets or sets the name of the button that closes the content dialog.
    /// </summary>
    public required string CloseButtonText { get; set; }

    /// <summary>
    /// Gets or sets the default text of the primary button at the bottom of the content dialog.
    /// <para>If not added, or <see cref="string.Empty"/>, it will not be displayed.</para>
    /// </summary>
    public string PrimaryButtonText { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the default text of the secondary button at the bottom of the content dialog.
    /// <para>If not added, or <see cref="string.Empty"/>, it will not be displayed.</para>
    /// </summary>
    public string SecondaryButtonText { get; set; } = string.Empty;
}
