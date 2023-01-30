using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckDimensions : MonoBehaviour
{

    public GameObject oneD, twoD, threeD, fourD, gg;
    public TMP_Text success_message;
    bool checker1 = false, checker2 = false, checker3 = false, checker4 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void change_level()
    {
        int[] sd = {-1,1,0,0};
        gg.GetComponent<AI_Script>().make_decision(sd,1);
    }

    public void check_ordering()
    {
        //checking object 1d
        if ((oneD.transform.position.x > 1 && oneD.transform.position.x < 1.5) && (oneD.transform.position.z > -5.4 && oneD.transform.position.z < -4.9))
            checker1 = true;
        //checking object 2
        if ((twoD.transform.position.x > -0.2 && twoD.transform.position.x < 0.2) && (twoD.transform.position.z > -5.4 && twoD.transform.position.z < -4.9))
            checker2 = true;
        //checking object 3
        if ((threeD.transform.position.x > -1.5 && threeD.transform.position.x < -1) && (threeD.transform.position.z > -5.4 && threeD.transform.position.z < -4.9))
            checker3 = true;
        //checking object 4
        if ((fourD.transform.position.x > -2.8 && fourD.transform.position.x < -2.3) && (fourD.transform.position.z > -5.4 && fourD.transform.position.z < -4.9))
            checker4 = true;

        if (checker1 && checker2 && checker3 && checker4)
        {
            success_message.text = "Success!!";
            Invoke("change_level", 5.0f);

        }
        else
            success_message.text = "Not There Yet!!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

