﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Animation;

namespace Microsoft.Toolkit.Uwp.UI.Animations.Extensions
{
    /// <summary>
    /// An extension <see langword="class"/> for the <see cref="Storyboard"/> type.
    /// </summary>
    public static class StoryboardAnimations
    {
        /// <summary>
        /// Starts an animation and returns a <see cref="Task"/> that reports when it completes.
        /// </summary>
        /// <param name="storyboard">The target storyboard to start.</param>
        /// <returns>A <see cref="Task"/> that completes when <paramref name="storyboard"/> completes.</returns>
        public static Task BeginAsync(this Storyboard storyboard)
        {
            TaskCompletionSource<object?> taskCompletionSource = new TaskCompletionSource<object?>();

            storyboard.Completed += (_, _) => taskCompletionSource.SetResult(null);

            storyboard.Begin();

            return taskCompletionSource.Task;
        }
    }
}
