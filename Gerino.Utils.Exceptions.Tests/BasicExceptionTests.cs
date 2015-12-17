using System;
using Should;
using Xunit;

namespace Gerino.Utils.Exceptions.Tests
{
    public abstract class BasicExceptionTests<T> where T:Exception
    {
        [Fact]
        public void NameEndsInException()
        {
            typeof (T).Name.EndsWith("Exception").ShouldBeTrue();
        }

        [Fact]
        public void IsSerializable()
        {
            typeof(T).IsSerializable.ShouldBeTrue();
        }
    }
}