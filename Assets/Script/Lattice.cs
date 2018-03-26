using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lattice : MonoBehaviour
{
    public float speed = 1f;

    
    private bool isStart = false;
    public void Init()
    {
        isStart = true;
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 1);
        if (this.transform.position.y > 800)
            DestroyObject(this.gameObject);
    }
}
