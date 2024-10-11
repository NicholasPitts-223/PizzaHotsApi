using System.Security.Cryptography.X509Certificates;

namespace PizzaHotApi.Models;

public class Pizza
{

    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? descrição { get; set; }

    public int Quantidade { get; set; }

}



