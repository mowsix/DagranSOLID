namespace Interfaces{
public interface IGeneradorAleatorio
{
    double GenerarNumeroDecimal(double min, double max);
    int GenerarNumeroEntero(int min, int max);
    string SeleccionarElementoAleatorio(string[] opciones);
}
}