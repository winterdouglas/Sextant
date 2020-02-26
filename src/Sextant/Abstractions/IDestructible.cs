﻿// Copyright (c) 2019 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace Sextant
{
    /// <summary>
    /// Interface that represents an element that is destructible.
    /// </summary>
    public interface IDestructible
    {
        /// <summary>
        /// Views/viewmodels that implement this will be aware when they are about to be destroyed.
        /// </summary>
        void Destroy();
    }
}
