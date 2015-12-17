using System;
using System.Linq;
using System.Reflection;
using Gerino.Utils.Exceptions;
using Should;
using Xunit;

namespace Gerino.Utils.Exceptions.Tests
{
    public class UnreachableCodeExceptionTests : BasicExceptionTests<UnreachableCodeException>
    {
        [Fact]
        public void HasParameterlessConstructor()
        {
            typeof (UnreachableCodeException).GetConstructor(Type.EmptyTypes).ShouldNotBeNull();
        }
    }
}