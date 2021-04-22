using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pet_Shop_Csharp.Repository;

namespace Pet_Shop_Csharp.FileRepository
{
    public abstract class FileRepository<T> : IRepository<T>
    {
        protected string filePath;
        public List<T> Data { get; } = new List<T>();
        public void Add(T item)
        {
            Data.Add(item);
            Writetofile();
        }
        public void Remove(short ind)
        {
            Data.RemoveAt(ind);
            Writetofile();
        }
        public void Writetofile()
        {
            if (!File.Exists(filePath))
            {
                throw new Exception($"Error: File({filePath}) not found");
            }
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                WriteObj(sw);
            }

        }
        public void ReadFromFile()
        {
            if (!File.Exists(filePath))
            {
                throw new Exception($"Error: File({filePath}) not found");
            }
            List<String> filelines = new List<string>();
            string Line;

            StreamReader streamReader = new StreamReader(filePath);

            while ((Line = streamReader.ReadLine()) != null)
            {
                filelines.Add(Line);
            }
            streamReader.Close();
            ConvertToObject(filelines);
        }

        protected abstract void ConvertToObject(List<string> strObjItems);
        protected abstract void WriteObj(StreamWriter sw);



    }
}
