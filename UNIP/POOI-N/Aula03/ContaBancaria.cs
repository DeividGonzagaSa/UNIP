using System.ComponentModel;
using System.Transactions;

namespace Financeiro;

public class ContaBancaria
{
    private string _titular;
    private string _numero;
    private float _saldo = (float) 0.0;
    private int _banco;
    private string _agencia;
    private bool _EstaAtiva;

    public string Titular
    {
        get => _titular;
        set => _titular = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Numero
    {
        get => _numero;
        set => _numero = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float Saldo
    {
        get => _saldo;
        set => _saldo = value;
    }

    public int Banco
    {
        get => _banco;
        set => _banco = value;
    }

    public string Agencia
    {
        get => _agencia;
        set => _agencia = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool EstaAtiva
    {
        get => _EstaAtiva;
        set => _EstaAtiva = value;
    }

    public float sacar(float saque)
    {
        if (this.Saldo >= saque)
        {
            this._saldo -= saque;
            return this.Saldo - saque;
        }
        else
        {
            return this.Saldo;
        }
    }

    public float Depositar(float deposito)
    {
        this._saldo += deposito;
        return this._saldo;
    }
}

/*
 * Fortemesnte tipada
 * Númerico: int (16 bits), long (32 bits), float (4 bytes, 32 bits), double (64 bits), decimal(128 bits), complex (nunca utilizado)
 * Lógico: bool: T or F
 * Caracteres: char (1 caracter), string (cadeia de caracteres)
 */
