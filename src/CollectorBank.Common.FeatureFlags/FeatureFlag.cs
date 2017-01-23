namespace CollectorBank.Common.FeatureFlags
{
    public abstract class FeatureFlag<T>
    {
        public abstract string Keyname { get; }
    }
}