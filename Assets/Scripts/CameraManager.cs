using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] cameras;
    public  bool status = true;

    void Start()
    {
          cameras[0].SetActive(status);
           cameras[1].SetActive(!status);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.F1))
        {
            
 status=!status;
if (status)
{
    cameras[0].SetActive(status);
           cameras[1].SetActive(!status);
}else{
    cameras[0].SetActive(status);
           cameras[1].SetActive(!status);
}

        }

 

    }



        
       
           
      
        // if (Input.GetKeyDown(KeyCode.F2))
        // {
        //     cameras[0].SetActive(false);
        //     cameras[1].SetActive(true);
        //     cameras[2].SetActive(false);
        // }
        // if (Input.GetKeyDown(KeyCode.F3))
        // {
        //     cameras[0].SetActive(false);
        //     cameras[1].SetActive(false);
        //     cameras[2].SetActive(true);
        // }
        
    
}
