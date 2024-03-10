namespace Wikipedia.Extensions;


public static class EnumExtensions
{

    /// <summary>
    /// Convierte un enum de banderas en una secuencia de valores de cadena concatenados con |. 
    /// Ejemplo: Valor1|Valor2.
    /// </summary>
    public static string GetConcatValues(this Enum value)
    {
        // Builder.
        var stringBuilder = new StringBuilder();

        foreach (Enum enumValue in Enum.GetValues(value.GetType()))
        {
            // Esta biblioteca sigue una convención donde todos los enums tienen un valor NotSet. No queremos eso en nuestra salida
            if (string.Equals(enumValue.ToString(), "NotSet", StringComparison.OrdinalIgnoreCase))
                continue;

            // Lo mismo que arriba
            if (string.Equals(enumValue.ToString(), "All", StringComparison.OrdinalIgnoreCase))
                continue;

            if (value.HasFlag(enumValue))
                stringBuilder.Append(enumValue.GetStringValue()).Append('|');
        }

        return stringBuilder.ToString().TrimEnd('|');
    }


    /// <summary>
    /// Obtiene el valor de cadena para un valor de enum dado. Esto solo funcionará si asignas el atributo StringValue
    /// a los elementos en tu enum.
    /// </summary>
    public static string GetStringValue(this Enum value)
    {
        // Obtener el tipo.
        var type = value.GetType();

        // Obtener FieldInfo para este tipo.
        var fieldInfo = type.GetField(value.ToString());

        // Obtener los atributos StringValue.
        var attributes = fieldInfo.GetCustomAttributes<StringValueAttribute>(false).ToArray();

        if (attributes.Length == 0)
            throw new InvalidOperationException("No se pudo encontrar el atributo StringValue en " + type.Name);

        // Devuelve el primero si hubo coincidencia.
        return attributes[0].StringValue;
    }


}