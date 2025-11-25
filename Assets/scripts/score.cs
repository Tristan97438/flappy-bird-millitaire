using System.Collections;
using UnityEngine;

public class score : MonoBehaviour
{
    public int score_joueur;
    [SerializeField] TMPro.TextMeshProUGUI score_text;
    [SerializeField] GameObject explosion;
    bool add_score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        explosion.SetActive(false);
        add_score = false;
        score_joueur = 0;
    }

    // Update is called once per frame
    void Update()
    {
        augmentation_score();
        score_text.text = "Score : " + score_joueur;
    }
    void augmentation_score()
    {
        GameObject[] murs = GameObject.FindGameObjectsWithTag("mur");
        foreach (GameObject mur in murs)
        {

            if(mur.transform.position.x >= -0.25f && mur.transform.position.x <= 0.25f && add_score==false)
            {
                StartCoroutine(anti_spam());
                add_score = true;
            }
        }
    }
    IEnumerator anti_spam()
    {
        explosion.SetActive(true);
        score_joueur++;
        score_text.text = "Score : " + score_joueur;
        yield return new WaitForSeconds(0.5f);
        add_score = false;
        explosion.SetActive(false);
    }
}
