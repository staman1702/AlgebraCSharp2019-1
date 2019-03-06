using System;

namespace _7_2_8_Faktorijela_ZADACA
{
    [Serializable]
    internal class PrirodanbrojException : Exception
    {
        public PrirodanbrojException( ) : base("Morate unijeti pozitivan broj!!!")
        {
        }

        public PrirodanbrojException(string message) : base(message)
        {
        }
    }

    
}
