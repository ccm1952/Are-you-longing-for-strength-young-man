using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    public static MainScene Instance { get; set; }
    public const string SceneName = "MainScene";
    public GameObject latticeParent;

    private bool isLattice = false;
    private float oldTime;
    private GameObject latticeObj;
    private int index = 0;
    private void Start()
    {
        Instance = this;
    }

    private void OnDestroy()
    {
        Instance = null;
    }
    private void Update()
    {
        if (Time.time - oldTime >= 2f && isLattice)
        {
            if (latticeObj == null)
                latticeObj = Resources.Load<GameObject>("Prefabs/Lattice");
            var obj = Instantiate(latticeObj, latticeParent.transform);
            var cell = obj.GetComponent<Lattice>();
            cell.transform.position = Vector2.zero;
            cell.Init();
            oldTime = Time.time;
            index += 1;
        }
        if (index >= 10)
            isLattice = false;
    }
    public void InitLatticeParent()
    {
        isLattice = true;
        latticeParent.SetActive(true);
    }
}
