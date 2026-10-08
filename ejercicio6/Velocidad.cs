using UnityEngine;

public class Velocidad : MonoBehaviour
{
    public float velocidad = 1f;

    void Update()
    {
        float valorHorizontal = Input.GetAxis("Horizontal");
        float valorVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.UpArrow))
            Debug.Log("Flecha arriba: " + velocidad * valorVertical);

        if (Input.GetKey(KeyCode.DownArrow))
            Debug.Log("Flecha abajo: " + velocidad * valorVertical);

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("Flecha izquierda: " + velocidad * valorHorizontal);

        if (Input.GetKey(KeyCode.RightArrow))
            Debug.Log("Flecha derecha: " + velocidad * valorHorizontal);
    }
}
