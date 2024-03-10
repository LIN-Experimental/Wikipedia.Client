namespace Wikipedia.Internal;


/// <summary>
/// Este atributo se utiliza para representar un valor de cadena para un valor en un enum.
/// </summary>
/// <remarks>
/// Constructor utilizado para inicializar un atributo StringValue.
/// </remarks>
[AttributeUsage(AttributeTargets.Field)]
internal class StringValueAttribute(string value) : Attribute
{


    /// <summary>
    /// Contiene el valor de cadena para un valor en un enum.
    /// </summary>
    public string StringValue { get; } = value;


}