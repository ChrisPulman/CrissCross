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

// Based on Windows UI Library
// Copyright(c) Microsoft Corporation.All rights reserved.

// ReSharper disable once CheckNamespace
namespace CrissCross.WPF.UI.Controls;

public class NavigatingCancelEventArgs : RoutedEventArgs
{
    public NavigatingCancelEventArgs(RoutedEvent routedEvent, object source)
        : base(routedEvent, source) { }

    public required object Page { get; init; }
    public bool Cancel { get; set; }
}

public class NavigatedEventArgs : RoutedEventArgs
{
    public NavigatedEventArgs(RoutedEvent routedEvent, object source)
        : base(routedEvent, source) { }

    public required object Page { get; init; }
}