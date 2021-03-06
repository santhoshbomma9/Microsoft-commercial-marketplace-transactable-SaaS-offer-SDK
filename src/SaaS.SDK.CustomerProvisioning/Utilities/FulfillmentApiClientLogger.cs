﻿using Microsoft.Extensions.Logging;
using Microsoft.Marketplace.SaasKit.Services;
using System;

namespace Microsoft.Marketplace.SaasKit.Client.Utilities
{
    public class FulfillmentApiClientLogger: Contracts.ILogger
    {
        protected readonly ILogger<FulfillmentApiClient> logger;

        public FulfillmentApiClientLogger()
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddConsole();
            });

            this.logger = loggerFactory.CreateLogger<FulfillmentApiClient>();
        }

        public void Debug(string message)
        {
            logger.LogDebug(message);
        }

        public void Debug(string message, Exception ex)
        {
            logger.LogDebug(ex, message);
        }

        public void Error(string message)
        {
            logger.LogError(message);
        }

        public void Error(string message, Exception ex)
        {
            logger.LogError(ex, message);
        }

        public void Info(string message)
        {
            logger.LogInformation(message);
        }

        public void Info(string message, Exception ex)
        {
            logger.LogInformation(ex, message);
        }

        public void Warn(string message)
        {
            logger.LogWarning(message);
        }

        public void Warn(string message, Exception ex)
        {
            logger.LogWarning(ex, message);
        }
    }
}
