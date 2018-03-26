using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using UnityEngine;

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
        MainScene.Instance.InitLatticeParent();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
