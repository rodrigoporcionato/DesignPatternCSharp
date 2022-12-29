internal class Program
{
    private static void Main(string[] args)
    {
        ITransporte transporteTerrestre = TransportadoraFactory.CriarTransporte("terrestre");
        transporteTerrestre.Entregar();

        ITransporte transporteAereo = TransportadoraFactory.CriarTransporte("aereo");
        transporteAereo.Entregar();

        ITransporte transporteMaritimo = TransportadoraFactory.CriarTransporte("maritimo");
        transporteMaritimo.Entregar();
    }
}