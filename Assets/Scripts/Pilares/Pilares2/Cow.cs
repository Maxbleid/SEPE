using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Cow : AbstractSoundMaker
{
    public override void MakeSound()
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("muuuuuuuuuuu");
    }
}

