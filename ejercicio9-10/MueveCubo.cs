using UnityEngine;

public class MueveCubo : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        float movimientoHorizontal = 0f;
        float movimientoVertical = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
            movimientoHorizontal = -1f;
        if (Input.GetKey(KeyCode.RightArrow))
            movimientoHorizontal = 1f;
        if (Input.GetKey(KeyCode.DownArrow))
            movimientoVertical = -1f;
        if (Input.GetKey(KeyCode.UpArrow))
            movimientoVertical = 1f;

        transform.Translate(
            movimientoHorizontal * speed * Time.deltaTime,
            movimientoVertical * speed * Time.deltaTime,
            0f);
    }
}
