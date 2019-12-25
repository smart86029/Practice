using System;
using System.Collections.Generic;
using Practice.AspNetCore.Http.Features;

namespace Practice.AspNetCore.Servers.Mini
{
    internal class FeatureCollection : Dictionary<Type, object>, IFeatureCollection
    {
        public TFeature Get<TFeature>()
        {
            return TryGetValue(typeof(TFeature), out var value) ? (TFeature)value : default;
        }

        public void Set<TFeature>(TFeature feature)
        {
            this[typeof(TFeature)] = feature;
        }
    }
}