using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class clearkeypad : MonoBehaviour
{
    public TMP_Text keypadcode;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void cleartext()
    {
        keypadcode.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
