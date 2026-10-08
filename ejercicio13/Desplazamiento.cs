using UnityEngine;

public class Desplazamiento : MonoBehaviour
{
    private float velocidad = 5f;
    private float velocidadGiro = 120f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, horizontal * velocidadGiro * Time.deltaTime);
        transform.position += transform.forward * velocidad * Time.deltaTime;

        Debug.DrawRay(transform.position, transform.forward, Color.blue);
    }
}
