using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Connectivity;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Model
{
    class NetworkCheck
    {
        public static bool IsInternet()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
