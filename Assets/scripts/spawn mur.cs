using System.Collections;
using UnityEngine;

public class spawnmur : MonoBehaviour
{
    [SerializeField] GameObject mur1, mur2,mur3;
    [SerializeField] GameObject canva_game_over;
    float temp_entre_mur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        temp_entre_mur = 2f;
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
                Instantiate(mur1, gameObject.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(temp_entre_mur);
                
            }
            if (!canva_game_over.activeSelf && GameObject.FindWithTag("bird").GetComponent<mortbird>().mort_b == false)
            {
                
                Instantiate(mur2, gameObject.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(temp_entre_mur);
            }
            if (!canva_game_over.activeSelf && GameObject.FindWithTag("bird").GetComponent<mortbird>().mort_b == false)
            {

                Instantiate(mur3, gameObject.transform.position, Quaternion.identity);
                yield return new WaitForSeconds(temp_entre_mur);
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
            if(GetComponent<score>().score_joueur%5 == 0)
            {
                temp_entre_mur -= 0.1f;
            }
            
        }
    }
}
