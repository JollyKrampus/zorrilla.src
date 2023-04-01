using System;

namespace Zorrilla.Admin.Data.Entities
{
    public class CoronavirusDeathRecord
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DeathDate { get; set; }
    }
}