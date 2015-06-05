using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    [Serializable]
    public class CollectionInfo
    {
        public Type type;
        public List<int> list;

        public CollectionInfo(Type type, List<int> list)
        {
            this.type = type;
            this.list = list;
        }
    }
}
