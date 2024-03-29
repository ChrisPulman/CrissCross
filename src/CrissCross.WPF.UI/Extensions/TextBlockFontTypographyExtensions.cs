// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

////   This file has been borrowed from Wpf-UI.

//// This Source Code Form is subject to the terms of the MIT License.
//// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
//// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
//// All Rights Reserved.

namespace CrissCross.WPF.UI.Extensions;

/// <summary>
/// Extension that converts the typography type enumeration to the name of the resource that represents it.
/// </summary>
public static class TextBlockFontTypographyExtensions
{
    /// <summary>
    /// Converts the typography type enumeration to the name of the resource that represents it.
    /// </summary>
    /// <param name="typography">The typography.</param>
    /// <returns>
    /// Name of the resource matching the <see cref="FontTypography" />. <see cref="ArgumentOutOfRangeException" /> otherwise.
    /// </returns>
    public static string ToResourceValue(this FontTypography typography) => typography switch
    {
        FontTypography.Caption => "CaptionTextBlockStyle",
        FontTypography.Body => "BodyTextBlockStyle",
        FontTypography.BodyStrong => "BodyStrongTextBlockStyle",
        FontTypography.Subtitle => "SubtitleTextBlockStyle",
        FontTypography.Title => "TitleTextBlockStyle",
        FontTypography.TitleLarge => "TitleLargeTextBlockStyle",
        FontTypography.Display => "DisplayTextBlockStyle",
        _ => throw new ArgumentOutOfRangeException(nameof(typography), typography, null)
    };
}
