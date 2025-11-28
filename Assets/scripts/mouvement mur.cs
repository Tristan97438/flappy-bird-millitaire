using System.Collections;
using UnityEngine;

public class mouvementmur : MonoBehaviour
{
    GameObject score;
    float speed;
    mortbird mortbird;
    float x;
    bool speed_changer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed_changer = false;
        score = GameObject.FindWithTag("score");
        speed = 0.05f;
        StartCoroutine(deplacement());
    }

    // Update is called once per frame
    void Update()
    {
        changement_speed();
    }
    IEnumerator deplacement()
    {
        while (true)
        {
            
            
                x = transform.position.x;
                gameObject.transform.position = new Vector3(x - speed, transform.position.y, transform.position.z);
            
            
            yield return new WaitForSeconds(0.01f);
            
            
        }
    }
    void changement_speed()
    {
        if (score.GetComponent<score>().score_joueur % 5 == 0 && speed < 0.1f && !speed_changer)
        {
            speed_changer=true;
            StartCoroutine(change_speed());
        }
    }
    IEnumerator change_speed()
    {
        speed += 0.01f;
        yield return new WaitForSeconds(1f);
        speed_changer = false;
    }
}
