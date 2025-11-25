using UnityEngine;

public class deplacementtank : MonoBehaviour
{
    Vector3 pos_depart;
    Vector3 cible;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pos_depart = transform.position;
        cible = new Vector3(-13,-3f,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cible, 3 * Time.deltaTime);
        if(transform.position == cible)
        {
            transform .position = pos_depart;
        }
    }
}
