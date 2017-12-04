using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text text;
    private int index = 0;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            ShowText();
    }
    private void ShowText()
    {
        if (text.gameObject != null)
        {
            text.text = index.ToString();
            index += 1;
        }
    }
}
