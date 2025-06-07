using UnityEngine;

public class SalidaFinalcrear : MonoBehaviour
{
    public int vidaJefe = 3;
    public GameObject salidaFinalPrefab;
    public Transform spawnerpuerta;

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
            Instantiate(salidaFinalPrefab, spawnerpuerta.position, transform.rotation);
        }
    }
}
