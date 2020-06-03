using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyMusic : MonoBehaviour
{
    public string currentScene;
    public bool playing = false;
    public AudioSource aud;
    private static GameObject instance;
    private void Awake()
    {

        DontDestroyOnLoad(this);
        if (instance == null)
            instance = gameObject;
        else
            Destroy(gameObject);

    }

    private void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;

        if(playing == true && currentScene.Equals("Kitchen")
            || currentScene.Equals("Moon")
            || currentScene.Equals("PARK")
            || currentScene.Equals("Beach"))
        {
            Stop();
            playing = false;
        }
        if(currentScene.Equals("Main Menu") && playing == false || currentScene.Equals("ScenarioChoice") && playing == false)
        {
            Play();
            playing = true;
        }
    }

    private void Play()
    {
        aud.Play();
    }

    private void Stop()
    {
        aud.Stop();
    }
}
