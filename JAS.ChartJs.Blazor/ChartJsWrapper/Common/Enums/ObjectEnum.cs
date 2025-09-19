using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    // The base class for enums that can represent different types. We also use these
    [Newtonsoft.Json.JsonConverter(typeof(Serialization.JsonObjectEnumConverter))]
    public abstract class ObjectEnum : IEquatable<ObjectEnum>
    {
        /// <summary>
        /// Gets the <see cref="Type"/>s that are supported for serialization and deserialization.
        /// <see cref="ObjectEnum"/> can contain objects of different types but you will get a
        /// <see cref="NotSupportedException"/> once you try to serialize (or deserialize) that
        /// <see cref="ObjectEnum"/>.
        /// </summary>
        private static readonly Type[] _supportedSerializationTypes = new[]
        {
            typeof(int), typeof(double), typeof(string), typeof(bool)
        };

        /// <summary>
        /// Holds the actual value represented by this instance.
        /// </summary>
        internal object Value { get; }

        /// <summary>
        /// Creates a new instance of <see cref="ObjectEnum"/>.
        /// </summary>
        /// <param name="value">The value this instance is supposed to represent.</param>
        protected ObjectEnum(object value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));

            if (value is ObjectEnum)
                throw new ArgumentException("The value cannot be an ObjectEnum. " +
                                            "Recursive ObjectEnums aren't allowed.");
        }

        /// <summary>
        /// Checks if a <see cref="Type"/> is in the list of supported serialization types.
        /// If this function returns <see langword="false"/>, de-/serialization will fail on
        /// <see cref="ObjectEnum"/>s containing an instance of that <see cref="Type"/>
        /// (<paramref name="type"/>).
        /// </summary>
        /// <param name="type">The <see cref="Type"/> to check.</param>
        internal static bool IsSupportedSerializationType(Type type) =>
            _supportedSerializationTypes.Contains(type);

        /// <summary>
        /// Determines whether the specified object is considered equal to the current object.
        /// <para>
        /// <paramref name="obj"/> is considered to be equal to this instance if it..
        /// <list type="bullet">
        /// <item>is the same instance as this instance.</item>
        /// <item>is another <see cref="ObjectEnum"/> with the same internal value.</item>
        /// <item>is the same value as the internal value of this <see cref="ObjectEnum"/>.</item>
        /// </list>
        /// </para>
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is considered to be equal to the current object;
        /// otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is ObjectEnum asEnum)
            {
                return Equals(asEnum);
            }

            return Value.Equals(obj);
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.
        /// </returns>
        public bool Equals(ObjectEnum other) =>
            other != null &&
            Value.Equals(other.Value);

        /// <summary>
        /// Returns the hash code of the underlying value.
        /// </summary>
        /// <returns>The hash code of the underlying value.</returns>
        public override int GetHashCode() => Value.GetHashCode();

        /// <summary>
        /// Returns the <see cref="string"/> representation of the underlying object.
        /// Calls <see cref="object.ToString"/> on the underlying object.
        /// </summary>
        /// <returns>The <see cref="string"/> representation of the underlying object.</returns>
        public override string ToString() => Value.ToString();

        public static bool operator ==(ObjectEnum left, ObjectEnum right) =>
            EqualityComparer<object>.Default.Equals(left?.Value, right?.Value);

        public static bool operator !=(ObjectEnum left, ObjectEnum right) => !(left == right);
    }
}
