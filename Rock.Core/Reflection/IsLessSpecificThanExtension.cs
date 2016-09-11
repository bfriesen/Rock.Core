using System;
using System.Reflection;

namespace Rock.Reflection
{
    public static class IsLessSpecificThanExtension
    {
        public static bool IsLessSpecificThan(this Type thisType, Type comparisonType)
        {
            return thisType != comparisonType && thisType.GetTypeInfo().IsAssignableFrom(comparisonType);
        }
    }
}
