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
/// Provides data for the <see cref="AutoSuggestBox.TextChanged"/> event.
/// </summary>
public enum AutoSuggestionBoxTextChangeReason
{
    /// <summary>
    /// The user edited the text.
    /// </summary>
    UserInput = 0,

    /// <summary>
    /// The text was changed via code.
    /// </summary>
    ProgrammaticChange = 1,

    /// <summary>
    /// The user selected one of the items in the auto-suggestion box.
    /// </summary>
    SuggestionChosen = 2,
}
