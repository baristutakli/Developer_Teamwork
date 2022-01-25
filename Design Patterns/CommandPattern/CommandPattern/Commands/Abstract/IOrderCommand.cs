using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands.Abstract
{
    // Command
    // Temel şablondur.
    // Komutların çalıştırması için temel metotu içermektedir.
    interface IOrderCommand
    {
        void Execute();
    }
}
