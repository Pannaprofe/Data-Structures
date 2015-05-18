using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public abstract class Creator
    {
        protected List<int> inputList;
        abstract public void BuildCollection(List<int> inputList);
    }
}
