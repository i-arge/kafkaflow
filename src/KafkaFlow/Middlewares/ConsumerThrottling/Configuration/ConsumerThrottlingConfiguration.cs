namespace KafkaFlow.Middlewares.ConsumerThrottling.Configuration
{
    using System;
    using System.Collections.Generic;

    internal class ConsumerThrottlingConfiguration
    {
        public ConsumerThrottlingConfiguration(
            TimeSpan evaluationInterval,
            IReadOnlyList<IConsumerThrottlingMetric> metrics,
            IReadOnlyList<IConsumerThrottlingThreshold> thresholds)
        {
            this.EvaluationInterval = evaluationInterval;
            this.Metrics = metrics;
            this.Thresholds = thresholds;
        }

        public TimeSpan EvaluationInterval { get; }

        public IReadOnlyList<IConsumerThrottlingMetric> Metrics { get; }

        public IReadOnlyList<IConsumerThrottlingThreshold> Thresholds { get; }
    }
}
