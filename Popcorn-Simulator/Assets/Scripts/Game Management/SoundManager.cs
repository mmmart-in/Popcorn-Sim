
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip popcorn, wind, burnedPopcorn, burntCatch, goldPopcorn, yay, timer;
    static AudioSource audSrc;

    void Start()
    {
        audSrc = GetComponent<AudioSource>();

        popcorn = Resources.Load<AudioClip>("popcorn");
        burnedPopcorn = Resources.Load<AudioClip>("burnedPopcorn");
        burntCatch = Resources.Load<AudioClip>("burntPopcornCatch");
        wind = Resources.Load<AudioClip>("Wind");
        yay = Resources.Load<AudioClip>("yay");
        timer = Resources.Load<AudioClip>("TIMER");
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "popcorn":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(popcorn, 1f);
                break;
            case "burnedPopcorn":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(burnedPopcorn, 1.2f);
                break;

            case "burntCatch":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(burntCatch, 1.6f);
                break;

            case "Wind":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(wind, 0.2f);
                break;
            case "yay":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(yay, 0.2f);
                break;
            case "timer":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(timer, 0.4f);
                break;



        }
    }
}
