using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class colliderdetection : MonoBehaviour
{
    public Material mat;
    public GameObject obj;
    public Color col;
     void OnCollisionEnter(Collision bullet)
    {
        obj.GetComponent<MeshRenderer>().material = mat;
        obj.GetComponent<Light>().color = col;
        obj.GetComponent<Completed_class>().checker = true;
        GetComponent<AudioSource>().Play();
    }
}
