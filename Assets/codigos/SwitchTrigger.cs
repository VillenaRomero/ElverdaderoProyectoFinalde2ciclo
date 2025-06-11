using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SwitchTrigger : MonoBehaviour
{
    public GameObject luzAPrefab;
    public GameObject luzBPrefab;

    public Transform puntoInstancia; // Lugar donde se crean las luces

    private GameObject luzActual;
    private bool activo = false;

    public void Toggle()
    {
        activo = !activo;

        // Eliminar luz actual
        if (luzActual != null)
        {
            Destroy(luzActual);
        }

        // Instanciar nueva luz según el estado
        if (activo)
        {
            if (luzBPrefab != null && puntoInstancia != null)
            {
                luzActual = Instantiate(luzBPrefab, puntoInstancia.position, Quaternion.identity);
            }
        }
        else
        {
            if (luzAPrefab != null && puntoInstancia != null)
            {
                luzActual = Instantiate(luzAPrefab, puntoInstancia.position, Quaternion.identity);
            }
        }
    }
}
