using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class CheckKeypadCode : MonoBehaviour
{

    public TMP_Text keypadcode;
    public GameObject gg; 
    private string correct_sequence = "112358";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void check_code()
    {
        if (keypadcode.text == correct_sequence)
        {
            int[] sd = {1,-1,0,0};
            gg.GetComponent<AI_Script>().make_decision(sd,1);
        }
        else
        {
            keypadcode.text = "Wrong Sequence!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
