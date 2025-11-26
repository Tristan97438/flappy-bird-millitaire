using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    
    public void start_shake()
    {
        float duration = 0.2f;
        float magnitude = 0.10f;
        StopAllCoroutines();
        StartCoroutine(shake_coroutine(duration, magnitude));
    }

    private IEnumerator shake_coroutine(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            // Calcule un décalage aléatoire (Screen Shake)
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = originalPos + new Vector3(x, y, 0);

            elapsed += Time.deltaTime;

            yield return null;
        }

        // Réinitialise la caméra à sa position d'origine
        transform.localPosition = originalPos;
    }
}