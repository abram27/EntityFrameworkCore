// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.Infrastructure
{
    public class ModelCacheKeyFactory : IModelCacheKeyFactory
    {
        public virtual object Create(DbContext context) => new ModelCacheKey(context);
    }
}