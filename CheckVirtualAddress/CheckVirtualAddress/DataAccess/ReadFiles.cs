using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Web.Hosting;

namespace CheckVirtualAddress.DataAccess
{
    public class ReadFiles<T>
    {
        private readonly string mockDataFolder = (HostingEnvironment.MapPath("/") + "MockData").Replace(@"\\", @"\");
        public T[] Get(string fileName)
        {
            string filePath = mockDataFolder + fileName;
            List<T> list = new List<T>();
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return list.ToArray();
        }
    }
}

 



        
