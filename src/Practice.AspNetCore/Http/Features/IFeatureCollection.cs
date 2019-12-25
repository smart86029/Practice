using System;
using System.Collections.Generic;

namespace Practice.AspNetCore.Http.Features
{
    public interface IFeatureCollection : IDictionary<Type, object>
    {
        TFeature Get<TFeature>();

        void Set<TFeature>(TFeature feature);
    }
}