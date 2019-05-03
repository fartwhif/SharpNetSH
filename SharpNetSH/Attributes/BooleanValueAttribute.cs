using System;

namespace SharpNetSH
{
    [AttributeUsage(AttributeTargets.Field)]
    internal class BooleanValueAttribute : Attribute
    {
		public String TrueValue { get; private set; }
		public String FalseValue { get; private set; }

        public BooleanValueAttribute(string trueValue, string falseValue)
        {
            TrueValue = trueValue;
            FalseValue = falseValue;
        }
    }
}