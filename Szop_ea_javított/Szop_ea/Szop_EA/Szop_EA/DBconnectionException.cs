using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szop_EA
{
    class DBconnectionException:Exception
    {
        public DBconnectionException():base("Conncetion to server failed")
        {

        }
    }
}
