using Microsoft.Extensions.Logging;

namespace LadgerAPI_2.Models
{

    public class Transaction
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public ICollection <User> PaidBy { get; set; }
            public Ladger Ladger { get; set; }

        }

    }

