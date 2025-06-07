using UnityEngine;
using UnityEngine.UIElements;

public class crearotrapalanca : MonoBehaviour
{
    public GameObject palancaprefab;
    public float xposition;
    public float yPosition;

    public string nametag = "player";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == nametag)
        {
            Vector2 positioncreate = new Vector2(xposition, yPosition);
            GameObject moneda = Instantiate(palancaprefab, positioncreate, transform.rotation);
            Destroy(this.gameObject);
        }
    }


    /*public GameObject prefabEnemy;
    public float minXposition;
    public float maxXposition;
    public float yPosition;
    private void Start()
    {
        Createenemy();
    }
    void Createenemy()
    {
        float xposition = Random.Range(minXposition, maxXposition);
        Vector2 positioncreate = new Vector2(xposition, yPosition);
        GameObject moneda = Instantiate(prefabEnemy, positioncreate, transform.rotation);
        Invoke("Createenemy", 1.0f);
    }*/
}
