using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class CheckRiddle2 : MonoBehaviour
{

    public TMP_Text keypadcode;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void check_code()
    {
        if (keypadcode.text == "future" || keypadcode.text == "the future")
        {
            SceneManager.LoadScene("Scene3", LoadSceneMode.Single);
        }
        else
        {
            keypadcode.text = "Wrong Answer!";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
