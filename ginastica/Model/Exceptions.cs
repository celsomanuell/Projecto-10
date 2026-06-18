using System;

namespace ginastica.Model
{
    public class AulaLotadaException : Exception
    {
        public AulaLotadaException(string message) : base(message) { }
    }

    public class PagamentoEmAtrasoException : Exception
    {
        public PagamentoEmAtrasoException(string message) : base(message) { }
    }

    public class SocioNaoEncontradoException : Exception
    {
        public SocioNaoEncontradoException(string message) : base(message) { }
    }

    public class SocioSuspensoException : Exception
    {
        public SocioSuspensoException(string message) : base(message) { }
    }
}
