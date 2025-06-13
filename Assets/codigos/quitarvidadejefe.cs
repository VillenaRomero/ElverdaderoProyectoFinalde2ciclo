using UnityEngine;

public class quitarvidadejefe : MonoBehaviour
{
    public string nametag;
    public SalidaFinalcrear controladorJefe;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == nametag)
        {
            if (controladorJefe != null)
            {
                controladorJefe.QuitarVida();
            }
            Destroy(gameObject);
        }
    }
}
