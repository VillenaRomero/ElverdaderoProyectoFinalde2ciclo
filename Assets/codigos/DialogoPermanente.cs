using UnityEngine;
using UnityEngine.UI;

public class DialogoPermanente : MonoBehaviour
{
    public Text dialogoUI;
    public string mensaje;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogoUI.text = mensaje;
            dialogoUI.enabled = true;
        }
    }
}
