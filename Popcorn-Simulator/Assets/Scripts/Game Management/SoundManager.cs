using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip popcorn, wind, burnedPopcorn, goldPopcorn;
    static AudioSource audSrc;
    
    void Start()
    {
        audSrc = GetComponent<AudioSource>();

        popcorn = Resources.Load<AudioClip>("popcorn");
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "popcorn":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(popcorn, 0.5f);
                break;
            
        }
    }
}
