﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AgonesSdkCsharp.Hosting.Tests
{
    public class OptionsTest
    {
        [Fact]
        public void AssertHostingOptionDefaultValue()
        {
            var options = new AgonesSdkHostingOptions();
            Assert.True(options.UseDefaultHttpClientFactory);
            Assert.True(options.RegisterHealthCheckService);
            Assert.Equal(3, options.FailedRetryCount);
            Assert.Equal(5, options.HandledEventsAllowedBeforeCirtcuitBreaking);
            Assert.Equal(TimeSpan.FromSeconds(30), options.CirtcuitBreakingDuration);
            Assert.NotNull(options.OnRetry);
            Assert.NotNull(options.OnBreak);
            Assert.NotNull(options.OnReset);
            Assert.NotNull(options.OnHalfOpen);
        }
    }
}
