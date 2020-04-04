using System;
using HotChocolate.Language;

namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The base class for all custom string types.
    /// </summary>
    public abstract class CustomStringType : ScalarType
    {
        /// <inheritdoc />
        protected CustomStringType(string name) : base(name)
        {
        }

        /// <inheritdoc />
        public override bool IsInstanceOfType(IValueNode literal)
        {
            if (literal == null)
            {
                throw new ArgumentNullException(nameof(literal));
            }

            return literal is StringValueNode || literal is NullValueNode;
        }

        /// <inheritdoc />
        public override object ParseLiteral(IValueNode literal)
        {
            if (literal == null)
            {
                throw new ArgumentNullException(nameof(literal));
            }

            if (literal is NullValueNode)
            {
                return null;
            }

            if (literal is StringValueNode stringLiteral)
            {
                return stringLiteral.Value;
            }

            throw new ArgumentException(
                $"The {GetType().Name} can only parse string literals.",
                nameof(literal));
        }

        /// <inheritdoc />
        public override IValueNode ParseValue(object value)
        {
            if (value == null)
            {
                return new NullValueNode(null);
            }

            if (value is string stringValue)
            {
                return new StringValueNode(stringValue);
            }

            throw new ArgumentException(
                $"The specified value has to be a string in order to be parsed by the {GetType().Name}.");
        }

        /// <inheritdoc />
        public override object Serialize(object value)
        {
            if (value == null)
            {
                return null;
            }

            if (value is string stringValue)
            {
                return stringValue;
            }

            throw new ArgumentException(
                $"The specified value cannot be serialized by the {GetType().Name}.");
        }

        /// <inheritdoc />
        public override bool TryDeserialize(object serialized, out object value)
        {
            if (serialized is null)
            {
                value = null;
                return true;
            }

            if (serialized is string stringValue)
            {
                value = stringValue;
                return true;
            }

            value = null;
            return false;
        }

        /// <inheritdoc />
        public override Type ClrType => typeof(string);
    }
}