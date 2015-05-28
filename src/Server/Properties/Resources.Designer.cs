﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hermes.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Hermes.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while starting to listen incoming TCP connections.
        /// </summary>
        internal static string ChannelObservable_TcpListener_Failed {
            get {
                return ResourceManager.GetString("ChannelObservable_TcpListener_Failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first packet sent by a Client must be a Connect. The connection will be closed..
        /// </summary>
        internal static string ServerPacketListener_FirstPacketMustBeConnect {
            get {
                return ResourceManager.GetString("ServerPacketListener_FirstPacketMustBeConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The keep alive tolerance of {0} seconds has been exceeded and no packet has been received from client {1}. The connection will be closed..
        /// </summary>
        internal static string ServerPacketListener_KeepAliveTimeExceeded {
            get {
                return ResourceManager.GetString("ServerPacketListener_KeepAliveTimeExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connect packet has been received since the network connection was established. The connection will be closed..
        /// </summary>
        internal static string ServerPacketListener_NoConnectReceived {
            get {
                return ResourceManager.GetString("ServerPacketListener_NoConnectReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one Connect packet is allowed. The connection will be closed..
        /// </summary>
        internal static string ServerPacketListener_SecondConnectNotAllowed {
            get {
                return ResourceManager.GetString("ServerPacketListener_SecondConnectNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No session has been found for client {0}.
        /// </summary>
        internal static string SessionRepository_ClientSessionNotFound {
            get {
                return ResourceManager.GetString("SessionRepository_ClientSessionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The underlying TCP client is not connected.
        /// </summary>
        internal static string TcpChannel_ClientIsNotConnected {
            get {
                return ResourceManager.GetString("TcpChannel_ClientIsNotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The underlying network stream is not available. The socket could became disconnected.
        /// </summary>
        internal static string TcpChannel_SocketDisconnected {
            get {
                return ResourceManager.GetString("TcpChannel_SocketDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - Packet Channel observable sequence has been completed for client {0}.
        /// </summary>
        internal static string Tracer_PacketChannelCompleted {
            get {
                return ResourceManager.GetString("Tracer_PacketChannelCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - Cleaned old session for client {0}.
        /// </summary>
        internal static string Tracer_Server_CleanedOldSession {
            get {
                return ResourceManager.GetString("Tracer_Server_CleanedOldSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - Created new session for client {0}.
        /// </summary>
        internal static string Tracer_Server_CreatedSession {
            get {
                return ResourceManager.GetString("Tracer_Server_CreatedSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - Removed session for client {0} as part of Disconnect flow.
        /// </summary>
        internal static string Tracer_Server_DeletedSessionOnDisconnect {
            get {
                return ResourceManager.GetString("Tracer_Server_DeletedSessionOnDisconnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - A new TCP channel has been accepted.
        /// </summary>
        internal static string Tracer_Server_NewSocketAccepted {
            get {
                return ResourceManager.GetString("Tracer_Server_NewSocketAccepted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - Packet observable sequence has been completed, hence closing the channel.
        /// </summary>
        internal static string Tracer_Server_PacketsObservableCompleted {
            get {
                return ResourceManager.GetString("Tracer_Server_PacketsObservableCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - A connect packet has been received from client {0}.
        /// </summary>
        internal static string Tracer_ServerPacketListener_ConnectPacketReceived {
            get {
                return ResourceManager.GetString("Tracer_ServerPacketListener_ConnectPacketReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - Dispatching {0} message to flow {1} for client {2}.
        /// </summary>
        internal static string Tracer_ServerPacketListener_DispatchingMessage {
            get {
                return ResourceManager.GetString("Tracer_ServerPacketListener_DispatchingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - Dispatching Publish message to flow {0} for client {1} and topic {2}.
        /// </summary>
        internal static string Tracer_ServerPacketListener_DispatchingPublish {
            get {
                return ResourceManager.GetString("Tracer_ServerPacketListener_DispatchingPublish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The topic {0} has no subscribers, hence the message sent by {1} will not be forwarded.
        /// </summary>
        internal static string Tracer_ServerPublishReceiverFlow_TopicNotSubscribed {
            get {
                return ResourceManager.GetString("Tracer_ServerPublishReceiverFlow_TopicNotSubscribed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - An error occurred when subscribing client {0} to topic {1}.
        /// </summary>
        internal static string Tracer_ServerSubscribeFlow_ErrorOnSubscription {
            get {
                return ResourceManager.GetString("Tracer_ServerSubscribeFlow_ErrorOnSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - The topic {0}, sent by client {1} is invalid. Returning failure code.
        /// </summary>
        internal static string Tracer_ServerSubscribeFlow_InvalidTopicSubscription {
            get {
                return ResourceManager.GetString("Tracer_ServerSubscribeFlow_InvalidTopicSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - The TCP Network Stream has completed sending bytes. The observable sequence will be completed and the channel will be disposed.
        /// </summary>
        internal static string Tracer_TcpChannel_NetworkStreamCompleted {
            get {
                return ResourceManager.GetString("Tracer_TcpChannel_NetworkStreamCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - Received packet of {0} bytes.
        /// </summary>
        internal static string Tracer_TcpChannel_ReceivedPacket {
            get {
                return ResourceManager.GetString("Tracer_TcpChannel_ReceivedPacket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server - Sending packet of {0} bytes.
        /// </summary>
        internal static string Tracer_TcpChannel_SendingPacket {
            get {
                return ResourceManager.GetString("Tracer_TcpChannel_SendingPacket", resourceCulture);
            }
        }
    }
}
