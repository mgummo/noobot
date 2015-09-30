﻿using Noobot.Domain.MessagingPipeline;
using Noobot.Domain.MessagingPipeline.Middleware.StandardMiddleware;

namespace Noobot.Runner
{
    public class PipelineManager : PipelineManagerBase
    {
        public override void Initialise()
        {
            Use<ErrorHandlerMiddleware>();
            Use<BeginMessageMiddleware>();
            Use<HelpMiddleware>();
            Use<TestMiddleware>();
            Use<UnhandledMessageMiddleware>();
        }
    }
}