using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ModifyTextMeshPro : MonoBehaviour
{

    public TMP_Text keypadtext;
    public string dat;
    private static bool  pressed;
    // Start is called before the first frame update
    void Start()
    {
      
            
    }

    public void setPressed()
    {
        if(keypadtext.text=="6 Digits" || keypadtext.text=="Wrong Sequence!" || keypadtext.text=="Enter Text..." || keypadtext.text=="Wrong Answer!")
        {
            keypadtext.text="";
        }
        keypadtext.text = keypadtext.text + dat;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
