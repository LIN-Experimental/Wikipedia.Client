using System.Text.RegularExpressions;

namespace Wikipedia.Extensions;

internal class StringExtensions
{

    /// <summary>
    /// Limpiar el texto.
    /// </summary>
    /// <param name="input">Entrada.</param>
    public static string CleanText(string input)
    {
        // Eliminar etiquetas HTML
        string textoSinEtiquetas = Regex.Replace(input, "<.*?>", string.Empty);

        // Convertir entidades HTML a caracteres legibles
        string textoLimpio = System.Net.WebUtility.HtmlDecode(textoSinEtiquetas);

        return textoLimpio;
    }

}
