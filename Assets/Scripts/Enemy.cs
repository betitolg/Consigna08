using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    [Range(1f, 10f)] public float speed=2f;
    
    enum ZombieTypes {
        Crawler,Rioter,LookAlways
    }

    [SerializeField]  ZombieTypes zombieType;


    [SerializeField]  Transform playerTransform;
    public float AxisY = 0f;
    void Start()
    {

       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (zombieType)
        {
            case ZombieTypes.Crawler:
                MoveForward();
                break;
            case ZombieTypes.Rioter:
                ChasePlayer();
                break;
            // case ZombieTypes.Stalker:
            //     RotateAroundPlayer();
            //     break;
            case ZombieTypes.LookAlways:
                LookPlayerWithLerp();
                break;
        }
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
    private void ChasePlayer()
    {LookPlayer();
        Vector3 direction = (playerTransform.position - transform.position);

        
        if (direction.magnitude >2f)
        {
            transform.position +=(direction.normalized * (speed * Time.deltaTime));
        }
        
       
    }
    private void RotateAroundPlayer()
    {LookPlayer();
        transform.RotateAround(playerTransform.position,Vector3.up,20f*Time.deltaTime);
        
        
        
        
    }

    private void LookPlayer()
    {
        transform.LookAt(playerTransform);
    }

    private void LookPlayerWithLerp()
    {LookPlayer();
        Vector3 direction = (playerTransform.position - transform.position);
        
            Quaternion newRotation = Quaternion.Euler(0,direction.normalized.x,0); 
            transform.rotation= Quaternion.Lerp(transform.rotation,newRotation,1f*Time.deltaTime);
        
        
    }

}
