using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class test_code : MonoBehaviour
{
    public int testingvar;
    public TMP_Text test_text;
    public GameObject this_object;
    public GameObject p1,p2,p3;
    // Start is called before the first frame update
    void Start()
    {
                GameObject.DontDestroyOnLoad(this_object);
    }

    void setvar(int x)
    {
        testingvar=x;
    }

    void display_var()
    {
        test_text.text = testingvar.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
