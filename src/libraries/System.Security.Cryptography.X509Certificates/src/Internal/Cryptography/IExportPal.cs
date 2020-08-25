// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Net5.Microsoft.Win32.SafeHandles;
using System;
using Net5.System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.X509Certificates;

namespace Net5.Internal.Cryptography.Pal
{
    internal interface IExportPal : IDisposable
    {
        byte[] Export(Net5.System.Security.Cryptography.X509Certificates.X509ContentType contentType, SafePasswordHandle password);
    }
}
