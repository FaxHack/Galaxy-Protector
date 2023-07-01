using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet.Emit;
using System.Collections.Generic;

namespace GalaxyProtector.ProtectionNeeds
{
    public class Block
    {
        public Block()
        {
            Instructions = new List<Instruction>();
        }

        public List<Instruction> Instructions { get; set; }

        public int Number { get; set; }
    }
}
