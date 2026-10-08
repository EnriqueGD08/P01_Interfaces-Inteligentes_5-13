using UnityEngine;

public class MueveDireccion : MonoBehaviour
{
    public Vector3 moveDirection = Vector3.right;
    public float speed = 2f;

    void Update()
    {
        transform.Translate(
            moveDirection.x * speed * Time.deltaTime,
            moveDirection.y * speed * Time.deltaTime,
            moveDirection.z * speed * Time.deltaTime);
    }
}
