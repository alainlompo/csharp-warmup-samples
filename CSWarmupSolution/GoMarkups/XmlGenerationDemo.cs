using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoMarkups
{
    class XmlGenerationDemo
    {

        public void DoXmlGenerationDemo()
        {
            List<Publisher> publishers = GetDemoPublishers();
            var publisherXml = new XDocument();
            var rootElement = new XElement("Publishers");
            publisherXml.Add(rootElement);
            foreach (Publisher publisher in publishers)
            {
                var publisherElement = new XElement("Publisher");
                var nameElement = new XElement("Name", publisher.Name);
                publisherElement.Add(nameElement);
                var creationDateElement = new XElement("CreationDate", publisher.CreationDate);
                publisherElement.Add(creationDateElement);
                var contactPhoneElement = new XElement("ContactPhone", publisher.ContactPhone);
                publisherElement.Add(contactPhoneElement);
                rootElement.Add(publisherElement);
            }

            Console.WriteLine(publisherXml.ToString());
            Console.ReadKey();
        }
        public List<Publisher> GetDemoPublishers()
        {
            return AsList(
                Publisher.ToPublisher("Life Lights Publishing", new DateTime(2000,1,1), "06-11-95-69-75"),
                Publisher.ToPublisher("Shinning Dove Publishers", new DateTime(2010,1,1), "06-85-95-11-75"),
                Publisher.ToPublisher("Blue Pear", new DateTime(2005,1,1), "11-85-95-69-75"),
                Publisher.ToPublisher("Highway Publishers", new DateTime(2012,1,1), "06-85-95-10-75")

                );

        }

        public static List<Publisher> AsList(params Publisher[] publishers)
        {
            List<Publisher> result = new List<Publisher>();
            foreach (Publisher p in publishers)
            {
                result.Add(p);
            }
            return result;
        }
    }
}
