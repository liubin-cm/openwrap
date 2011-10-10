﻿using System;

namespace OpenWrap.PackageManagement
{
    [Flags]
    public enum PackageRemoveOptions
    {
        Recurse = 1,
        //Clean = 2,
        Hooks = 4,
        Default = Recurse | Hooks
    }
}