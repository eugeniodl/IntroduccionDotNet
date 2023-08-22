string[] unidades =
{
    "",
    "Uno",
    "Dos",
    "Tres",
    "Cuatro",
    "Cinco",
    "Seis",
    "Siete",
    "Ocho",
    "Nueve"
};

string[] decenas =
{
    "",
    "Diez",
    "Veinte",
    "Treinta",
    "Cuarenta",
    "Cincuenta",
    "Sesenta",
    "Setenta",
    "Ochenta",
    "Noventa"
};

string[] especiales =
{
    "",
    "Once",
    "Doce",
    "Trece",
    "Catorce",
    "Quince",
    "Dieciséis",
    "Diecisiete",
    "Dieciocho",
    "Diecinueve"
};

string[] centenas =
{
    "",
    "Ciento",
    "Doscientos",
    "Trescientos",
    "Cuatrocientos",
    "Quinientos",
    "Seiscientos",
    "Setecientos",
    "Ochocientos",
    "Novecientos"
};

int numero;
while (true)
{
    Console.Write("Ingrese un número entre 0 y 9999: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if (numero >= 0 && numero <= 9999)
        {
            string numeroEnLetras =
                ConvertirNumeroEnLetras(numero);
            Console.WriteLine($"El número {numero} " +
                $"en letras es: {numeroEnLetras}");
        }
        else
        {
            Console.WriteLine("El número ingresado está " +
                "fuera del rango válido.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. " +
            "Por favor ingrese un número válido");
    }
}

string ConvertirNumeroEnLetras(int numero)
{
    if (numero == 0)
    {
        return "Cero";
    }

    string numeroEnLetras = "";

    // Procesar las unidades de millar
    int unidadesDeMillar = numero / 1000;
    if (unidadesDeMillar > 0)
    {
        if (unidadesDeMillar == 1)
            numeroEnLetras = "Mil ";
        else
            numeroEnLetras += unidades[unidadesDeMillar]
                + " Mil ";
        numero %= 1000;
    }

    // Procesar las centenas
    int parteCentena = numero / 100;
    if (parteCentena > 0)
    {
        if (numero == 100)
            numeroEnLetras = "Cien";
        else
            numeroEnLetras += centenas[parteCentena] + " ";
        numero %= 100;
    }

    // Procesar las decenas y unidades
    if (numero >= 11 && numero <= 19)
    {
        numeroEnLetras += especiales[numero - 10];
    }
    else
    {
        int decena = numero / 10;
        if (decena > 0)
        {
            numeroEnLetras += decenas[decena];
            if (numero % 10 > 0)
            {
                numeroEnLetras += " y "
                    + unidades[numero % 10];
            }
        }
        else if (numero % 10 > 0)
        {
            numeroEnLetras += unidades[numero % 10];
        }
    }

    return numeroEnLetras;
}