using UnityEngine;

public class CrearBoton4 : MonoBehaviour
{
    public float currentTimetuCreateboton;

    public float TimeTiCreateboton4 = 80;

    public GameObject prefabsboton1;
    private Transform comTransform;

    public Transform spawnerboton4;
    private void Update()
    {
        currentTimetuCreateboton = currentTimetuCreateboton + Time.deltaTime;
        if (currentTimetuCreateboton >= TimeTiCreateboton4)
        {
            crearBoton4();
            Destroy(this.gameObject);
        }
    }

    private void crearBoton4()
    {
        GameObject boton = Instantiate(prefabsboton1);
        boton.transform.position = spawnerboton4.position;
        boton.transform.rotation = transform.rotation;

    }
}
