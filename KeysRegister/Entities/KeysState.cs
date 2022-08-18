using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysRegister.Entities
{
    internal class KeysState
    {
        public int KeyId { get; set; }
        public int OutEmployeeId { get; set; }
        public DateTime OutDateTime { get; set; }
    }
}
