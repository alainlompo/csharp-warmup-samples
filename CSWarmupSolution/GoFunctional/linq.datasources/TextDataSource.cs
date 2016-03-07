using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional.linq.datasources
{
    /// <summary>
    /// This class implements a custom Text data source to use as a Linq datasource.
    /// </summary>
    public class TextDataSource
    {
        private static TextDataSource emptyTextDataSource;
        private List<String> reservoir;
        private static TextDataSource getEmptyTextDataSource()
        {
            if (emptyTextDataSource == null)
            {
                emptyTextDataSource = new TextDataSource();
                emptyTextDataSource.fromMemory("");
            }
            return emptyTextDataSource;
        }
        public List<String> getReservoir()
        {
            return reservoir;
        }

        public void fromFile(String filePath)
        {
            if (reservoir == null)
            {
                reservoir = new List<string>();
            }
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    String line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        reservoir.Add(line);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void fromMemory(String dataSource)
        {
            if (reservoir == null)
            {
                reservoir = new List<string>();
            }
            if (dataSource.Contains("\n"))
            {
                String[] lines = dataSource.Split(new char[] { '\n' });
                foreach (String line in lines)
                {
                    reservoir.Add(line);
                }
            }
            else
            {
                reservoir.Add(dataSource);
            }
        }

        public TextDataSource Where(Func<TextDataSource, bool> predicate)
        {
            if (predicate(this))
            {
                return this;
            }
            return getEmptyTextDataSource();

        }

        public TResult Select<TResult>(Func<TextDataSource, TResult> selector)
        {
            return selector(this);
        }


    }
}
