using Enigma.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class BaseRotor : IRotor
    {
        private string name;
        protected int rotorPosition;
        protected int notchPosition;
        protected int ringSetting;
        protected int[] forwardWiring;
        protected int[] backwardWiring;

        public string Name
        {
            get { return name; }
        }

        public int Position
        {
            get { return rotorPosition; }
        }


        public virtual bool IsAtNotch()
        {
            return notchPosition == rotorPosition;
        }


        public int Backward(int c)
        {
            return encipher(c, this.rotorPosition, this.ringSetting, this.backwardWiring);
        }

        public int Forward(int c)
        {
            return encipher(c, this.rotorPosition, this.ringSetting, this.forwardWiring);
        }

        public void Turnover()
        {
            throw new NotImplementedException();
        }

        protected int encipher(int c, int rotorPos, int ring, int[] mapping)
        {
            int shift = rotorPos - ring;
            return (mapping[(c + shift + 26) % 26] - shift + 26) % 26;
        }

    }
}
