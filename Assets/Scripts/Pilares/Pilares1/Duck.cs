using UnityEngine;

public class Duck : ISoundMaker
{
    int numRepetitions = 2;
    //se puede tener varios constructores a la vez
    // creamos un constructor SIN parámetros

    public Duck()
    {
        numRepetitions=2;
    }

   //creamos un constructor con 1 parámetro

    public Duck(int numRepetitions)
    {
        this.numRepetitions = numRepetitions;
    }

    public void MakeSound()
    {
        string texto = "";
        for (int i = 0; i < numRepetitions; i++)
        {
            texto += "Cuac";
        }
            Debug.Log("Parpear: " + texto);
    }
}
