using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadCode : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private int code;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        code = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = code.ToString();
    }
}
