using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CheckDeviceID.Models;

namespace CheckDeviceID.DataAccess
{
    public class Files
    {

        public DeviceInfores[] getDevice()
        {
            //return new ReadFile<Bank>().Get(@"\banks.json");
            return new ReadFiles<DeviceInfores>().Get(@"\cheakdev.json");
        }

    }
}