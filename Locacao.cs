public class Locacao
{
    private Cliente _cliente;
    private Veiculo _veiculo;
    private DateOnly _dataRetirada;
    private int _quantidadeDias;
    private decimal _valorDiaria;


    public Cliente Cliente
    {
        get
        {
            return _cliente;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "A locação precisa possuir um cliente."
                );
            }

            _cliente = value;
        }
    }

    public Veiculo Veiculo
    {
        get
        {
            return _veiculo;
        }

        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "A locação precisa possuir um veículo."
                );
            }

            _veiculo = value;
        }
    }

    public DateOnly DataRetirada
    {
        get
        {
            return _dataRetirada;
        }

        private set
        {
            _dataRetirada = value;
        }
    }

    public int QuantidadeDias
    {
        get
        {
            return _quantidadeDias;
        }

        set
        {
            _quantidadeDias = value;
        }
    }

    public decimal ValorDiaria
    {
        get
        {
            return _valorDiaria;
        }

        set
        {
            _valorDiaria = value;
        }
    }

    public Locacao(Cliente cliente, Veiculo veiculo, DateOnly dataRetirada, int quantidadeDias, decimal valorDiaria)
    {
        Cliente = cliente;
        Veiculo = veiculo;
        DataRetirada = dataRetirada;
        QuantidadeDias = quantidadeDias;
        ValorDiaria = valorDiaria;
    }
    
    public double CalcularValorBruto()
    {
        return  (double)ValorDiaria * QuantidadeDias;
    }

    public double CalcularDesconto()
    {
        double valorBruto = CalcularValorBruto();
        double desconto = 0;

        if (QuantidadeDias >= 15)
        {
            desconto = valorBruto * 0.15;
        }
        else if (QuantidadeDias >= 7)
        {
        desconto = valorBruto * 0.10;
        }
        return desconto;
    }

    public double CalcularValorFinal()
    {
        double valorBruto = CalcularValorBruto();
        double desconto = CalcularDesconto();
        return valorBruto - desconto;
    }

    public void ExibirResumo()
    {
        Console.WriteLine("Resumo da Locação:");
        Console.WriteLine($"Cliente: {Cliente.Nome}");
        Console.WriteLine($"CPF: {Cliente.Cpf}");
        Console.WriteLine($"Veículo: {Veiculo.Modelo}");
        Console.WriteLine($"Placa: {Veiculo.Placa}");
        Console.WriteLine($"Data de Retirada: {DataRetirada}");
        Console.WriteLine($"Quantidade de Dias: {QuantidadeDias}");
        Console.WriteLine($"Valor da Diária: R$ {ValorDiaria:F2}");
        Console.WriteLine($"Valor Bruto: R$ {CalcularValorBruto():F2}");
        Console.WriteLine($"Desconto: R$ {CalcularDesconto():F2}");
        Console.WriteLine($"Valor Final: R$ {CalcularValorFinal():F2}");
    }

}