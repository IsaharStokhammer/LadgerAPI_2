using System.Transactions;

namespace LadgerAPI_2.Models
{
    public class Ladger
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
        

}
