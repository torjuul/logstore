using System.Collections.Generic;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace LogStore.Repository
{
    public class LogRepository : ILogRepository
    {
        private List<string> _entries;
        private static int _count = 0;

        public LogRepository()
        {
            _entries = new List<string>(200);
        }
        public void Log(string entry)
        {
            Store(entry);
        }

        private void Store(string entry)
        {
            _entries.Add(entry);
            _count++;
            if (_count > 100)
                EmitLog();
        }

        private void EmitLog()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare("logs", "fanout");
                foreach (var message in _entries)
                {
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish("logs", "", null, body);
                }
            }

            _count = 0;
            _entries = new List<string>(200);
        }
    }
}