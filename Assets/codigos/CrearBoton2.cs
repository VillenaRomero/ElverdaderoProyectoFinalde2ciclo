using UnityEngine;

public class CrearBoton2 : MonoBehaviour
{
    public float currentTimetuCreateboton;

    public float TimeTiCreateboton2 = 40;

    public GameObject prefabsboton;

    private Transform comTransform;

    public Transform spawnerboton2;

    private void Update()
    {
        currentTimetuCreateboton = currentTimetuCreateboton + Time.deltaTime;
        if (currentTimetuCreateboton >= TimeTiCreateboton2)
        {
            crearBoton2();
            Destroy(this.gameObject);
        }
    }
    private void crearBoton2()
    {
        GameObject boton = Instantiate(prefabsboton);
        boton.transform.position = spawnerboton2.position;
        boton.transform.rotation = transform.rotation;

    }
}
