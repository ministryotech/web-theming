using System.Diagnostics.CodeAnalysis;

namespace Ministry.Web.Themes
{
    /// <summary>
    /// Representation of a theme with a key.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMemberInSuper.Global", Justification = "Library")]
    public interface IKeyedTheme
    {
        /// <summary>
        /// Gets or sets the theme key.
        /// </summary>
        string Key { get; set; }
    }
}