﻿//
//  Copyright 2009-2014 NetworkComms.Net Ltd.
//
//  This source code is made available for reference purposes only.
//  It may not be distributed and it may not be made publicly available.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistributedFileSystem
{
    /// <summary>
    /// Describes where a distributed item should be stored during and after being assembled
    /// </summary>
    public enum ItemBuildTarget
    {
        /// <summary>
        /// Build the item to a memory stream. Most high performance but obviously requires sufficient memory
        /// </summary>
        Memory,

        /// <summary>
        /// Build the item to the local application directory
        /// </summary>
        Disk,

        /// <summary>
        /// Build the item to memory but also write a copy to the local application directory
        /// </summary>
        Both,
    }
}
