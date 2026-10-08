using UnityEngine;

public class CambioPos : MonoBehaviour
{
    public Vector3 desplazamiento;

    private Vector3 posicionOriginal;

    private void Start()
    {
        posicionOriginal = transform.position;
    }

    public void UbicarEnNuevaPosicion()
    {
        transform.position = posicionOriginal + desplazamiento;
    }
}
