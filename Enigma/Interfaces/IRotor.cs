using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Interfaces
{
    public interface IRotor
    {
        string Name { get; }
        int Position { get; }
        bool IsAtNotch();
        int Forward(int c);
        int Backward(int c);
        void Turnover();



    }
}
