using UnityEngine;

public class CrearBoton : MonoBehaviour
{
    public float TimeTiCreateboton = 20;
    public float currentTimetuCreateboton;

    public GameObject prefabsboton;

    private Transform comTransform;

    public Transform spawnerboton1;

    private void Update()
    {
        currentTimetuCreateboton = currentTimetuCreateboton + Time.deltaTime;
        if (currentTimetuCreateboton >= TimeTiCreateboton)
        {
            Crearboton1();
            Destroy(this.gameObject);
        }
    }
    private void Crearboton1()
    {
        GameObject boton = Instantiate(prefabsboton);
        boton.transform.position = spawnerboton1.position;
        boton.transform.rotation = transform.rotation;
    }
}
