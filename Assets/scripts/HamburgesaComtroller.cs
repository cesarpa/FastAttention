using UnityEngine;
using System.Collections;

public class HamburgesaComtroller : MonoBehaviour {

    public Transform objetoCrear;
    public float xObjetoCrear;
    public float yObjetoCrear;
    private int contadorComida;
    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(objetoCrear, new Vector3(xObjetoCrear, yObjetoCrear, 0), Quaternion.identity);
        }
    }
    void Start()
    {
        contadorComida = 0;
    }

    void OnMouseDown()
    {
        Debug.Log("ON MOUSE DOWN");
        Destroy(gameObject);
    }
}
