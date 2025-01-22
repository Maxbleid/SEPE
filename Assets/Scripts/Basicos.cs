using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
//using System.Linq;

public class Basicos : MonoBehaviour
{
    
    int numero1 = 4, numero2 = 17, numero3 = 36;
    [SerializeField] private float numerofl1 = 1.3f;
    [SerializeField] private float numerofl2 = 4.5f;
    [SerializeField] private float radio = 2.64f;

    [SerializeField] private int[] listaPesos = { 80, 65, 32, 120 };
    [SerializeField] private int[] lista1 = { 20, 35, 42, 120 };
    [SerializeField] private int[] listaordenadav2 = { 1, 2, 3, 4 };
    [SerializeField] private int[] lista2 = { 20, 55, 25, 10 };
    [SerializeField] private int numeroIntervalo = 0;

    //Excepcion
    [SerializeField] private int limiteTablaMultiplicar;
    [SerializeField] private int numeroParaMultiplicar;
    [SerializeField] private float numeroCuadrado;
    
    [SerializeField] private bool[]arrayBooleanos;
    [SerializeField] private string fraseVocales;
    [SerializeField] private int[] listaPromedio;
    [SerializeField] private float[] arrayFloats;
    [SerializeField] private float[] arrayMaxMin;
    private void Awake()
    {
        Exception7();
        //Exception6();
        //Exception5();
        //Exception4();
        //Exception3();
        //Exception2();
        //Exception1();


        // Interpolacion6();
        //For6();
        //While6();
        //
        //int numeroDia=2; Switch1(numeroDia);

        //int poligono = 5; Switch2(poligono);

        //DiaSemana diaSemana = DiaSemana.Martes;
        //Debug.Log ($"El {diaSemana} es dia {Switch3(diaSemana)}");
        //Varios1();

        //Varios2();

        //Varios3();
        //int numMultiplo = 27;
        //EsMultiploDeTres(numMultiplo);

        //Varios4();

        //Varios5();
        //VariablesEditables1();
        //VariablesEditables2();
        //VariablesEditables3();
        //VariablesEditables4();
        //Arrays1();
        //Arrays2();
        //Arrays4();
        //Arrays5();

        //int a = 6;
        //int b = a;
        //b += 1;
        //Debug.Log(a);
        //Debug.Log(b);


    }

    private void Exception7()
    {
        if (arrayMaxMin.Length == 0)
        {
            throw new Exception("ERROR: ARRAY VACÍO");
        }
        Array.Sort(arrayMaxMin);

        Debug.Log($"Dado el array:[ {string.Join(",", arrayMaxMin)}], el valor máximo " +
            $"es {arrayMaxMin[arrayMaxMin.Length - 1]} y el valor mínimo es {arrayMaxMin[0]}");
    }

    private void Exception6()
    {
        if (arrayFloats.Length == 0)
        {
            throw new Exception("ERROR:ARRAY VACIO");
        }
        int contadorPositivos = 0;
        int contadorNulos = 0;
        int contadorNegativos = 0;

        for (int i = 0; i < arrayFloats.Length; i++)
        {
            if (arrayFloats[i] == 0)
            {
                contadorNulos++;
            }
            else if (arrayFloats[i] > 0)
            {
                contadorPositivos++;
            }
            else
            {
                contadorNegativos++;
            }
        }

        Debug.Log($"Dado el array [{string.Join(",", arrayFloats)}], contiene {contadorNegativos} números negativos" +
            $", {contadorNulos} números nulos y {contadorPositivos} números positivos");
    }

    private void Exception5()
    {
        if (listaPromedio.Length == 0)
        {
            throw new Exception("ERROR: ARRAY VACIO");
        }
        int sumaListaPromedios = 0;
        for (int i = 0; i < listaPromedio.Length; i++)
        {
            sumaListaPromedios += listaPromedio[i];
        }
        
        Debug.Log($"Dada el array: [{string.Join(",",listaPromedio)}], el promedio es { (float)sumaListaPromedios / listaPromedio.Length}");
    }

    private void Exception4()
    {
        if (fraseVocales == null|| fraseVocales.Length==0)
            throw new Exception("ERROR:FRASE NO VALIDA");
        int contadorVocales = 0;
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' }; // puede tambien ser un string 'aeiou' ya que tratara cada vocal como character en el foreach
        foreach (char c in fraseVocales.ToLower()) //tolower = cambia a minusculas
        {
            if (vocales.Contains(c))
            {
                contadorVocales++;
            }
        }
        Debug.Log($"La frase tienes {contadorVocales} vocales");
    }

    private void Exception3()
    {
        int contadortrue = 0;
        int contadorfalse = 0;
        if (arrayBooleanos.Length == 0)
            throw new Exception("ERROR:ARRAY VACIO");
        for (int i = 0; i < arrayBooleanos.Length; i++)
        {
            if (arrayBooleanos[i] == true)
            {
                contadortrue++;
            }
            else if (arrayBooleanos[i] == false)
            {
                contadorfalse++;
            }
        }
        Debug.Log($"El arrayBooleanos tiene {contadortrue} trues y {contadorfalse} falses");

        //otra forma
        // usando la libreria Linq, en donde se crea una variable en la que se guardar los que son true
        // y otra que guarde los que son false
        // luego True.count() para tener el numero de trues y False.count para tener el numero de false
    }

    private void Exception2()
    {
        if (numeroCuadrado <= 0 )
            throw new Exception("ERROR:NÚMERO NO VALIDO");
      
        Debug.Log($"{numeroCuadrado} ^2 = {Mathf.Pow(numeroCuadrado,2)}");
        
    }
    private void Exception1()
    {
        if (numeroParaMultiplicar <= 0 || numeroParaMultiplicar > limiteTablaMultiplicar)
            throw new Exception("ERROR:NÚMERO NO VALIDO");
        for (int i = 1; i <= limiteTablaMultiplicar; i++)
        {
            Debug.Log($"{numeroParaMultiplicar} * {i} = {numeroParaMultiplicar * i}");
        }
    }

    private void Arrays2()
    {
        for (int i = 1; i < lista1.Length - 1; i++)
        {
            if (numeroIntervalo == lista1[i])
            {
                Debug.Log($"{numeroIntervalo} Si esta dentro del intervalo");
            }
            else
            {
                Debug.Log($"{numeroIntervalo} NO esta dentro del intervalo");
            }
        }
    }

    private void Arrays5()
    {
        float sumalista = 0f;
        for (int i = 0; i < listaPesos.Length; i++)
        {
            sumalista += listaPesos[i];
        }
        Debug.Log($"La suma de los numeros de la lista es {sumalista}");
    }

    private void Arrays4()
    {
        Array.Copy(lista1, listaordenadav2, listaordenadav2.Length);
        //listaordenadav2 = lista1;
        Array.Sort(listaordenadav2);

        for (int i = 0; i < listaordenadav2.Length ;i++)
        {
            if (listaordenadav2[i] != lista1[i])
            {
                Debug.Log($"lista1 NO estaba ordenada de menor a mayor");
                break;
            }
            else if (i == listaordenadav2.Length-1)
            {
                Debug.Log($"lista1 SI estaba ordenada de menor a mayor");
            }
        }
    }

    private void Arrays1()
    {
        int menor60 = 0;
        int entre60y80 = 0;
        int mayor80 = 0;

        for (int i = 0; i < listaPesos.Length; i++)
        {
            if (listaPesos[i] < 60)
            {
                menor60++;
            }
            else if (listaPesos[i] >= 60 && listaPesos[i] <= 80)
            {
                entre60y80++;
            }
            else
            {
                mayor80++;
            }

        }
        Debug.Log($"Hay {menor60} personas con menos de 60kg, {entre60y80} personas entre 60 y 80kg y {mayor80} personas con mas de 80kg");
    }

    private void VariablesEditables4()
    {
        if (Mathf.Approximately(numerofl1, numerofl2) == true)
        {
            Debug.Log($"Dados los numeros {numerofl1} y {numerofl2}, {numerofl1} = {numerofl2}");
        }
        else if (Mathf.Max(numerofl1,numerofl2) == numerofl1)
        {
            Debug.Log($"Dados los numeros {numerofl1} y {numerofl2}, el numero {numerofl1} > {numerofl2}");
        }
        else
        {
            Debug.Log($"Dados los numeros {numerofl1} y {numerofl2}, el numero {numerofl1} < {numerofl2}");
        }
    }

    private void VariablesEditables3()
    {
        Debug.Log($"Dado el radio {radio}, el perimetro del círculo es " +
            $"{CalculoPerimetro(radio)} y su area es {CalculoArea(radio)}");
    }

    private float CalculoPerimetro(float radio)
    {
        return 2 * Mathf.PI * radio;
    }

    private float CalculoArea(float radio)
    {
        return Mathf.PI * Mathf.Pow(radio, 2);
    }
    private void VariablesEditables2()
    {
        Debug.Log($"el cuadrado de {numerofl1} es {Mathf.Pow(numerofl1, 2)} y el cubo de {numerofl2} es {Mathf.Pow(numerofl2, 3)}");
    }

    private void VariablesEditables1()
    {
        float numforfloatinit = 0;
        float numforfloatfin = 0;

        if (numerofl1 < numerofl2)
        {
            numforfloatinit = numerofl1;
            numforfloatfin = numerofl2;         
        }
        else
        {
            numforfloatinit = numerofl2;
            numforfloatfin = numerofl1;
        }
        for (float i = numforfloatinit + 0.1f; i < numforfloatfin; i += 0.1f)
        {
            Debug.Log($"{i} esta entre {numforfloatinit} y {numforfloatfin}");
        }
    }

    private void Varios5()
    {
        int numforinit = 0;
        int numforfin = 0;

        if (numero2 < numero1)
        {
            numforinit = numero2;
            numforfin = numero1;
        }
        else
        {
            numforinit = numero1;
            numforfin = numero2;
        }
        for (int i = numforinit+1; i < numforfin; i++)
        {
            Debug.Log($"{i} esta entre {numforinit} y {numforfin}");
        }

    }
    private void Varios4()
    {
        int contador = 0;
        for (int i = 1; i <= numero3; i++)
        {
            
            if (EsMultiploDeTres(i))
            {
                //Debug.Log($"{i} es multiplo de 3");
                contador++;
            }
        }
        Debug.Log($"Existen {contador} multiplos de 3");
    }

    private bool EsMultiploDeTres(int numMultiplo)
    {
        return (numMultiplo % 3 == 0);
    }

    private void Varios3()
    {
        for (int i = 1; i <= numero1; i++)
        {
            Debug.Log($"Los numeros hasta {numero1} son: {i}");
        }
    }

    private void Varios2()
    {
        int suma = 0;
        for (int i = numero2 - 1; i > 0; i--)
        {            
            suma += i;
        }
        Debug.Log($"La suma de los numeros positivos que anteceden a {numero2}  es {suma}");
    }

    private void Varios1()
    {
        Debug.Log($"El valor de numero1 es {numero1} y el valor de numero2 es {numero2}");
        int intercambio = numero1;
        numero1 = numero2;
        numero2 = intercambio;
        Debug.Log($"El valor de numero1 es {numero1} y el valor de numero2 es {numero2}");
    }

    public enum DiaSemana
    {
        Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
    }

    private int  Switch3 (DiaSemana diaSemana)
    {
        switch (diaSemana)
        {
            case DiaSemana.Lunes:
                return 1;
            case DiaSemana.Martes:
                return 2;
            case DiaSemana.Miercoles:
                return 3;
            case DiaSemana.Jueves:
                return 4;
            case DiaSemana.Viernes:
                return 5;
            case DiaSemana.Sabado:
                return 6;
            default:
                return 7;
        }
    }
    private string Switch2 (int poligono)
    {
       
        switch (poligono)
        {
            case 3:
                Debug.Log($"El poligono de {poligono} lados es un triangulo");
                break;
            case 4:
                Debug.Log($"El poligono de {poligono} lados es un cuadrado");
                break;
            case 5:
                Debug.Log($"El poligono de {poligono} lados es un pentagono");
                break;
            case 6:
                Debug.Log($"El poligono de {poligono} lados es un hexagono");
                break;
        }
        return "ERROR";
    }
    private void Interpolacion6()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (EsPar(i))
            {
                Debug.Log($"{i} es numero Par");
            }
        }
    }

    private void For6() 
    {
        for (int i = 1; i < 100; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Debug.Log($"{i} SÍ es multiplo de 3 y 2");
            }
            //else
            //{
            //    Debug.Log($"{i} NO es mutiplo de 3 y 2");
            //}
        }
    }

    private void While6()
    {
        int i = 1;
        while (i<100)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Debug.Log($"{i} SÍ es multiplo de 3 y 2");
            }
            //else
            //{
            //    Debug.Log($"{i} NO es mutiplo de 3 y 2");
            //}
            i++;
        }
    }

    private void Switch1(int numeroDia)
    {
        switch(numeroDia){
            case 1:
                Debug.Log($"El dia {numeroDia} es Lunes");
                break;
            case 2:
                Debug.Log($"El dia {numeroDia} es Martes");
                break;
            case 3:
                Debug.Log($"El dia {numeroDia} es Miercoles");
                break;
            case 4:
                Debug.Log($"El dia {numeroDia} es Jueves");
                break;
            case 5:
                Debug.Log($"El dia {numeroDia} es Viernes");
                break;
            case 6:
                Debug.Log($"El dia {numeroDia} es Sabado");
                break;
            case 7:
                Debug.Log($"El dia {numeroDia} es Domingo");
                break;
        }
    }
    public bool EsPar (int num)
    { 
        return (num % 2== 0); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
