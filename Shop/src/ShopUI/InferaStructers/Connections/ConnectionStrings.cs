using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.InferaStructures.Connections;

public class ConnectionStrings
{
    public static string ConnectionString { get; set; }

    static ConnectionStrings()
    {
        ConnectionString = @"Data Source=DESKTOP-URA992G\SQLEXPRESS; Initial Catalog=ShopDb2; Integrated Security=true ;TrustServerCertificate=True;";
    }

}
