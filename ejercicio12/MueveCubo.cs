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

        Vector3 posicionObjetivo = esfera.transform.position;
        posicionObjetivo.y = transform.position.y;
        transform.LookAt(posicionObjetivo);

        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
}
