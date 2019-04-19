using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Network.Helper.RNReactNativeNetworkHelper
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeNetworkHelperModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeNetworkHelperModule"/>.
        /// </summary>
        internal RNReactNativeNetworkHelperModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeNetworkHelper";
            }
        }
    }
}
