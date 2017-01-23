namespace CollectorBank.Common.FeatureFlags
{
    public interface IFeatureFlagProvider
    {
        bool IsFeatureEnabled<T>(bool defaultValue = false) where T : FeatureFlag<bool>, new();

        bool GetBoolFlag<T>(bool defaultValue = false) where T : FeatureFlag<bool>, new();

        int GetIntFlag<T>(int defaultValue) where T : FeatureFlag<int>, new();

        string GetStringFlag<T>(string defaultValue) where T : FeatureFlag<string>, new();
    }
}
