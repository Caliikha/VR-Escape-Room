using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class checkbucket : MonoBehaviour
{
    public GameObject sphere, cube, capsule, cylinder;
    public TMP_Text success_message;
    bool checker1 = false, checker2 = false, checker3 = false, checker4=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void check_bucket()
    {
        //checking object 1
        if ((sphere.transform.position.x > -5.5 && sphere.transform.position.x < -4.9) && (sphere.transform.position.z > 8 && sphere.transform.position.z < 8.5))
            checker1 = true;
        //checking object 2
        if ((cylinder.transform.position.x > 5.2 && cylinder.transform.position.x < 5.7) && (cylinder.transform.position.z > -6 && cylinder.transform.position.z < -5.5))
            checker2 = true;
        //checking object 3
        if ((capsule.transform.position.x > -5.6 && capsule.transform.position.x < -5) && (capsule.transform.position.z > -6 && capsule.transform.position.z < -5.5))
            checker3 = true;
        //checking object 4
        if ((cube.transform.position.x > 5 && cube.transform.position.x < 5.5) && (cube.transform.position.z > 8.1 && cube.transform.position.z < 8.6))
            checker4 = true;

        if(checker1 && checker2 && checker3 && checker4)
            success_message.text = "Success";
        else
            success_message.text = "damn that sucks!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
