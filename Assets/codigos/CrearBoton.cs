using UnityEngine;

public class CrearBoton : MonoBehaviour
{
    public float TimeTiCreateboton = 20;
    public float currentTimetuCreateboton;

    public float TimeTiCreateboton2 = 40;

    public float TimeTiCreateboton3 = 60;

    public float TimeTiCreateboton4 = 80;

    public GameObject prefabsboton;
    private Transform comTransform;

    public Transform spawnerboton1;
    public Transform spawnerboton2;
    public Transform spawnerboton3;
    public Transform spawnerboton4;
    private void Update()
    {
        currentTimetuCreateboton = currentTimetuCreateboton + Time.deltaTime;
        if (currentTimetuCreateboton >= TimeTiCreateboton)
        {
            Crearboton1();
        }
        if (currentTimetuCreateboton >= TimeTiCreateboton2)
        {
            CrearBoton2();
        }
        if (currentTimetuCreateboton >= TimeTiCreateboton3)
        {
            CrearBoton3();
        }
        if (currentTimetuCreateboton >= TimeTiCreateboton4)
        {
            CrearBoton4();
        }
    }
    private void Crearboton1()
    {
        GameObject boton = Instantiate(prefabsboton);
        boton.transform.position = spawnerboton1.position;
        boton.transform.rotation = transform.rotation;
    }
    private void CrearBoton2()
    {
        GameObject boton = Instantiate(prefabsboton);
        boton.transform.position = spawnerboton2.position;
        boton.transform.rotation = transform.rotation;

    }
    private void CrearBoton3()
    {
        GameObject boton = Instantiate(prefabsboton);
        boton.transform.position = spawnerboton3.position;
        boton.transform.rotation = transform.rotation;

    }
    private void CrearBoton4()
    {
        GameObject boton = Instantiate(prefabsboton);
        boton.transform.position = spawnerboton4.position;
        boton.transform.rotation = transform.rotation;

    }
}
