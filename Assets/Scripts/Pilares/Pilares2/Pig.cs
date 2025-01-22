using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Pig : AbstractSoundMaker
{
    public override void MakeSound()
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("oink oink");
    }
}

