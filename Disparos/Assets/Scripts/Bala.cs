using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed;
    public float damage;

    void Update()
    {
        transform.position += new Vector3(1, 1, 0) * speed * Time.deltaTime;
    }
}
