﻿namespace CollectorBank.Common.FeatureFlags
{
    public class DefaultValueFeatureFlagProvider : IFeatureFlagProvider
    {
        public bool IsFeatureEnabled<T>(bool defaultValue = false) where T : FeatureFlag<bool>, new()
        {
            return defaultValue;
        }

        public bool GetBoolFlag<T>(bool defaultValue = false) where T : FeatureFlag<bool>, new()
        {
            return defaultValue;
        }

        public int GetIntFlag<T>(int defaultValue) where T : FeatureFlag<int>, new()
        {
            return defaultValue;
        }

        public string GetStringFlag<T>(string defaultValue) where T : FeatureFlag<string>, new()
        {
            return defaultValue;
        }
    }
}