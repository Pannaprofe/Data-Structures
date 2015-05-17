using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class CreateBinaryTree:Creator
    {
        public override Structure FactoryMethod()
        {
            //throw new NotImplementedException();
            return new MyBinaryTree();
        }
    }
}
