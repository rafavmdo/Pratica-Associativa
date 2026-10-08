public class Cliente
{
    private string _nome = "";
    private string _cpf = "";

    public string Nome
    {
        get
        {
            return _nome;
        }

        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException
                (
                    "O nome do aluno não pode ficar vazio."
                );
            }

            _nome = value.Trim();
        }
    }


    public string Cpf
    {
        get
        {
            return _cpf;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException
                (
                    "O cpf não pode ficar vazia."
                );
            }

            _cpf = value.Trim();
        }
    }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Aluno: {Nome}");
        Console.WriteLine($"Cpf: {Cpf}");
    }





}