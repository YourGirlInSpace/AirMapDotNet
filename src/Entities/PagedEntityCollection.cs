using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// Represents a paged collection of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type represented in this collection.</typeparam>
    [JsonObject]
    public class PagedEntityCollection<T>
        : AirMapEntity, IList<T>
        where T : class, IAirMapEntity
    {
        /// <summary>
        /// The resultant array of <typeparamref name="T"/>.
        /// </summary>
        [JsonProperty("results")]
        private Collection<T> Results { get; } = new Collection<T>();

        /// <summary>
        /// The paged counts.
        /// </summary>
        [JsonProperty("paging")]
        private Paging Counts { get; set; }

        /// <summary>
        /// Represents the limit and total amount of results from a <see cref="PagedEntityCollection{T}"/>.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses")]
        [JsonObject]
        private class Paging
        {
            /// <summary>
            /// The maximum amount of items that may be returned in a single request.
            /// </summary>
            [JsonProperty("limit")]
            public int Limit { get; set; }
            
            /// <summary>
            /// The total amount of results.
            /// </summary>
            [JsonProperty("total")]
            public int Total { get; set; }
        }

        /// <inheritdoc />
        public IEnumerator<T> GetEnumerator() => Results.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <inheritdoc />
        public void Add(T item)
        {
            if (item.AirMap == null)
                item.AirMap = _airMapInst;
            if (item.RequestTime == DateTime.MinValue)
                item.RequestTime = _reqTime;

            Results.Add(item);
        }

        /// <inheritdoc />
        public void Clear() => Results.Clear();

        /// <inheritdoc />
        public bool Contains(T item) => Results.Contains(item);

        /// <inheritdoc />
        public void CopyTo(T[] array, int arrayIndex) => Results.CopyTo(array, arrayIndex);

        /// <inheritdoc />
        public bool Remove(T item) => Results.Remove(item);

        /// <inheritdoc />
        public int Count => Results.Count;

        /// <inheritdoc />
        public bool IsReadOnly => true;

        /// <inheritdoc />
        public int IndexOf(T item) => Results.IndexOf(item);

        /// <inheritdoc />
        public void Insert(int index, T item)
        {
            if (item.AirMap == null)
                item.AirMap = _airMapInst;
            if (item.RequestTime == DateTime.MinValue)
                item.RequestTime = _reqTime;

            Results.Insert(index, item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index) => Results.RemoveAt(index);

        /// <inheritdoc />
        public T this[int index]
        {
            get { return Results[index]; }
            set
            {
                Results[index] = value;

                if (Results[index].AirMap == null)
                    Results[index].AirMap = _airMapInst;
                if (Results[index].RequestTime == DateTime.MinValue)
                    Results[index].RequestTime = _reqTime;
            }
        }


        private AirMap _airMapInst;
        private DateTime _reqTime = DateTime.MinValue;

        /// <inheritdoc />
        public override AirMap AirMap
        {
            get { return _airMapInst; }
            set
            {
                _airMapInst = value;
                foreach (T t in Results)
                    t.AirMap = _airMapInst;
            }
        }

        /// <inheritdoc />
        public override DateTime RequestTime
        {
            get { return _reqTime; }
            set
            {
                _reqTime = value;
                foreach (T t in Results)
                    t.RequestTime = _reqTime;
            }
        }
    }
}