namespace Ministry.Web.Themes
{
    /// <summary>
    /// Manages Theming
    /// </summary>
    public interface IThemeManager
    {
        /// <summary>
        /// Gets the host theme.
        /// </summary>
        /// <returns>A host theme.</returns>
        HostTheme GetHostTheme();

        /// <summary>
        /// Gets the theme key.
        /// </summary>
        /// <returns>A theme key string.</returns>
        string GetThemeKey();

        /// <summary>
        /// Gets the theme title.
        /// </summary>
        /// <returns>The theme title, or the key if no title is set.</returns>
        string GetThemeTitle();
    }
}