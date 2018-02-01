using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class constRO
    {
        public const string constant1 = "konstantnoe pole";
        public static readonly string constant2;

        static constRO()
        {
            constant2 = "readonly variable";
        }
    }
}
