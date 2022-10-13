using System.Security.Cryptography;
using UnityEngine;

public class scriptprefab : MonoBehaviour

{

    public GameObject objetoAInstanciar;
    public Transform lugar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.K))
		{
			Disparo();
		}
    }

    void Disparo(){
        Instantiate(objetoAInstanciar, lugar.GetComponent<Transform>().position, Quaternion.identity);
    }
}
