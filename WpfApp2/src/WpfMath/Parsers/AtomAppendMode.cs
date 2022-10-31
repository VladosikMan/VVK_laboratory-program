namespace WpfMath.Parsers
{
    /// <summary>An enumeration that describes how an atom generated by a command should be handled.</summary>
    internal enum AtomAppendMode
    {
        /// <summary>A new atom will be added to the end of the current formula.</summary>
        Add,

        /// <summary>A new atom will replace an entire existing formula.</summary>
        /// <remarks>Useful for commands that wrap or somehow process the existing formula.</remarks>
        Replace
    }
}
