using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.EventStore.EntityFramework.Options
{
    public class EventStoreOptions
    {
        public bool UseInMemoryDatabase { get; set; }
        public string ConnectionStringSQL { get; set; }
    }
}
