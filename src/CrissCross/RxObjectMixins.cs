﻿// Copyright (c) Chris Pulman. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Splat;

namespace CrissCross
{
    /// <summary>
    /// RxObjectMixins.
    /// </summary>
    public static class RxObjectMixins
    {
        private static readonly ReplaySubject<bool> _buildCompleteSubject = new(1);

        private static IObservable<Unit> _source = _buildCompleteSubject.Select(_ => Unit.Default).Publish().RefCount();
        /// <summary>
        /// Sets the IOC container build complete, Execute this once after completion of IOC registrations.
        /// </summary>
        /// <param name="dummy">The dummy.</param>
        public static void SetupComplete(this IMutableDependencyResolver dummy) => _buildCompleteSubject.OnNext(true);

        /// <summary>
        /// Gets the build complete.
        /// </summary>
        /// <param name="dummy">The dummy.</param>
        /// <param name="action">The action.</param>
        /// <value>The build complete.</value>
        public static void BuildComplete(this IAmBuilt dummy, Action action) => _source.Subscribe(_ => action());
    }
}
