
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip popcorn, wind, burnedPopcorn, burntCatch, gold, yay, timer, gameOver, bu, bd;
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
        gold = Resources.Load<AudioClip>("gold");
        gameOver = Resources.Load<AudioClip>("gameOver");
        bu = Resources.Load<AudioClip>("ButtonUp");
        bd = Resources.Load<AudioClip>("ButtonDown");
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "popcorn":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(popcorn, 1.3f);
                break;
            case "burnedPopcorn":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(burnedPopcorn, 1.7f);
                break;

            case "burntCatch":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(burntCatch, 2.5f);
                break;

            case "Wind":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(wind, 0.5f);
                break;
            case "yay":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(yay, 0.2f);
                break;
            case "timer":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(timer, 0.6f);
                break;
            case "gold":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(gold, 0.5f);
                break;
            case "gameOver":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(gameOver, 1.5f);
                break;
            case "bu":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(bu, 1.5f);
                break;
            case "bd":
                //audSrc.pitch = Random.Range(0.8f, 1f);
                audSrc.PlayOneShot(bd, 1.5f);
                break;




        }
    }
}
