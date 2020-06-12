using System;

namespace Laboratorio10
{
    public class CuentaBancaria
    {
        public readonly String _nombre;
        public readonly double _saldo;

        public CuentaBancaria(string nombre = "Jhon", double saldo = 0.0)
        {
            this._nombre = nombre;
            this._saldo = saldo;
        }
    }
}