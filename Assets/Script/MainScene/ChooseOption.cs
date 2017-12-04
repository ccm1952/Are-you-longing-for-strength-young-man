using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseOption : MonoBehaviour
{
    public List<GameObject> optionList;
    // Use this for initialization
    void Start()
    {
        optionList = new List<GameObject>();
        InitOption();
    }

    private void InitOption()
    {
        var option = Resources.Load("Prefabs/Option") as GameObject;
        var obj = Instantiate(option, this.transform);
        var scr = obj.GetComponent<Option>();
        scr.path = "LatticeScene";
        optionList.Add(obj);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
