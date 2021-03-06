// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Microsoft.Internal;

namespace System.Composition.Hosting.Core
{
    internal class DirectExportDescriptor : ExportDescriptor
    {
        private readonly CompositeActivator _activator;
        private readonly IDictionary<string, object> _metadata;

        public DirectExportDescriptor(CompositeActivator activator, IDictionary<string, object> metadata)
        {
            Requires.NotNull(activator, nameof(activator));
            Requires.NotNull(metadata, nameof(metadata));

            _activator = activator;
            _metadata = metadata;
        }

        public override CompositeActivator Activator { get { return _activator; } }

        public override IDictionary<string, object> Metadata { get { return _metadata; } }
    }
}
