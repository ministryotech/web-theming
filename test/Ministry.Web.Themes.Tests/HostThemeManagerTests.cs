using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using NSubstitute;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Ministry.Web.Themes.Tests
{
    [Trait("Category", "Themes")]
    public class HostThemeManagerTests : IDisposable
    {
        private IHttpContextAccessor subContext;
        private IOptions<ThemeOptions<HostTheme>> subOptions;

        public HostThemeManagerTests()
        {
            subContext = Substitute.For<IHttpContextAccessor>();
            subOptions = Substitute.For<IOptions<ThemeOptions<HostTheme>>>();
        }

        public void Dispose()
        {
            subContext = null;
            subOptions = null;
        }

        [Theory]
        [InlineData("App1", "localhost", 44321)]
        [InlineData("App2", "localhost", 44322)]
        [InlineData("App3", "localhost", 44323)]
        [InlineData("App1", "app1.co.uk")]
        [InlineData("App2", "app2.co.uk")]
        [InlineData("App3", "app3.co.uk")]
        public void CanGetAThemeFromAHost(string expectedKey, string host, int? port = null)
        {
            subOptions.Value.Returns(BuildOptions());
            var fakeContext = new DefaultHttpContext();
            fakeContext.Request.Host = port.HasValue ? new HostString(host, port.Value) : new HostString(host);
            subContext.HttpContext.Returns(fakeContext);

            var objUt = new HostThemeManager(subOptions, subContext);
            var result = objUt.GetThemeKey();

            Assert.Equal(expectedKey, result);
        }

        [Fact]
        public void WillGetADefaultThemeIfNoHostFound()
        {
            subOptions.Value.Returns(BuildOptions());
            var fakeContext = new DefaultHttpContext();
            fakeContext.Request.Host = new HostString("cabbages.com");
            subContext.HttpContext.Returns(fakeContext);

            var objUt = new HostThemeManager(subOptions, subContext);
            var result = objUt.GetThemeKey();

            Assert.Equal("End", result);
        }

        [Fact]
        public void WillThrowAnExceptionIfNoHostFoundOrDefaultThemeDataProvided()
        {
            subOptions.Value.Returns(new ThemeOptions<HostTheme>());
            var fakeContext = new DefaultHttpContext();
            fakeContext.Request.Host = new HostString("cabbages.com");
            subContext.HttpContext.Returns(fakeContext);

            var objUt = new HostThemeManager(subOptions, subContext);
            Assert.Throws<InvalidOperationException>(() => objUt.GetThemeKey());
        }

        #region | Supporting Methods |

        private static ThemeOptions<HostTheme> BuildOptions()
            => new ThemeOptions<HostTheme>
            {
                Themes =
                {
                    new HostTheme
                    {
                        Key = "App1",
                        ValidHosts = { "localhost:44321", "app1.co.uk" }
                    },
                    new HostTheme
                    {
                        Key = "App2",
                        ValidHosts = { "localhost:44322", "app2.co.uk" }
                    },
                    new HostTheme
                    {
                        Key = "App3",
                        ValidHosts = { "localhost:44323", "app3.co.uk" }
                    },
                    new HostTheme
                    {
                        Key = "End"
                    }
                },
                DefaultThemeKey = "End"
            };

        #endregion
    }
}
