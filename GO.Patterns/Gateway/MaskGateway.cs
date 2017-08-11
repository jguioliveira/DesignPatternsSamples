using GO.Patterns.Strategy;
using System;

namespace GO.Patterns.Gateway
{
    public static class MaskGateway
    {
        public static IMask GetMask(MaskType type)
        {
            switch (type)
            {
                case MaskType.CPF:
                    return new MaskCPF();
                case MaskType.CNPJ:
                    return new MaskCNPJ();
                default:
                    throw new ArgumentException("Invalid type.");
            }
        }
    }

    public enum MaskType
    {
        CPF,
        CNPJ
    }
}
