using System;
using FluentAssertions;
using Xunit;

namespace Playground
{
    public sealed class PlaygroundTests
    {
        [Fact]
        public void NickNameMustNotBeNull()
        {
            Action act = () => new Account(null);

            act.Should().Throw<ArgumentNullException>();
        }
    }

    public class Account
    {
        private readonly string _nickName;
        public Account(string nickName)
        {

        }
    }
}
