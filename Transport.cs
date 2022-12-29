public interface ITransporte
{
    void Entregar();
}

public class TransporteTerrestre : ITransporte
{
    public void Entregar()
    {
        // lógica de entrega terrestre
    }
}

public class TransporteAereo : ITransporte
{
    public void Entregar()
    {
        // lógica de entrega aérea
    }
}

public class TransporteMaritimo : ITransporte
{
    public void Entregar()
    {
        // lógica de entrega marítima
    }
}


public static class TransportadoraFactory
{
    public static ITransporte CriarTransporte(string tipo)
    {
        switch (tipo)
        {
            case "terrestre":
                return new TransporteTerrestre();
            case "aereo":
                return new TransporteAereo();
            case "maritimo":
                return new TransporteMaritimo();
            default:
                throw new ArgumentException("Tipo de transporte inválido");
        }
    }
}
