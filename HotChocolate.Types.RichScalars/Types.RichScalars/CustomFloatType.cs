using System;
using System.Globalization;
using HotChocolate.Language;

namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The base class for all custom numeric types.
    /// </summary>
    public abstract class CustomFloatType : ScalarType
    {
        /// <inheritdoc />
        protected CustomFloatType(string name) : base(name)
        {
        }

        /// <inheritdoc />
        public override bool IsInstanceOfType(IValueNode literal)
        {
            if (literal == null)
            {
                throw new ArgumentNullException(nameof(literal));
            }

            return literal is FloatValueNode || literal is IntValueNode || literal is NullValueNode;
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

            if (literal is FloatValueNode floatLiteral)
            {
                return Convert.ToDouble(floatLiteral.Value);
            }
            if (literal is IntValueNode intLiteral)
            {
                return Convert.ToDouble(intLiteral.Value);
            }

            throw new ArgumentException(
                $"The {GetType().Name} can only parse number literals.",
                nameof(literal));
        }

        /// <inheritdoc />
        public override IValueNode ParseValue(object value)
        {
            if (value == null)
            {
                return new NullValueNode(null);
            }

            if (double.TryParse(Convert.ToString(value, CultureInfo.InvariantCulture), out var d))
            {
                return new FloatValueNode(d);
            }

            throw new ArgumentException(
                $"The specified value has to be a number in order to be parsed by the {GetType().Name}.");
        }

        /// <inheritdoc />
        public override object Serialize(object value)
        {
            if (value == null)
            {
                return null;
            }

            if (double.TryParse(Convert.ToString(value, CultureInfo.InvariantCulture), out var d))
            {
                return d;
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

            if (double.TryParse(Convert.ToString(serialized, CultureInfo.InvariantCulture), out var d))
            {
                value = d;
                return true;
            }

            value = null;
            return false;
        }

        /// <inheritdoc />
        public override Type ClrType => typeof(double);
    }
}