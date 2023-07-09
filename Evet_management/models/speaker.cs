using System.Collections.Generic;

namespace Evet_management.models
{
    class speaker
    {
        public int Id { get; set; }
        public string Speaker_Name { get; set; }
        public string Speaker_Bio { get; set; }
        public int Phone_Number { get; set; }
        public string Email { get; set; }
        public ICollection<Event> Event { get; set; }
    }

}