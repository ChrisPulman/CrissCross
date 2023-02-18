﻿// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using ReactiveUI;
using Splat;

namespace CrissCross.MAUI.Test
{
    /// <summary>
    /// App.
    /// </summary>
    /// <seealso cref="Microsoft.Maui.Controls.Application" />
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        /// <remarks>
        /// To be added.
        /// </remarks>
        public App()
        {
            InitializeComponent();
            Locator.CurrentMutable.RegisterConstant<MainViewModel>(new());
            Locator.CurrentMutable.Register<IViewFor<MainViewModel>>(() => new MainView());

            Locator.CurrentMutable.RegisterConstant<FirstViewModel>(new());
            Locator.CurrentMutable.Register<IViewFor<FirstViewModel>>(() => new FirstView());
            MainPage = new AppShell();
        }
    }
}
