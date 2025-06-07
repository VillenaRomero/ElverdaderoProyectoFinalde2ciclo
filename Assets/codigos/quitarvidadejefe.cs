using UnityEngine;

public class quitarvidadejefe : MonoBehaviour
{
    public string nametag;
    public SalidaFinalcrear controladorJefe;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(nametag))
        {
            if (controladorJefe != null)
            {
                controladorJefe.QuitarVida();
            }
            Destroy(gameObject);
        }
    }
}
