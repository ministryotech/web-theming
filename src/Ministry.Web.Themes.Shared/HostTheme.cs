using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Ministry.Web.Themes
{
    /// <summary>
    /// Options that link theme keys and hosts together.
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class HostTheme : IKeyedTheme
    {
        #region | Construction |

        /// <summary>
        /// Initializes a new instance of the <see cref="HostTheme"/> class.
        /// </summary>
        public HostTheme()
        {
            ValidHosts = new List<string>();
        }

        #endregion

        /// <summary>
        /// Gets or Sets the Hosts that are linked to this theme.
        /// </summary>
        public List<string> ValidHosts { get; set; }

        /// <summary>
        /// Gets or sets the theme key.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the theme title.
        /// </summary>
        public string Title { get; set; }
    }
}
