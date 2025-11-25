using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class mortbird : MonoBehaviour
{
    [SerializeField] AudioSource monde , mort_son;
    private Transform rectTransform;
    private Vector3 taille_normale;
    private Vector3 changement_scale;
    public float grossisement = 2f;
    public float duree_zoom = 0.5f;
    [SerializeField] UnityEvent mort_bird;
    [SerializeField] GameObject canva , score;
    [SerializeField] TMPro.TextMeshProUGUI score_mort;
    public bool mort_b;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        mort_b = false;
        rectTransform = GetComponent<Transform>();
        taille_normale = rectTransform.localScale;
        canva.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= -5)
        {
            StartCoroutine(mort());
            
        }
    }
    public void restart()
    {
        monde.Play();
        canva.SetActive(false);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
        score.GetComponent<score>().score_joueur = 0;
    }
    public void exit()
    {
        Application.Quit();
    }
    public void quitter()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (mort_b == false)
        StartCoroutine(mort());
        
    }
    IEnumerator mort()
    {
        score_mort.text = "Score : " + score.GetComponent<score>().score_joueur;
        monde.Stop();
        mort_son.Play();
        mort_b = true;
        detruire_murs();
        mort_bird.Invoke();
        while(transform.localScale.x < 1.5f)
        {
            changement_scale.x = transform.localScale.x +0.1f;
            changement_scale.y = transform.localScale.x+0.1f;
            transform.localScale = changement_scale;
            yield return new WaitForSeconds(0.1f);
        }
        canva.SetActive(true);
        transform.localScale = taille_normale;
        mort_b = false;
    }
    private void detruire_murs()
    {
       
        GameObject[] murs = GameObject.FindGameObjectsWithTag("mur");

        
        foreach (GameObject mur in murs)
        {
            
            Destroy(mur);
        }

    }
}
