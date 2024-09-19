using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Time.deltaTime * new Vector3(0, speed, 0));
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
