using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERMANAGEMENT
{
    static public class QueueOF
    {
       public static List<ORDER>Queue=new List<ORDER>();
       public static string conn= @"Data Source=.\SQLExpress;Initial Catalog=Erestaurant;Integrated Security=True";
    }
}
