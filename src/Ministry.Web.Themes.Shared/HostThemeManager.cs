﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;

namespace Ministry.Web.Themes
{
    /// <summary>
    /// Manages Theming
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class HostThemeManager : IThemeManager
    {
        private readonly string defaultThemeKey;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly List<HostTheme> themes;

        #region | Construction |

        /// <summary>
        /// Initializes a new instance of the <see cref="HostThemeManager" /> class.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="httpContextAccessor">The HTTP context accessor.</param>
        public HostThemeManager(IOptions<ThemeOptions<HostTheme>> options,
            IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;

            themes = options.Value.Themes;
            defaultThemeKey = options.Value.DefaultThemeKey;
        }

        #endregion | Construction |

        /// <summary>
        /// Gets the host theme.
        /// </summary>
        /// <returns>A host theme.</returns>
        public HostTheme GetHostTheme()
        {
            var host = GetHost();
            foreach (var theme in themes)
                if (theme.ValidHosts.Contains(host))
                    return theme;
            
            return themes.FirstOrDefault(theme => theme.Key == defaultThemeKey)
                ?? throw new InvalidOperationException("The 'DefaultThemeKey' configuration setting is missing or invalid.");
        }

        /// <summary>
        /// Gets the theme key.
        /// </summary>
        /// <returns>A theme key string.</returns>
        public string GetThemeKey() => GetHostTheme().Key;

        /// <summary>
        /// Gets the theme title.
        /// </summary>
        /// <returns>The theme title, or the key if no title is set.</returns>
        public string GetThemeTitle()
        {
            var theme = GetHostTheme();
            return theme.Title ?? theme.Key;
        }

        #region | Private Methods |

        /// <summary>
        /// Accesses the current host url.
        /// </summary>
        /// <returns>The current host url.</returns>
        private string GetHost() => httpContextAccessor.HttpContext.Request.Host.ToString();

        #endregion | Private Methods |

    }
}