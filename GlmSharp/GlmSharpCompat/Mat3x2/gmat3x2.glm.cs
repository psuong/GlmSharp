using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    /// <summary>
    /// Static class that contains static glm functions
    /// </summary>
    public static partial class glm
    {
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public static T[,] Values<T>(gmat3x2<T> m) where T : unmanaged => m.Values;
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public static T[] Values1D<T>(gmat3x2<T> m) where T : unmanaged => m.Values1D;
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public static IEnumerator<T> GetEnumerator<T>(gmat3x2<T> m) where T : unmanaged => m.GetEnumerator();

    }
}
