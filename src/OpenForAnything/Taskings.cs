using ResturantBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenForAnything
{
    public class FindTableTasking : Tasking
    {
        public FindTableTasking() : base("find a table")
        {
        }

        public override bool DoTask()
        {
            return true;
        }
    }
}
