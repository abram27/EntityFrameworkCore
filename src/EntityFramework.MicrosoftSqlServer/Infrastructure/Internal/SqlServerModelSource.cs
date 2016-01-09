// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Internal;
using Microsoft.Data.Entity.Metadata.Conventions.Internal;

namespace Microsoft.Data.Entity.Infrastructure.Internal
{
    public class SqlServerModelSource : ModelSource
    {
        public SqlServerModelSource([NotNull] IDbSetFinder setFinder, [NotNull] ICoreConventionSetBuilder coreConventionSetBuilder, [NotNull] IModelCustomizer modelCustomizer, [NotNull] IModelCacheKeyFactory modelCacheKeyFactory)
            : base(setFinder, coreConventionSetBuilder, modelCustomizer, modelCacheKeyFactory)
        {
        }
    }
}
