using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr2
{
    class XMLHandler : AbstractHandler
    {
        /// <summary>
        /// 
        /// </summary>
        public override void Open()
        {
            Console.WriteLine($"Open document format - xml");
        }
        public override void Create()
        {
            Console.WriteLine($"Creat document format - xml");
        }
        public override void Change()
        {
            Console.WriteLine($"Change document format - xml");
        }
        public override void Save()
        {
            Console.WriteLine($"Save document format - xml");
        }
    }
}
