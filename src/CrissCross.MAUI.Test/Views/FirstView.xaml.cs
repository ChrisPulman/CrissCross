﻿// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.Maui;
using Splat;

namespace CrissCross.MAUI.Test
{
    /// <summary>
    /// FirstView.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstView"/> class.
        /// </summary>
        public FirstView()
        {
            InitializeComponent();
            this.WhenActivated(d =>
            {
                ViewModel ??= Locator.Current.GetService<FirstViewModel>();
                this.BindCommand(ViewModel, vm => vm.GotoMain, v => v.GotoMain).DisposeWith(d);
                this.BindCommand(ViewModel, vm => vm.GotoFirst, v => v.GotoFirst).DisposeWith(d);
            });
        }
    }
}
