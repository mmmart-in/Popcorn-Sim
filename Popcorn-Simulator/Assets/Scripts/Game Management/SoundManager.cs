
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip popcorn, wind, burnedPopcorn, burntCatch, goldPopcorn;
    static AudioSource audSrc;

    void Start()
    {
        audSrc = GetComponent<AudioSource>();

        popcorn = Resources.Load<AudioClip>("popcorn");
        burnedPopcorn = Resources.Load<AudioClip>("burnedPopcorn");
        burntCatch = Resources.Load<AudioClip>("burntPopcornCatch");
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "popcorn":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(popcorn, 0.5f);
                break;
            case "burnedPopcorn":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(burnedPopcorn, 0.7f);
                break;

            case "burntCatch":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(burntCatch, 1.3f);
                break;


        }
    }
}
