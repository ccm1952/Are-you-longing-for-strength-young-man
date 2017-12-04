using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public Text des;
    public string path;
    // Use this for initialization
    void Start()
    {

    }
    public void OpenOption()
    {
        des.text = path;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
