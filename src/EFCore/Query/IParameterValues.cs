// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Query
{
    public interface IParameterValues
    {
        IReadOnlyDictionary<string, object> ParameterValues { get; }

        void Add([NotNull] string name, [CanBeNull] object value);

        object Remove([NotNull] string name);

        void Replace([NotNull] string name, [CanBeNull] object value);
    }
}
