using UnityEngine;
using System.Collections;
public class mouvmissile : MonoBehaviour
{
    float y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(deplacement());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator deplacement()
    {
        while (true)
        {


            y = transform.position.y;
            gameObject.transform.position = new Vector3( transform.position.x, y - 0.02f, transform.position.z);


            yield return new WaitForSeconds(0.01f);
        }
    }
}
