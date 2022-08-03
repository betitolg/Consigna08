using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float liveTime = 3f;
    public float speed = 5f;

    private void Start()
    {
        Invoke("DestroyDelay", liveTime);
    }


    private void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }

    private void DestroyDelay()
    {
        Destroy(gameObject);
    }
}