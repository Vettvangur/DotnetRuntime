// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

using Net5.Internal.Cryptography.Pal.Native;

using Net5.System.Security.Cryptography;
using Net5.System.Security.Cryptography.X509Certificates;

namespace Net5.Internal.Cryptography.Pal
{
    /// <summary>
    /// A singleton class that encapsulates the native implementation of various X509 services. (Implementing this as a singleton makes it
    /// easier to split the class into abstract and implementation classes if desired.)
    /// </summary>
    internal sealed partial class X509Pal : IX509Pal
    {
        public static IX509Pal Instance = new X509Pal();

        private X509Pal()
        {
        }
    }
}
