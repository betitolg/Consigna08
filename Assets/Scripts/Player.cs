using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed = 20f;
    public GameObject munition;
    public float cameraAxisX = 0f;
    

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        RotatePlayer();
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * (speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * (speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * (Time.deltaTime * speed));
        if (Input.GetKeyUp(KeyCode.Space)) Shoot();
    }

    private void Shoot()
    {
        Debug.Log("aaa");
        Instantiate(munition, transform.position, transform.rotation);
    }


    public void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion newRotation = Quaternion.Euler(0,cameraAxisX,0); ;
        // transform.rotation = Quaternion.Euler(0,cameraAxisX*0.1f,0);
transform.rotation= Quaternion.Lerp(transform.rotation,newRotation,2f*Time.deltaTime);
    }



}