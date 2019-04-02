using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace InitiateSetMPIN.DataAccess
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