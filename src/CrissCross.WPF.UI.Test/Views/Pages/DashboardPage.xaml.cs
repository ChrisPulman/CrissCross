﻿// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using CrissCross.WPF.UI.Test.ViewModels;

namespace CrissCross.WPF.UI.Test.Views.Pages;

/// <summary>
/// Interaction logic for DashboardPage.xaml.
/// </summary>
public partial class DashboardPage : INavigableView<DashboardViewModel>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DashboardPage"/> class.
    /// </summary>
    /// <param name="viewModel">The view model.</param>
    public DashboardPage(DashboardViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;

        InitializeComponent();
    }

    /// <summary>
    /// Gets viewModel used by the view.
    /// Optionally, it may implement <see cref="T:Wpf.Ui.Controls.INavigationAware" /> and be navigated by <see cref="T:Wpf.Ui.Controls.INavigationView" />.
    /// </summary>
    public DashboardViewModel ViewModel { get; }
}
