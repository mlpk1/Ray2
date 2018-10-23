﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ray2.Storage
{
    public interface IStorageSharding
    {
        Task<string> GetProvider(string name, StorageType type, string stateKey);
        Task<List<string>> GetProviderList(string name, StorageType type);
        Task<EventStorageInfo> GetTable(string name, StorageType type, string stateKey);
        Task<List<EventStorageInfo>> GetTableList(string name, StorageType type, long? createTime);
        Task<List<EventStorageInfo>> GetTableList(string name, StorageType type, string stateKey, long? createTime);
    }
}
