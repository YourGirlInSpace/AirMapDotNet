using System;
using System.Collections;
using System.Collections.Generic;

namespace AirMapDotNet.Entities
{
    /// <summary>
    /// Describes an unnamed list of <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T">The type contained within the collection.</typeparam>
    public sealed class EntityCollection<T> : AirMapEntity, IList<T>
        where T : class, IAirMapEntity
    {
        private readonly List<T> data = new List<T>();

        /// <inheritdoc />
        public IEnumerator<T> GetEnumerator() => data.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc />
        public void Add(T item)
        {
            if (item.AirMap == null)
                item.AirMap = _airMapInst;
            if (item.RequestTime == DateTime.MinValue)
                item.RequestTime = _reqTime;

            data.Add(item);
        }

        /// <inheritdoc />
        public void Clear() => data.Clear();

        /// <inheritdoc />
        public bool Contains(T item) => data.Contains(item);

        /// <inheritdoc />
        public void CopyTo(T[] array, int arrayIndex) => data.CopyTo(array, arrayIndex);

        /// <inheritdoc />
        public bool Remove(T item) => data.Remove(item);

        /// <inheritdoc />
        public int Count => data.Count;

        /// <inheritdoc />
        public bool IsReadOnly => false;

        /// <inheritdoc />
        public int IndexOf(T item) => data.IndexOf(item);

        /// <inheritdoc />
        public void Insert(int index, T item)
        {
            if (item.AirMap == null)
                item.AirMap = _airMapInst;
            if (item.RequestTime == DateTime.MinValue)
                item.RequestTime = _reqTime;

            data.Insert(index, item);
        }

        /// <inheritdoc />
        public void RemoveAt(int index) => data.RemoveAt(index);

        /// <inheritdoc />
        public T this[int index]
        {
            get => data[index];
            set {
                data[index] = value;

                if (data[index].AirMap == null)
                    data[index].AirMap = _airMapInst;
                if (data[index].RequestTime == DateTime.MinValue)
                    data[index].RequestTime = _reqTime;
            }
        }

        private AirMap _airMapInst;
        private DateTime _reqTime = DateTime.MinValue;

        /// <inheritdoc />
        public override AirMap AirMap
        {
            get => _airMapInst;
            set { _airMapInst = value;
                foreach (T t in data)
                    t.AirMap = _airMapInst;
            }
        }

        /// <inheritdoc />
        public override DateTime RequestTime
        {
            get => _reqTime;
            set
            {
                _reqTime = value;
                foreach (T t in data)
                    t.RequestTime = _reqTime;
            }
        }
    }
}