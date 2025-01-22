using UnityEngine;


[RequireComponent (typeof(AudioSource))]
public class Cat : AbstractSoundMaker
{
    public override void MakeSound()
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("miaaauu");
    }
}

