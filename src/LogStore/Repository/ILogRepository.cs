using System;

namespace LogStore.Repository
{
    public interface ILogRepository
    {
        void Log(string entry);
    }
}