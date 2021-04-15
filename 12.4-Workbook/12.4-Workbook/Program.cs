using System;

namespace _12._4_Workbook
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] problemas = { 
                "Problema 1. Media de números.",
                "Problema 2. Cuadrado de un número.",
                "Problema 3. ¿Mayor o menor que cero?",
                "Problema 4. Circunferencia y área de un circulo.",
                "Problema 5. Área de un triángulo.",
                "Problema 6. ¿Positivo o negativo?",
                "Problema 7. ¿Par o impar?",
                "Problema 8. Conversor temperatura.",
                "Problema 9. Conversor distancia.",
                "Problema 10. Número de vocales.",
                "Problema 11. Días de la semana.",
                "Problema 12. Números impares.",
                "Problema 13. Números pares.",
                "Problema 14. Números 0-100.",
                "Problema 15. Números 100-0.",
                "Problema 16. Múltiplos de 3.",
                "Problema 17. Múltiplos de 3 y 2.",
                "Problema 18. Suma de predecesores.",
                "Problema 19. Mostrar predecesores.",
                "Problema 20. Multiplos de 3 variable.",
                "Problema 21. Números primos.",
                "Problema 22. Suma de positivos, multiplicar negativos.",
                "Problema 23. Números intercambiados.",
                "Problema 24. Cuadrado y cubo.",
                "Problema 25. Pesados y livianos.",
                "Problema 26. Tipos de triángulos.",
                "Problema 27. Intervalo.",
                "Problema 28. Sueldo.",
                "Problema 29. Tablas de multiplicar.",
                "Problema 30. Números existentes en un rango.",
                "Problema 31. Lluvias.",
                "Problema 32. Mayor/menor.",
                "Problema 33. Nombre/edad.",
                "Problema Avanzado 34: Traductor Morse.",
                "Problema Avanzado 35: Factorizar Números."};
            string[] enunciados =
            {
                "Problema 1.\nSolicitar 5 números por consola y mostrar su media.",
                "Problema 2.\nIngresar un número y mostrar el cuadrado del mismo. El número debe ser mayor que cero, en caso de que no lo sea que aparezca el mensaje " +
                    "\"ERROR. Introducir el número de nuevo\" y se solicite la entrada de nuevo.",
                "Problema 3.\nDe 10 números introducidos por consola indicar cuántos son mayores a cero y cuántos son menores a cero.",
                "Problema 4.\nDiseñar un algoritmo que calcule la longitud de la circunferencia y el área del círculo de radio solicitado por consola.",
                "Problema 5.\nDiseñar un programa que calcule el área de un triángulo a partir de recoger por consola las dimensiones de su base y altura y muestre el resultado.",
                "Problema 6.\nIngresar un número e indicar si es positivo o negativo.",
                "Problema 7.\nMostrar si un número introducido por consola es par o impar.",
                "Problema 8.\nEquivalencia de Grados Celsius con Grados Fahrenheit.",
                "Problema 9.\nEquivalencia de centímetros con pies y pulgadas.",
                "Problema 10.\nPedir por consola una frase y mostrar cuántas vocales tiene.",
                "Problema 11.\nMostrar en pantalla una lista de opciones con los días de la semana. Para elegir uno se debe introducir el número correspondiente. " +
                    "Una vez se ha introducido un número mostrar la opción elegida.",
                "Problema 12.\nMostrar los números impares entre el 0 y el 100.",
                "Problema 13.\nMostrar los números pares entre el 0 y el 100.",
                "Problema 14.\nMostrar los números del 0 al 100.",
                "Problema 15.\nMostrar los números del 100 al 0.",
                "Problema 16.\nMostrar los múltiplos de 3 del 0 al 100.",
                "Problema 17.\nMostrar los múltiplos de 3 y de 2 entre el 0 y 100.",
                "Problema 18.\nIngresar un número y mostrar la suma de los números que lo anteceden. Por ejemplo si se introduce un 6 el resultado es 5 + 4 + 3 + 2 + 1 = 15.",
                "Problema 19.\nMostrar los números del 1 hasta el número ingresado.",
                "Problema 20.\nContar los múltiplos de 3 desde 1 hasta un número que ingresamos.",
                "Problema 21.\nMostrar los números primos entre el 0 y 100.",
                "Problema 22.\nIngresar 10 números sumar los positivos y multiplicar los negativos.",
                "Problema 23.\nIngresar dos números e intercambiarlos. Por ejemplo si introducimos 7 y 14, mostrar 14 y 7.",
                "Problema 24.\nIngresar un número y mostrar su cuadrado y cubo.",
                "Problema 25.\nIntroducir por consola el peso de 5 personas y mostrar la cantidad de personas que pesan más de 80 kg y menos de 80 kg.",
                "Problema 26.\nIngresar la longitud de los 3 lados de un triángulo y decir qué clase de triángulo es. Para formar un triángulo hay que " +
                    "tener en cuenta que la suma de la longitud de sus dos lados más cortos debe ser mayor que la longitud de su lado más largo.",
                "Problema 27.\nDados 3 números donde el primero y el último son límites de un intervalo, indicar si el tercero pertenece a dicho intervalo.",
                "Problema 28.\nPor teclado se ingresa el valor hora de un empleado. Posteriormente se ingresa el nombre del empleado, la antigüedad en años " +
                    "y la cantidad de horas trabajadas en el mes. Se pide calcular el importe a cobrar teniendo en cuenta que al total que resulta de " +
                    "multiplicar el valor hora por la cantidad de horas trabajadas, hay que sumarle la cantidad de años trabajados multiplicados por 30,00 €, " +
                    "y al total de todas esas operaciones restarle el 13% en concepto de retenciones. Imprimir el recibo correspondiente con el nombre, " +
                    "la antigüedad, el valor hora, el total a cobrar en bruto, el total de retenciones y el valor neto a cobrar.",
                "Problema 29.\nRealizar la tabla de multiplicar de un número entre 0 y 10 de forma que se visualice de la siguiente forma: 4x1=4.",
                "Problema 30.\nSolicitar 2 números por consola, imprimir los números naturales que hay entre ambos empezando por el más pequeño, " +
                    "contar cuántos números hay y cuántos de ellos son pares.",
                "Problema 31.\nSe ingresa por teclado la cantidad de agua caída, en milímetros día a día durante un mes. " +
                    "Se pide determinar el día de mayor lluvia, el de menor y el promedio.",
                "Problema 32.\nHacer el algoritmo que imprima el mayor y el menor de una serie de 5 números que vamos introduciendo por teclado.",
                "Problema 33.\nCrear un problema que solicite por consola el nombre de una persona seguido de una coma y su edad. Por ejemplo  Felipe, 43.",
                "Problema Avanzado 34.\nTraductor Morse.",
                "Problema Avanzado 35.\nFactorizar Números."
            };
            string exit = "";
            while ("".Equals(exit))
            {
                int opcion = -1;
                string continuar = "N";
                while (continuar != "S")
                {
                    Console.Clear();
                    Console.WriteLine("Listado de problemas.");
                    for (int i = 0; i < problemas.Length; i++)
                    {
                        Console.WriteLine(problemas[i]);
                    }
                    Console.WriteLine("\n--Para seleccionar introduzca el número del problema" +
                        " (pulse Enter para salir del programa)--.");
                    try
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        opcion = -1;
                    }
                    if(opcion >= 0 & opcion < 36)
                    {
                        Console.WriteLine(enunciados[opcion - 1]);
                        Console.WriteLine("\n¿Desea continuar con este problema? S/N");
                        continuar = Console.ReadLine().ToUpper();
                    }
                    else
                    {
                        continuar = "S";
                        exit = "SALIDA";
                    }
                }
                switch (opcion)
                {
                    case 1:
                        CalculoMedia();
                        break;
                    case 2:
                        CalculoCuadrado();
                        break;
                    case 3:
                        MayorMenorCero();
                        break;
                    case 4:
                        CircunAreaCirculo();
                        break;
                    case 5:
                        AreaTriangulo();
                        break;
                    case 6:
                        PositivoNegativo();
                        break;
                    case 7:
                        ParImpar();
                        break;
                    case 8:
                        ConversorTemperatura();
                        break;
                    case 9:
                        ConversorDistancia();
                        break;
                    case 10:
                        NumeroVocales();
                        break;
                    case 11:
                        DiasSemana();
                        break;
                    case 12:
                        NumerosImpares();
                        break;
                    case 13:
                        NumerosPares();
                        break;
                    case 14:
                        NumerosCeroCien();
                        break;
                    case 15:
                        NumerosCienCero();
                        break;
                    case 16:
                        MultiplosTres();
                        break;
                    case 17:
                        MultiplosTresYDos();
                        break;
                    case 18:
                        SumaPredecesores();
                        break;
                    case 19:
                        MostrarPredecesores();
                        break;
                    case 20:
                        MultiplosTresVariable();
                        break;
                    case 21:
                        NumerosPrimos();
                        break;
                    case 22:
                        SumaPositivosMultiploNegativos();
                        break;
                    case 23:
                        NumerosIntercambiados();
                        break;
                    case 24:
                        CuadradoCubo();
                        break;
                    case 25:
                        PesadosLivianos();
                        break;
                    case 26:
                        TiposTriangulos();
                        break;
                    case 27:
                        Intervalo();
                        break;
                    case 28:
                        Sueldo();
                        break;
                    case 29:
                        TablasMultiplicar();
                        break;
                    case 30:
                        NumerosExistentes();
                        break;
                    case 31:
                        Lluvias();
                        break;
                    case 32:
                        MayorMenor();
                        break;
                    case 33:
                        NombreEdad();
                        break;
                    case 34:
                        Morse();
                        break;
                    case 35:
                        Factorizar();
                        break;
                    case -1:
                    default:
                        exit = "SALIDA";
                        break;

                }
                Console.WriteLine("\n\nPulse Enter para continuar.");
                Console.ReadLine();
            }
        }

        static void CalculoMedia()
        {
            double total = 0.0;
            double media = 0.0;
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Introduzca un número para el cálculo de la media.");
                    total = total + Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                }
                media = total / 5;
                Console.WriteLine("La media es " + media);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error. Introduzca un número correcto.");
                Console.WriteLine(e.Message);
            }
        }
        static void CalculoCuadrado()
        {
            bool numValido = false;
            double num = 0.0;
            while (!numValido)
            {
                try
                {
                    Console.WriteLine("Introduzca un número para calcular su cuadrado.");
                    num = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    if (num > 0.0)
                    {
                        numValido = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Introducir el número de nuevo\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR. Introducir el número de nuevo");
                    Console.WriteLine(e.Message + "\n");
                }
            }
            Console.WriteLine("El resultado de " + num + " al cuadrado es: " + (num * num));
        }
        static void MayorMenorCero()
        {
            int mayores = 0;
            int menores = 0;
            double num = 0.0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduzca un número");
                num = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                if (num > 0.0)
                {
                    mayores++;
                }
                else if (num < 0.0)
                {
                    menores++;
                }
            }
            Console.WriteLine("Se han introducido " + mayores + " números mayores a cero.");
            Console.WriteLine("Se han introducido " + menores + " números menores a cero.");
        }
        static void CircunAreaCirculo()
        {
            double radio, area, circunferencia = 0.0;
            Console.WriteLine("Introduzca el radio del círculo en cm (solo indique los números).");
            radio = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            if (radio > 0.0)
            {
                area = Math.PI * radio * radio;
                circunferencia = 2 * Math.PI * radio;

                Console.WriteLine("El área del círculo es " + Math.Round(area, 3));
                Console.WriteLine("La circunferencia del círculo es " + Math.Round(circunferencia, 3));
            }
            else
            {
                Console.WriteLine("El radio introducido no es correcto.");
            }
        }
        static void AreaTriangulo()
        {
            double baseTriangulo, altura, area = 0.0;
            Console.WriteLine("Introduzca la base del triángulo.");
            baseTriangulo = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.WriteLine("Introduzca la altura del triángulo.");
            altura = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            if (altura > 0.0 & baseTriangulo > 0.0)
            {
                area = baseTriangulo * altura / 2;
                Console.WriteLine("El area del triángulo es " + Math.Round(area, 3));
            }
            else
            {
                Console.WriteLine("Los datos introducidos no son correcto.");
            }
        }
        static void PositivoNegativo()
        {
            Console.WriteLine("Introduzca un número.");
            double num = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            if (num < 0.0)
            {
                Console.WriteLine("El número " + num + " es negativo.");
            }
            else
            {
                Console.WriteLine("El número " + num + " es positivo.");
            }
        }
        static void ParImpar()
        {
            Console.WriteLine("Introduzca un número.");
            double num = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            if (num % 2 == 0)
            {
                Console.WriteLine("El número " + num + " es par.");
            }
            else
            {
                Console.WriteLine("El número " + num + " es impar.");
            }
        }
        static void ConversorTemperatura()
        {
            Console.WriteLine("Introduzca la temperatura (en grados celsius).");
            double celsius = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            double farenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("La temperatura de " + celsius +
                " grados celsius, equivale a " + farenheit + " grados farenheit.");
        }
        static void ConversorDistancia()
        {
            Console.WriteLine("Introduzca la distancia (en cm).");
            double cm = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            double pies = cm / 30.48;
            double pulgadas = cm / 2.54;

            Console.WriteLine("La distancia de " + cm +
                " cm, equivale a " + Math.Round(pies, 5) + " pies.");
            Console.WriteLine("La distancia de " + cm +
                " cm, equivale a " + Math.Round(pulgadas, 5) + " pulgadas.");
        }
        static void NumeroVocales()
        {
            Console.WriteLine("Introduzca una frase.");
            string texto = Console.ReadLine().ToUpper();
            int vocales = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if ('A'.Equals(texto[i]) | 'E'.Equals(texto[i]) |
                    'I'.Equals(texto[i]) | 'O'.Equals(texto[i]) | 'U'.Equals(texto[i]))
                {
                    vocales++;
                }
            }

            Console.WriteLine("La frase contiene " + vocales + " vocales.");
        }
        static void DiasSemana()
        {
            string[] dias = {"Lunes", "Martes", "Miercoles",
                "Jueves", "Viernes", "Sábado", "Domingo" };
            Console.WriteLine("El listado de días es el siguiente:");
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(dias[i] + " --> Opción " + (i + 1));
            }
            Console.WriteLine("\nIntroduce la opción elegida (opción numérica). \n");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El día seleccionado es " + dias[opcion - 1]);
        }
        static void NumerosImpares()
        {
            Console.WriteLine("Mostrar los números " +
                "impares que existen del 0 a 100.");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void NumerosPares()
        {
            Console.WriteLine("Mostrar los números " +
                "impares que existen del 0 a 100.");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void NumerosCeroCien()
        {
            Console.WriteLine("Mostrar los números " +
                "que existen del 0 a 100.");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void NumerosCienCero()
        {
            Console.WriteLine("Mostrar los números " +
                "que existen del 100 a 0.");
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void MultiplosTres()
        {
            Console.WriteLine("Mostrar los números divisibles " +
               "entre 3 que existen del 0 a 100.");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void MultiplosTresYDos()
        {
            Console.WriteLine("Mostrar los números divisibles " +
                "entre 3 o 2 que existen del 0 a 100.");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 | i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void SumaPredecesores()
        {
            Console.WriteLine("Introduzca un número.");
            int num = Convert.ToInt32(Console.ReadLine());
            int output = 0;
            for (int i = num - 1; i > 0; i--)
            {
                output = output + i;
            }
            Console.WriteLine("El número calculado es " + output);
        }
        static void MostrarPredecesores()
        {
            Console.WriteLine("Introduzca un número.");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void MultiplosTresVariable()
        {
            Console.WriteLine("Introduzca un número.");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void NumerosPrimos()
        {
            for (int i = 0; i <= 100; i++)
            {
                bool esPrimo = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void SumaPositivosMultiploNegativos()
        {
            double num = 0.0;
            double negativos = 1.0;
            double positivos = 0.0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduzca un número (negativo o positivo).");
                num = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                if (num < 0.0)
                {
                    negativos = negativos * num;
                }
                else
                {
                    positivos = positivos + num;
                }
            }
            Console.WriteLine("La suma de números es " + positivos);
            Console.WriteLine("La resta de números es " + negativos);
        }
        static void NumerosIntercambiados()
        {
            double num1, num2, aux = 0.0;

            Console.WriteLine("Introduzca un número.");
            num1 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            Console.WriteLine("Introduzca un número.");
            num2 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            aux = num2;
            num2 = num1;
            num1 = aux;

            Console.WriteLine("Los números introducidos son " + num1 + " y " + num2);
        }
        static void CuadradoCubo()
        {
            double num, cuadrado, cubo = 0.0;

            Console.WriteLine("Introduzca un número.");
            num = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);

            Console.WriteLine("El número introducido es " + num +
                ", su cuadrado es " + cuadrado + " y su cubo es " + cubo + ".");
        }
        static void PesadosLivianos()
        {
            int mayor = 0;
            int menor = 0;
            double peso = 0.0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduzca el peso en kilogramos.");
                peso = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                if (peso > 80)
                {
                    mayor++;
                }
                else if (peso < 80)
                {
                    menor++;
                }
            }
            Console.WriteLine("Hay " + mayor + " personas que pesan más de 80kg.");
            Console.WriteLine("Hay " + menor + " personas que pesan menos de 80kg.");
        }
        static void TiposTriangulos()
        {
            double[] lados = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduzca la longitud del lado " + (i + 1) + " del triángulo.");
                lados[i] = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            }

            //Los tres lados iguales --> equilatero
            if (lados[0] == lados[1] && lados[1] == lados[2])
            {
                Console.WriteLine("Se trata de un triángulo equilátero.");
            }
            else
            {
                //Ordenamos de menor a mayos dentro del array
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 2 - i; j++)
                    {
                        if (lados[j] > lados[j + 1])
                        {
                            double aux;
                            aux = lados[j];
                            lados[j] = lados[j + 1];
                            lados[j + 1] = aux;
                        }
                    }
                }

                if (lados[0] + lados[1] < lados[2])
                {
                    Console.WriteLine("La suma de los dos lados más cortos (" + lados[0] +
                        " y " + lados[1] + ") es menor que el lado mas largo (" + lados[2] +
                        "). Las dimensiones no son correctas.");
                }
                //Comprobamos que dos lados cualesquiera, son iguales, triangulo isosceles
                else if (lados[0] == lados[1] | lados[0] == lados[2] | lados[1] == lados[2])
                {
                    Console.WriteLine("Se trata de un triángulo isósceles.");
                }
                //Si no es ninguno de los anteriores, es un triangulo escaleno.
                else
                {
                    Console.WriteLine("Se trata de un triángulo escaleno.");
                }
            }
        }
        static void Intervalo()
        {
            double[] nums = new double[3];
            Console.WriteLine("Introduzca el primer número del intervalo.");
            nums[0] = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            Console.WriteLine("Introduzca el número a comprobar.");
            nums[1] = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            Console.WriteLine("Introduzca el segundo número del intervalo.");
            nums[2] = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            if (nums[0] < nums[1] & nums[1] < nums[2])
            {
                Console.WriteLine("El número se encuentra dentro del intervalo.");
            }
            else if (nums[0] > nums[1] & nums[1] > nums[2])
            {
                Console.WriteLine("El número se encuentra dentro del intervalo.");
            }
            else
            {
                Console.WriteLine("El número NO se encuentra dentro del intervalo.");
            }
        }
        static void Sueldo()
        {
            Empleado empleado = new Empleado();
            //Tomamos los datos del empleado por consola
            TomaDeDatos(empleado);
            //Calculamos el sueldo bruto, retenciones y sueldo neto
            empleado.SueldoBruto = (empleado.ValorHora * empleado.HorasTrabajadas) + (empleado.Antiguedad * 30);
            empleado.Retenciones = empleado.SueldoBruto * 0.13;
            empleado.SueldoNeto = empleado.SueldoBruto - empleado.Retenciones;
            //Imprimimos el recibo.
            ImprimirRecibo(empleado);
        }
        static void TomaDeDatos(Empleado empleado)
        {
            Console.WriteLine("Introduzca el valor/hora del empleado.");
            empleado.ValorHora = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.WriteLine("Introduzca el nombre del empleado.");
            empleado.Nombre = Console.ReadLine();
            Console.WriteLine("Introduzca la antigüedad del empleado (en años).");
            empleado.Antiguedad = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.WriteLine("Introduzca la cantidad de horas trabajadas por el empleado.");
            empleado.HorasTrabajadas = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
        }
        static void ImprimirRecibo(Empleado empleado)
        {
            Console.WriteLine("\nRecibo del empleado " + empleado.Nombre);
            Console.WriteLine("Antigüedad del empleado: " + empleado.Antiguedad);
            Console.WriteLine("Valor/hora del empleado: " + empleado.ValorHora);
            Console.WriteLine("Sueldo bruto del empleado: " + empleado.SueldoBruto);
            Console.WriteLine("Retenciones del empleado: " + empleado.Retenciones);
            Console.WriteLine("Sueldo Neto del empleado: " + empleado.SueldoNeto);
        }
        static void TablasMultiplicar()
        {
            Console.WriteLine("Introduzca un número entre el 1 y el 10");
            int num = Convert.ToInt32(Console.ReadLine());

            if (1 <= num && num <= 10)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num + "x" + i + "=" + (num * i));
                }
            }
            else
            {
                Console.WriteLine("Número no válido.");
            }
        }
        static void NumerosExistentes()
        {
            Console.WriteLine("Introduzca el primer número");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int numeros = 0;
            int pares = 0;
            int mayor, menor = 0;

            if (num > num2)
            {
                mayor = num;
                menor = num2;
            }
            else
            {
                mayor = num2;
                menor = num;
            }

            for (int i = menor + 1; i < mayor; i++)
            {
                Console.WriteLine(i);
                numeros++;
                if (i % 2 == 0)
                {
                    pares++;
                }
            }
            Console.WriteLine("Existen un total de " + numeros +
                " entre el " + menor + " y el " + mayor);
            Console.WriteLine("Existen un total de " + pares +
                " números pares entre el " + menor + " y el " + mayor);
        }
        static void Lluvias()
        {
            int[] lluvias = new int[30];
            for (int i = 0; i < lluvias.Length; i++)
            {
                Console.WriteLine("Introduzca las lluvias del día " + (i + 1));
                try
                {
                    lluvias[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    lluvias[i] = 0;
                }
            }
            int diaMayor = 0;
            int diaMenor = 0;
            int menor = lluvias[0];
            int mayor = lluvias[0];
            double medio = 0.0;

            for (int i = 0; i < lluvias.Length; i++)
            {
                medio = medio + lluvias[i];
                if (lluvias[i] > mayor)
                {
                    mayor = lluvias[i];
                    diaMayor = i;
                }
                else if (lluvias[i] < menor)
                {
                    menor = lluvias[i];
                    diaMenor = i;
                }
            }
            medio = medio / lluvias.Length;
            Console.WriteLine("El día que más llovió fue el " + (diaMayor + 1)
                + " con una cantidad de " + mayor + "mm.");
            Console.WriteLine("El día que menos llovió fue el " + (diaMenor + 1)
                + " con una cantidad de " + menor + "mm.");
            Console.WriteLine("La media mensual es de " +
                Math.Round(medio, 3) + "mm.");
        }
        static void MayorMenor()
        {
            double[] nums = new double[5];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Introduzca un número");
                try
                {
                    nums[i] = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                }
                catch (Exception e)
                {
                    nums[i] = 0;
                }
            }

            double menor = nums[0];
            double mayor = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > mayor)
                {
                    mayor = nums[i];
                }
                else if (nums[i] < menor)
                {
                    menor = nums[i];
                }
            }
            Console.WriteLine("El número mayor es el " + mayor);
            Console.WriteLine("El número menor es el " + menor);
        }
        static void NombreEdad()
        {
            Console.WriteLine("¿Cuantos nombres quiere introducir?");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] personas = new string[num];
            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine("Introduzca un nombre y la edad " +
                    "de la persona con el siguiente formato (nombre, edad).");
                personas[i] = Console.ReadLine();
            }

            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine(personas[i].Substring(0,
                    personas[i].IndexOf(',')));
            }

        }
        static void Morse()
        {
            Console.WriteLine("Introduzca la frase a traducir");
            string frase = Console.ReadLine().ToUpper();
            string output = "";

            for (int i = 0; i < frase.Length; i++)
            {
                output = output + TraducirAMorse(frase[i]);
            }

            Console.WriteLine("La frase traducida es :\n" + output);
        }
        static string TraducirAMorse(char c)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R',
                'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2',
                '3', '4', '5', '6', '7', '8', '9', '.', ',', '?', '"',
                '/' };
            string[] morse = {".-", "-...", "-.-.", "-..", ".",
                "..-.", "--.", "....", "..", ".---", "-.-", ".-..",
                "--", "-.", "--.--", "---", ".--.", "--.-", ".-.",
                "...", "-", "..-", "...-", ".--", "-..-", "-.--",
                "--..", "-----", ".----", "..---", "...--", "....-",
                ".....", "-....", "--...", "---..", "----.", ".-.-.-",
                "--..--", "..--..", ".-..-.", "--..-."};

            int indice = -1;
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i].Equals(c))
                {
                    indice = i;
                }
            }
            if (indice != -1)
            {
                return morse[indice] + " ";
            }
            return "";
        }
        static void Factorizar()
        {
            Console.WriteLine("Introduzca el número que desea factorizar.");
            int num = Convert.ToInt32(Console.ReadLine());
            int factor = 2;
            string output = "";
            while (num != 1)
            {
                if (num % factor == 0)
                {
                    output = output + factor;
                    num = num / factor;
                    if (num != 1)
                    {
                        output = output + " * ";
                    }
                }
                else
                {
                    factor++;
                }
            }
            Console.WriteLine(output);
        }
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public double Antiguedad { get; set; }
        public double HorasTrabajadas { get; set; }
        public double ValorHora { get; set; }
        public double SueldoBruto { get; set; }
        public double Retenciones { get; set; }
        public double SueldoNeto { get; set; }
        public Empleado() { }
    }
}
