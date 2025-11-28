using System.Collections;
using UnityEngine;

public class spaw_bomb : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    [SerializeField] GameObject canva_game_over;
    float x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawn()
    {
        while (true)
        {
            if(!canva_game_over.activeSelf && GameObject.FindWithTag("bird").GetComponent<mortbird>().mort_b == false)
            {
                x = Random.Range(-11, 11);
                Instantiate(bomb, new Vector3(x, transform.position.y, transform.position.z), Quaternion.Euler(180,0,0));
                yield return new WaitForSeconds(1);
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
            
        }
        
    }
}
