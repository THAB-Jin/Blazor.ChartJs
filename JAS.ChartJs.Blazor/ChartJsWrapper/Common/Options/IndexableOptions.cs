using ChartJsWrapper.Common.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Options
{
    [Newtonsoft.Json.JsonConverter(typeof(IndexableOptionsConverter))]   // newtonsoft for now
    public class IndexableOptions<T> : IEquatable<IndexableOptions<T>>
    {
        /// <summary>
        /// The compile-time name of the property which gets the wrapped value. This is used internally for serialization.
        /// </summary>
        internal const string PropertyName = nameof(BoxedValue);

        // for serialization, there has to be a cast to object anyway
        internal object BoxedValue => IsIndexed ? (object)IndexedValues : SingleValue;

        private readonly T[] _indexedValues;

        /// <summary>
        /// The indexed values represented by this instance.
        /// </summary>
        public T[] IndexedValues
        {
            get
            {
                if (!IsIndexed)
                    throw new InvalidOperationException("This instance represents a single value. The indexed values are not available.");

                return _indexedValues;
            }
        }

        private readonly T _singleValue;

        /// <summary>
        /// The single value represented by this instance.
        /// </summary>
        public T SingleValue
        {
            get
            {
                if (IsIndexed)
                    throw new InvalidOperationException("This instance represents an array of values. The single value is not available.");

                return _singleValue;
            }
        }

        /// <summary>
        /// Gets the value indicating whether the option wrapped in this <see cref="IndexableOptions{T}"/> is indexed.
        /// <para>True if the wrapped value represents an array of <typeparamref name="T"/>, false if it represents a single value of <typeparamref name="T"/>.</para>
        /// </summary>
        public bool IsIndexed { get; }

        /// <summary>
        /// Creates a new instance of <see cref="IndexableOptions{T}"/> which represents a single value.
        /// </summary>
        /// <param name="singleValue">The single value this <see cref="IndexableOptions{T}"/> should represent.</param>
        public IndexableOptions(T singleValue)
        {
            _singleValue = singleValue != null ? singleValue : throw new ArgumentNullException(nameof(singleValue));
            IsIndexed = false;
        }

        /// <summary>
        /// Creates a new instance of <see cref="IndexableOptions{T}"/> which represents an array of values.
        /// </summary>
        /// <param name="indexedValues">The array of values this <see cref="IndexableOptions{T}"/> should represent.</param>
        public IndexableOptions(T[] indexedValues)
        {
            _indexedValues = indexedValues ?? throw new ArgumentNullException(nameof(indexedValues));
            IsIndexed = true;
        }

        /// <summary>
        /// Implicitly wraps a single value of <typeparamref name="T"/> to a new instance of <see cref="IndexableOptions{T}"/>.
        /// </summary>
        /// <param name="singleValue">The single value to wrap</param>
        public static implicit operator IndexableOptions<T>(T singleValue)
        {
            CheckIsNotIndexableOptions(singleValue.GetType());

            return new IndexableOptions<T>(singleValue);
        }

        /// <summary>
        /// Implicitly wraps an array of values of <typeparamref name="T"/> to a new instance of <see cref="IndexableOptions{T}"/>.
        /// </summary>
        /// <param name="indexedValues">The array of values to wrap</param>
        public static implicit operator IndexableOptions<T>(T[] indexedValues)
        {
            CheckIsNotIndexableOptions(indexedValues.GetType().GetElementType());

            return new IndexableOptions<T>(indexedValues);
        }

        private static void CheckIsNotIndexableOptions(Type type)
        {
            if (!type.IsGenericType) return;
            if (type.GetGenericTypeDefinition() == typeof(IndexableOptions<>))
                throw new ArgumentException("You cannot use an indexable option inside an indexable option.");
        }

        /// <summary>
        /// Determines whether the specified <see cref="IndexableOptions{T}"/> instance is considered equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="IndexableOptions{T}"/> to compare with.</param>
        /// <returns>true if the objects are considered equal; otherwise, false.</returns>
        public bool Equals(IndexableOptions<T> other)
        {
            if (IsIndexed != other.IsIndexed) return false;

            if (IsIndexed)
            {
                if (IndexedValues == other.IndexedValues) return true;

                return Enumerable.SequenceEqual(IndexedValues, other.IndexedValues);
            }
            else
            {
                return EqualityComparer<T>.Default.Equals(SingleValue, other.SingleValue);
            }
        }

        /// <summary>
        /// Determines whether the specified object instance is considered equal to the current instance.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns>true if the objects are considered equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            // an indexable option cannot store null
            if (obj == null) return false;

            if (obj is IndexableOptions<T> option)
            {
                return Equals(option);
            }
            else
            {
                if (IsIndexed)
                {
                    return IndexedValues.Equals(obj);
                }
                else
                {
                    return SingleValue.Equals(obj);
                }
            }
        }

        /// <summary>
        /// Returns the hash of the underlying object.
        /// </summary>
        /// <returns>The hash of the underlying object.</returns>
        public override int GetHashCode()
        {
            var hashCode = -506568782;
            hashCode = hashCode * -1521134295 + EqualityComparer<T[]>.Default.GetHashCode(_indexedValues);
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(_singleValue);
            hashCode = hashCode * -1521134295 + IsIndexed.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Determines whether two specified <see cref="IndexableOptions{T}"/> instances contain the same value.
        /// </summary>
        /// <param name="a">The first <see cref="IndexableOptions{T}"/> to compare</param>
        /// <param name="b">The second <see cref="IndexableOptions{T}"/> to compare</param>
        /// <returns>true if the value of a is the same as the value of b; otherwise, false.</returns>
        public static bool operator ==(IndexableOptions<T> a, IndexableOptions<T> b) => a.Equals(b);

        /// <summary>
        /// Determines whether two specified <see cref="IndexableOptions{T}"/> instances contain different values.
        /// </summary>
        /// <param name="a">The first <see cref="IndexableOptions{T}"/> to compare</param>
        /// <param name="b">The second <see cref="IndexableOptions{T}"/> to compare</param>
        /// <returns>true if the value of a is different from the value of b; otherwise, false.</returns>
        public static bool operator !=(IndexableOptions<T> a, IndexableOptions<T> b) => !(a == b);
    }
}
