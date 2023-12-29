using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Ministry.Web.Themes
{
    /// <summary>
    /// Options that link theme keys and hosts together.
    /// </summary>
    /// <seealso cref="IKeyedTheme"/>
    /// <inheritdoc cref="IKeyedTheme"/>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global", Justification = "Library")]
    [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Library")]
    [SuppressMessage("ReSharper", "CollectionNeverUpdated.Global", Justification = "Library")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Global", Justification = "Library")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global", Justification = "Library")]
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

        /// <inheritdoc/>>
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets the Hosts that are linked to this theme.
        /// </summary>
        public List<string> ValidHosts { get; set; }

        /// <summary>
        /// Gets or sets the theme title.
        /// </summary>
        public string Title { get; set; }
    }
}
