﻿//
//  Copyright 2009-2014 NetworkComms.Net Ltd.
//
//  This source code is made available for reference purposes only.
//  It may not be distributed and it may not be made publicly available.
//

using NetworkCommsDotNet.DPSBase;
using NetworkCommsDotNet.Tools;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.NetworkInformation;

#if NETFX_CORE
using NetworkCommsDotNet.Tools.XPlatformHelper;
using System.Threading.Tasks;
using Windows.Storage;
#else
using System.Net.Sockets;
#endif

namespace NetworkCommsDotNet.Connections
{
    /// <summary>
    /// IP Connection base class for NetworkComms.Net. This contains the functionality and tools shared by any connections
    /// that use IP related endPoints such as <see cref="NetworkCommsDotNet.Connections.TCP.TCPConnection"/> and <see cref="NetworkCommsDotNet.Connections.UDP.UDPConnection"/>.
    /// </summary>
    public abstract class IPConnection : Connection
    {
        static IPConnection()
        {
            DOSProtection = new DOSProtection();
        }

        /// <summary>
        /// Create a new IP connection object
        /// </summary>
        /// <param name="connectionInfo">ConnectionInfo corresponding to the new connection</param>
        /// <param name="defaultSendReceiveOptions">The SendReceiveOptions which should be used as connection defaults</param>
        protected IPConnection(ConnectionInfo connectionInfo, SendReceiveOptions defaultSendReceiveOptions)
            : base(connectionInfo, defaultSendReceiveOptions)
        {

        }

        #region IP Security
        /// <summary>
        /// The NetworkComms.Net DOS protection class. By default DOSProtection is disabled.
        /// </summary>
        public static DOSProtection DOSProtection { get; private set; }

        /// <summary>
        /// If set NetworkComms.Net will only accept incoming connections from the provided IP ranges. 
        /// </summary>
        public static IPRange[] AllowedIncomingIPRanges { get; set; }
        #endregion
    }
}
