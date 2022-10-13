using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public float playerSpeed = 5f;

    public float scaleMod = 5f;

    public Vector3 position;

    [SerializeField] private Vector3 escala;

    float vidaInicial = 100;

    // Start is called before the first frame update
    void Start()
    {
        
        SumarVida(ref vidaInicial);
        Debug.Log(vidaInicial);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position,new Vector3(1,0,0)*10,Color.red);
        transform.localScale += escala * scaleMod;
        transform.position += (position * playerSpeed) * Time.deltaTime;
        QuitarVidaJugador();
    }

    public void SumarVida(ref float vida)
    {
        vida = vida + 50;
        
    }

    void QuitarVidaJugador(){
        vidaInicial -= Time.deltaTime;
        Debug.Log(vidaInicial);
    }
}
