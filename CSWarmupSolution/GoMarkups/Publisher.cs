using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoMarkups
{
    class Publisher
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string ContactPhone { get; set; }

        public static Publisher ToPublisher(string name, DateTime creationDate, string contactPhone)
        {
            Publisher instance = new Publisher();
            instance.Name = name;
            instance.CreationDate = creationDate;
            instance.ContactPhone = contactPhone;
            return instance;
        }
    }
}
