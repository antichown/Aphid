﻿using Components.ObjectDatabase;

namespace Components.ObjectDatabase.Tests
{
    public static class ObjectDatabaseFluentExtensions
    {
        public static ObjectDatabase<TElement> Set<TElement>(
            this ObjectDatabase<TElement> db,
            bool setEntityMetaData = false,
            bool trackEntities = false,
            bool isReadOnly = false,
            int pageSize = -1) => db
            .DoIf(pageSize > 0, x => x.UpdateMemoryManager(y => y.PageSize = pageSize))
            .Do(x => x.SetEntityMetaData = setEntityMetaData)
            .Do(x => x.TrackEntities = trackEntities)
            .Do(x => x.IsReadOnly = isReadOnly);
    }
}
