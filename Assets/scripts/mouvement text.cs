using UnityEngine;
using System.Collections;
public class mouvementtext : MonoBehaviour
{
    private Vector3 changement_scale;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(anim_scale());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator anim_scale()
    {
        while (true)
        {
            while (transform.localScale.x < 1.5f)
            {
                changement_scale.x = transform.localScale.x + 0.1f;
                changement_scale.y = transform.localScale.y + 0.1f;
                transform.localScale = changement_scale;
                yield return new WaitForSeconds(0.1f);
            }
            while (transform.localScale.x > 0.8f)
            {
                changement_scale.x = transform.localScale.x - 0.1f;
                changement_scale.y = transform.localScale.y - 0.1f;
                transform.localScale = changement_scale;
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
