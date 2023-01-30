using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckBullet : MonoBehaviour
{
    public GameObject cube1, cube2, cube3;
    public Material mat;
    public void checker()
    {

        if (cube1.GetComponent<Completed_class>().checker && cube2.GetComponent<Completed_class>().checker && cube3.GetComponent<Completed_class>().checker)
        {
            SceneManager.LoadScene("Scene4", LoadSceneMode.Single);
        }


    }
}
