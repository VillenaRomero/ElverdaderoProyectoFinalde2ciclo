using UnityEngine;

public class SalidaFinalcrear : MonoBehaviour
{
    public int vidaJefe = 3;
    public GameObject salidaFinalPrefab;
    public float xposition;
    public float yPosition;

    public void QuitarVida()
    {
        vidaJefe--;
        if (vidaJefe <= 0)
        {
            CrearSalida();
        }
    }
    private void CrearSalida()
    {
        if (salidaFinalPrefab != null)
        {
            Vector2 positioncreate = new Vector2(xposition, yPosition);
            GameObject boton = Instantiate(salidaFinalPrefab, positioncreate, transform.rotation);
        }
    }
}
