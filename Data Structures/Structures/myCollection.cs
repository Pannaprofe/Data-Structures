using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Forms
{
    [Serializable]
    public class myCollection
    {
        public List<int> list;
        public Structure structType;

        public myCollection(List<int> lst, Structure structure)
        {
            this.list = lst;
            this.structType = structure;
        }
    }
}
