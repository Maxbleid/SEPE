using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Dog : AbstractSoundMaker
{
    public override void MakeSound()
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("guau guau");
    }
}

