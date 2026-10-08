using UnityEngine;

public class MueveCubo : MonoBehaviour
{
    public GameObject esfera;
    public float speed = 2f;

    void Update()
    {
        bool flechaPulsada = Input.GetKey(KeyCode.UpArrow)
            || Input.GetKey(KeyCode.DownArrow)
            || Input.GetKey(KeyCode.LeftArrow)
            || Input.GetKey(KeyCode.RightArrow);

        if (!flechaPulsada)
            return;

        esfera = GameObject.FindGameObjectWithTag("sphere");

        Vector3 direccion = esfera.transform.position - transform.position;
        direccion.y = 0f;
        direccion = direccion.normalized;

        transform.Translate(
            direccion.x * speed * Time.deltaTime,
            direccion.y * speed * Time.deltaTime,
            direccion.z * speed * Time.deltaTime,
            Space.World);
    }
}
