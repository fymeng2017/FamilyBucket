﻿namespace Bucket.Core
{
    public interface IRequestScopedDataRepository
    {
        bool Add<T>(string key, T value);
        bool Update<T>(string key, T value);
        T Get<T>(string key);
    }
}
