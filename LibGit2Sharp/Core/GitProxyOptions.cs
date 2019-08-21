﻿using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    internal enum GitProxyType
    {
        None,
        Auto,
        Specified
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct GitProxyOptions
    {
        public uint Version;
        public GitProxyType Type;
        public IntPtr Url;
        public IntPtr CredentialsCb;
        public IntPtr CertificateCheck;
        public IntPtr CbPayload;
    }

    internal static class GitProxyOptionsFactory
    {
        public static GitProxyOptions CreateDefaultProxyOptions()
        {
            return new GitProxyOptions
            {
                Version = 1,
                Type = GitProxyType.Auto
            };
        }
    }
}
