using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float z,x,y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        z = 0;
        StartCoroutine(rotation());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator rotation()
    {
        while (true)
        {
            z += 1;
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, z);
            yield return new WaitForSeconds(0.05f);
        }
       
    }
}
