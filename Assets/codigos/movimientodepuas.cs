using UnityEngine;

public class movimientodepuas : MonoBehaviour
{
    public int speedx = 0;
    public int speedy = 40;
    private Rigidbody2D rigibody2D_;
    private Transform comTransform;
    public float speed = 4;
    public string nametag = "paredfondo";
    public string nametag1 = "pareddestruccion";

    void Start()
    {
        rigibody2D_ = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rigibody2D_.linearVelocity = new Vector2(speed * speedx, speed * speedy);
    }
    /*void OnCollisionEnter2D(Collision2D collision)
    {

        /*if (collision.gameObject.tag == nametag ||)
        {
            speedy *= -4;
        }
        else if (collision.gameObject.tag == nametag1 || )
        {
            speedy *= +4;
        }
        if (collision.gameObject.tag == nametag)
        {
            speedy = -10;
        }
        if (collision.gameObject.tag == nametag1)
        {
            Destroy(gameObject);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == nametag)
        {
            speedy = -10;
        }
        if (collision.gameObject.tag == nametag1)
        {
            Destroy(gameObject);
        }
    }
}
