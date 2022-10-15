using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace csharpmySQL
{
    public static class MySqlConnect
    {
      public static string GetConnectionString()
        {
          
            string myConnectionString = "server=127.0.0.1;uid=root;" +
                "database=SampleDB";
            return myConnectionString; 
        }


    }
}
