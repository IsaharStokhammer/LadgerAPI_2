using LadgerAPI_2.Models;

namespace LadgerAPI_2.Dtos
{
    public class AddTransaction
    {
        public string Name { get; set; }
        public Ladger Ladger { get; set; }
    }
}
