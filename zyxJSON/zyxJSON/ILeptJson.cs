using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zyxJSON
{
    public struct lept_value
    {
        LeptType leptType;
    }

    public interface LeptJSON
    {
        

        int lept_parse(lept_value v, string json);

        LeptType lept_get_type(lept_value v);
    }
}
