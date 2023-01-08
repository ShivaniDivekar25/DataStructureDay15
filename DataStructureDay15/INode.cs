using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureDay15
{
    public class INode      //Creating node class
    {
        public int value;
        public INode left;
        public INode right;

        public INode(int value)         //Creating node constructor
        {
            this.value = value;
            left = right = null;
        }
    }
}
