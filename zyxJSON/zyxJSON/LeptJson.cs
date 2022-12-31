using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zyxJSON
{
    public class LeptJson : ILeptJson
    {
        LeptType ILeptJson.lept_get_type(lept_value v)
        {
            throw new NotImplementedException();
        }

        int ILeptJson.lept_parse(lept_value v, string json)
        {
            throw new NotImplementedException();
        }
    }
}
