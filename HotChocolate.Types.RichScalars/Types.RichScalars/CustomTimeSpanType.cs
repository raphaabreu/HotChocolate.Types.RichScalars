using System;
using System.Globalization;
using HotChocolate.Language;

namespace HotChocolate.Types.RichScalars
{
    /// <summary>
    /// The base class for all custom TimeSpan types.
    /// </summary>
    public abstract class CustomTimeSpanType : ScalarType
    {
        /// <inheritdoc />
        protected CustomTimeSpanType(string name) : base(name)
        {
        }

        protected abstract double ConvertToDouble(TimeSpan value);
        protected abstract TimeSpan ConvertToTimeSpan(double value);

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
                return ConvertToTimeSpan(Convert.ToDouble(floatLiteral.Value));
            }
            if (literal is IntValueNode intLiteral)
            {
                return ConvertToTimeSpan(Convert.ToDouble(intLiteral.Value));
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

            if (value is TimeSpan t)
            {
                return new FloatValueNode(ConvertToDouble(t));
            }

            throw new ArgumentException(
                $"The specified value has to be a TimeSpan in order to be parsed by the {GetType().Name}.");
        }

        /// <inheritdoc />
        public override object Serialize(object value)
        {
            if (value == null)
            {
                return null;
            }

            if (value is TimeSpan t)
            {
                return ConvertToDouble(t);
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
                value = ConvertToTimeSpan(d);
                return true;
            }

            value = null;
            return false;
        }

        /// <inheritdoc />
        public override Type ClrType => typeof(TimeSpan);
    }
}