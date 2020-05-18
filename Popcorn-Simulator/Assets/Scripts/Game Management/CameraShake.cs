using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour

    

{
    public IEnumerator Shake (float duration, float magnitude)
    {

        Vector3 originalPos = transform.position;

        float timer = 0.0f;
        while(timer < duration)
        {
            timer += Time.deltaTime;

            float x = Random.Range(-1, 1) * magnitude;
            float y = Random.Range(-1, 1) * magnitude;

            transform.localPosition = new Vector3(x, y, 0);

            yield return null;
        }

        transform.localPosition = originalPos;
    }
}
