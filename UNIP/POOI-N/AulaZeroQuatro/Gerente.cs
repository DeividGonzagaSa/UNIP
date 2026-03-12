public class Gerente : Funcionario
{
    public string Setor {  get; set; }

    public Gerente(string nome, string setor) : base(nome)
    {
        Setor = setor;
    }
}