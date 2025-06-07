using UnityEngine;

public class sierradederechayizquierda : MonoBehaviour
{
    public int speedx = 5;
    public int speedy =0;
    private Rigidbody2D rigibody2D_;
    private Transform comTransform;
    public float speed = 4;
    public string nametag = "pared";

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
        if (collision.gameObject.tag == nametag )
        {
            Destroy(this.gameObject);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == nametag)
        {
            Destroy(this.gameObject);
        }
    }
}
