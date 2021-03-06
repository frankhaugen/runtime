// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;

namespace System.Configuration
{
    public class ConfigurationLocationCollection : ReadOnlyCollectionBase
    {
        internal ConfigurationLocationCollection(ICollection col)
        {
            InnerList.AddRange(col);
        }

        public ConfigurationLocation this[int index] => (ConfigurationLocation)InnerList[index];
    }
}
