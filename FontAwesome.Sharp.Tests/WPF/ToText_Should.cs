using System;
using System.Linq;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace FontAwesome.Sharp.Tests.WPF
{
    // ReSharper disable once InconsistentNaming
    public class ToText_Should
    {
        [Theory]
        [InlineData(IconChar.Accusoft)]
        public void Be_Creatable(IconChar iconChar)
        {
            var markupExtension = new ToText(iconChar);
            markupExtension.Should().NotBeNull();
            var serviceProvider = Substitute.For<IServiceProvider>();
            var text = (string)markupExtension.ProvideValue(serviceProvider);
            text.Single().Should().Be(iconChar.ToChar());
        }
    }
}
