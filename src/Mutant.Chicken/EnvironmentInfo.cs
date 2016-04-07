﻿using System.Collections;
using System.Collections.Generic;

namespace Mutant.Chicken
{
    public interface IEnvironmentInfo : IReadOnlyDictionary<string, object>
    {
    }

    internal class EnvironmentInfo : IEnvironmentInfo
    {
        private IReadOnlyDictionary<string, object> _source;

        public EnvironmentInfo(IReadOnlyDictionary<string, object> source)
        {
            _source = source;
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => _source.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int Count => _source.Count;

        public bool ContainsKey(string key) => _source.ContainsKey(key);

        public bool TryGetValue(string key, out object value) => _source.TryGetValue(key, out value);

        public object this[string key] => _source[key];

        public IEnumerable<string> Keys => _source.Keys;

        public IEnumerable<object> Values => _source.Values;
    }
}