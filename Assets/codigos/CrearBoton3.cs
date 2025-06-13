using UnityEngine;

public class CrearBoton3 : MonoBehaviour
{
    public float currentTimetuCreateboton;

    public float TimeTiCreateboton3 = 60;

    public GameObject prefabsboton1;

    private Transform comTransform;

    public Transform spawnerboton3;

    private void Update()
    {
        currentTimetuCreateboton = currentTimetuCreateboton + Time.deltaTime;

        if (currentTimetuCreateboton >= TimeTiCreateboton3)
        {
            crearBoton3();
            Destroy(this.gameObject);
        }

    }
    private void crearBoton3()
    {
        GameObject boton = Instantiate(prefabsboton1);
        boton.transform.position = spawnerboton3.position;
        boton.transform.rotation = transform.rotation;

    }
}
