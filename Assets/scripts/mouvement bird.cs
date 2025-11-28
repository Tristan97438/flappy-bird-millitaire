using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class mouvementbird : MonoBehaviour
{
    float y;
    float x;
    [SerializeField] GameObject explosion_obj;
    [SerializeField]UnityEvent effet_saut;
    [SerializeField] GameObject canva_game_over;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        explosion_obj.SetActive(false);
        StartCoroutine(mouv());
    }

    // Update is called once per frame
    void Update()
    {
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            effet_saut.Invoke();
            y += 1f;
            
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, y, gameObject.transform.position.z);
            StartCoroutine(explosion());
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            x -= 1f;
            gameObject.transform.position = new Vector3(x,gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            x += 1f;
            gameObject.transform.position = new Vector3(x, gameObject.transform.position.y, gameObject.transform.position.z);
        }


    }
    IEnumerator mouv()
    {
        while (true) 
        {
            if(!canva_game_over.activeSelf && GameObject.FindWithTag("bird").GetComponent<mortbird>().mort_b == false)
            {
                y = gameObject.transform.position.y;


                gameObject.transform.position = new Vector3(gameObject.transform.position.x, y -= 0.1f, gameObject.transform.position.z);
                yield return new WaitForSeconds(0.1f);
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }



        }

       
        
    }
    IEnumerator explosion()
    {
        explosion_obj.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        explosion_obj.SetActive(false);
    }
    public void lancer_effet_saut()
    {
        StartCoroutine(effet_saut_bird());
    }

    IEnumerator effet_saut_bird()
    {
        transform.rotation = Quaternion.Euler(0, 0, 20);
        yield return new WaitForSeconds(0.50f);
        transform.rotation = Quaternion.Euler(0, 0, -10);
    }
}
