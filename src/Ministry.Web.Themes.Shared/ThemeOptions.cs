using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Ministry.Web.Themes
{
    /// <summary>
    /// Available Themes
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global", Justification = "Options")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global", Justification = "Options")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Global", Justification = "Options")]
    public class ThemeOptions<TTheme>
        where TTheme : class, IKeyedTheme
    {
        #region | Construction |

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeOptions{TTheme}"/> class.
        /// </summary>
        public ThemeOptions()
        {
            Themes = new List<TTheme>();
        }

        #endregion

        /// <summary>
        /// Gets available Themes.
        /// </summary>
        public List<TTheme> Themes { get; set; }

        /// <summary>
        /// Gets the default theme key if no other configuration matches.
        /// </summary>
        public string DefaultThemeKey { get; set; }
    }
}
