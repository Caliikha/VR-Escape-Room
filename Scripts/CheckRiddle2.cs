using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class CheckRiddle1 : MonoBehaviour
{

    public TMP_Text keypadcode;
    private string correct_sequence = "darkness";
    // Start is called before the first frame update
    void Start()
    {

    }

    public void check_code()
    {
        if (keypadcode.text == correct_sequence)
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
