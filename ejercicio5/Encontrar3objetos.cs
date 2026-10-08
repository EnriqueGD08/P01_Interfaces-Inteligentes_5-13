using UnityEngine;

public class Encontrar3objetos : MonoBehaviour
{
    private CambioPos objeto1;
    private CambioPos objeto2;
    private CambioPos objeto3;

    public Vector3 posicion1 = new Vector3(5.98055f, 0.0f, 1.59784f);
    public Vector3 posicion2 = new Vector3(-6.03f, 0.2398f, 0.2398f);
    public Vector3 posicion3 = new Vector3(-1.41f, 0.2398f, -5.41f);

    private bool teclaEspacioPresionada;

    private void Start()
    {
        objeto1 = BuscarObjeto("cube1");
        objeto2 = BuscarObjeto("cube2");
        objeto3 = BuscarObjeto("cube3");
    }

    private void Update()
    {
        bool espacioPresionado = Input.GetAxis("Jump") > 0;

        if (espacioPresionado && !teclaEspacioPresionada)
        {
            PosicionarObjetos();
            MoverObjetos();
        }

        teclaEspacioPresionada = espacioPresionado;
    }

    private CambioPos BuscarObjeto(string tag)
    {
        GameObject objeto = GameObject.FindGameObjectWithTag(tag);
        CambioPos cambioPos = objeto.GetComponent<CambioPos>();

        return cambioPos;
    }

    private void MoverObjetos()
    {
        if (objeto1 != null)
        {
            objeto1.UbicarEnNuevaPosicion();
        }

        if (objeto2 != null)
        {
            objeto2.UbicarEnNuevaPosicion();
        }

        if (objeto3 != null)
        {
            objeto3.UbicarEnNuevaPosicion();
        }
    }

    private void PosicionarObjetos()
    {
        if (objeto1 != null)
        {
            objeto1.transform.position = posicion1;
        }

        if (objeto2 != null)
        {
            objeto2.transform.position = posicion2;
        }

        if (objeto3 != null)
        {
            objeto3.transform.position = posicion3;
        }
    }
}
