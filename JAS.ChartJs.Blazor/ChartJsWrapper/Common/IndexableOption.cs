using ChartJsWrapper.Common.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common
{
    [Newtonsoft.Json.JsonConverter(typeof(IndexableOptionConverter))]   // newtonsoft for now
    public class IndexableOption<T> : IEquatable<IndexableOption<T>>
    {
        /// The compile-time name of the property which gets the wrapped value. This is used internally for serialization.
        internal const string PropertyName = nameof(BoxedValue);

        // for serialization, there has to be a cast to object anyway
        internal object BoxedValue => IsIndexed ? (object)IndexedValues : SingleValue;

        private readonly T[] _indexedValues;

        /// The indexed values represented by this instance.
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

        /// The single value represented by this instance.
        public T SingleValue
        {
            get
            {
                if (IsIndexed)
                    throw new InvalidOperationException("This instance represents an array of values. The single value is not available.");

                return _singleValue;
            }
        }

        /// Gets the value indicating whether the option wrapped in this <see cref="IndexableOption{T}"/> is indexed.
        /// <para>True if the wrapped value represents an array of <typeparamref name="T"/>, false if it represents a single value of <typeparamref name="T"/>.</para>
        public bool IsIndexed { get; }

        /// Creates a new instance of <see cref="IndexableOption{T}"/> which represents a single value.
        /// <param name="singleValue">The single value this <see cref="IndexableOption{T}"/> should represent.</param>
        public IndexableOption(T singleValue)
        {
            _singleValue = singleValue != null ? singleValue : throw new ArgumentNullException(nameof(singleValue));
            IsIndexed = false;
        }

        /// Creates a new instance of <see cref="IndexableOption{T}"/> which represents an array of values.
        /// <param name="indexedValues">The array of values this <see cref="IndexableOption{T}"/> should represent.</param>
        public IndexableOption(T[] indexedValues)
        {
            _indexedValues = indexedValues ?? throw new ArgumentNullException(nameof(indexedValues));
            IsIndexed = true;
        }

        /// Implicitly wraps a single value of <typeparamref name="T"/> to a new instance of <see cref="IndexableOption{T}"/>.
        /// <param name="singleValue">The single value to wrap</param>
        public static implicit operator IndexableOption<T>(T singleValue)
        {
            CheckIsNotIndexableOption(singleValue.GetType());

            return new IndexableOption<T>(singleValue);
        }

        /// Implicitly wraps an array of values of <typeparamref name="T"/> to a new instance of <see cref="IndexableOption{T}"/>.
        /// <param name="indexedValues">The array of values to wrap</param>
        public static implicit operator IndexableOption<T>(T[] indexedValues)
        {
            CheckIsNotIndexableOption(indexedValues.GetType().GetElementType());

            return new IndexableOption<T>(indexedValues);
        }

        private static void CheckIsNotIndexableOption(Type type)
        {
            if (!type.IsGenericType) return;
            if (type.GetGenericTypeDefinition() == typeof(IndexableOption<>))
                throw new ArgumentException("You cannot use an indexable option inside an indexable option.");
        }

        /// Determines whether the specified <see cref="IndexableOption{T}"/> instance is considered equal to the current instance.
        /// <param name="other">The <see cref="IndexableOption{T}"/> to compare with.</param>
        /// <returns>true if the objects are considered equal; otherwise, false.</returns>
        public bool Equals(IndexableOption<T> other)
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

        /// Determines whether the specified object instance is considered equal to the current instance.
        /// <param name="obj">The object to compare with.</param>
        /// <returns>true if the objects are considered equal; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            // an indexable option cannot store null
            if (obj == null) return false;

            if (obj is IndexableOption<T> option)
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

        /// Returns the hash of the underlying object.
        /// <returns>The hash of the underlying object.</returns>
        public override int GetHashCode()
        {
            var hashCode = -506568782;
            hashCode = hashCode * -1521134295 + EqualityComparer<T[]>.Default.GetHashCode(_indexedValues);
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(_singleValue);
            hashCode = hashCode * -1521134295 + IsIndexed.GetHashCode();
            return hashCode;
        }

        /// Determines whether two specified <see cref="IndexableOption{T}"/> instances contain the same value.
        /// <param name="a">The first <see cref="IndexableOption{T}"/> to compare</param>
        /// <param name="b">The second <see cref="IndexableOption{T}"/> to compare</param>
        /// <returns>true if the value of a is the same as the value of b; otherwise, false.</returns>
        public static bool operator ==(IndexableOption<T> a, IndexableOption<T> b) => a.Equals(b);

        /// Determines whether two specified <see cref="IndexableOption{T}"/> instances contain different values.
        /// <param name="a">The first <see cref="IndexableOption{T}"/> to compare</param>
        /// <param name="b">The second <see cref="IndexableOption{T}"/> to compare</param>
        /// <returns>true if the value of a is different from the value of b; otherwise, false.</returns>
        public static bool operator !=(IndexableOption<T> a, IndexableOption<T> b) => !(a == b);
    }
}
