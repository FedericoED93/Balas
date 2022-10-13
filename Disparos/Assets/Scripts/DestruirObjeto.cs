using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{

    public float destroyTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }
}
