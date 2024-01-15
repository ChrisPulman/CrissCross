﻿// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.Hosting;
using ReactiveUI;
using Wpf.Ui;

namespace CrissCross.WPF.UI;
#pragma warning disable CA1812
/// <summary>
/// Managed host of the application.
/// </summary>
/// <typeparam name="TWindow">The application Window.</typeparam>
/// <typeparam name="TViewModel">The Start ViewModel.</typeparam>
/// <seealso cref="IHostedService" />
/// <remarks>
/// Initializes a new instance of the <see cref="ApplicationVMHostService{TWindow , TPage}" /> class.
/// </remarks>
/// <param name="serviceProvider">The service provider.</param>
internal class ApplicationVMHostService<TWindow, TViewModel>(IServiceProvider serviceProvider) : IHostedService
    where TWindow : NavigationWindow
    where TViewModel : class, IRxObject, new()
{
    private NavigationWindow? _navigationWindow;

    /// <summary>
    /// Triggered when the application host is ready to start the service.
    /// </summary>
    /// <param name="cancellationToken">Indicates that the start process has been aborted.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task StartAsync(CancellationToken cancellationToken) => await HandleActivationAsync();

    /// <summary>
    /// Triggered when the application host is performing a graceful shutdown.
    /// </summary>
    /// <param name="cancellationToken">Indicates that the shutdown process should no longer be graceful.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task StopAsync(CancellationToken cancellationToken) => await Task.CompletedTask;

    /// <summary>
    /// Creates main window during activation.
    /// </summary>
    private async Task HandleActivationAsync()
    {
        await Task.CompletedTask;

        if (!Application.Current.Windows.OfType<TWindow>().Any())
        {
            _navigationWindow = serviceProvider.GetService(typeof(NavigationWindow)) as NavigationWindow;

            if (_navigationWindow is null)
            {
                throw new InvalidOperationException("Navigation Window not registered.");
            }

            _navigationWindow.Show();

            _navigationWindow.NavigateToView<TViewModel>();
        }

        await Task.CompletedTask;
    }
}
#pragma warning restore CA1812