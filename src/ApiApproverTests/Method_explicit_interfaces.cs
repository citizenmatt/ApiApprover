﻿using System;
using ApiApproverTests.Examples;
using Xunit;

namespace ApiApproverTests
{
    public class Method_explicit_interfaces : ApiGeneratorTestsBase
    {
        [Fact]
        public void Should_not_output_interface_name_for_explicit_implementation()
        {
            // TODO: Should explicitly implemented methods be output?
            // Possibly not. While they are a public API, the fact that an
            // implementation has changed is not as important as the interface changing
            AssertPublicApi<MethodWithExplicitImplementation>(
@"namespace ApiApproverTests.Examples
{
    public class MethodWithExplicitImplementation : System.IDisposable { }
}");
        }
    }

    // ReSharper disable ClassNeverInstantiated.Global
    namespace Examples
    {
        public class MethodWithExplicitImplementation : IDisposable
        {
            void IDisposable.Dispose()
            {
            }
        }
    }
    // ReSharper restore ClassNeverInstantiated.Global
}