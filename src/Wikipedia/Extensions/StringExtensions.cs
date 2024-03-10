using System.Net;
using System.Text.RegularExpressions;

namespace Wikipedia.Extensions;

internal class StringExtensions
{
    /// <summary>
    ///     Limpiar el texto.
    /// </summary>
    /// <param name="input">Entrada.</param>
    public static string CleanText(string input)
    {
        // Eliminar etiquetas HTML
        var textoSinEtiquetas = Regex.Replace(input, "<.*?>", string.Empty);

        // Convertir entidades HTML a caracteres legibles
        var textoLimpio = WebUtility.HtmlDecode(textoSinEtiquetas);

        return textoLimpio;
    }
}