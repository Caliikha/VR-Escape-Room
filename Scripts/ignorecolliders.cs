using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignorecolliders : MonoBehaviour
{
    public GameObject player, obj;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(player.GetComponent<Collider>(), obj.GetComponent<Collider>(), true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
