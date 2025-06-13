using UnityEngine;
using UnityEngine.UI;

public class DialogoTemporral : MonoBehaviour
{
    public Text dialogoUI;
    public string mensaje = "¡Hola!";
    public float duracion = 3f;
    private float tiempoRestante = 0f;

    void Update()
    {
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
            if (tiempoRestante <= 0)
            {
                dialogoUI.enabled = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player")
        {
            dialogoUI.text = mensaje;
            dialogoUI.enabled = true;
            tiempoRestante = duracion;
        }
    }
}
