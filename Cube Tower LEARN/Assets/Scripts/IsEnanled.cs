using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsEnanled : MonoBehaviour
{
    public int needTounlock;
    public Material blackMaterial;

    private void Start()
    {
        if (PlayerPrefs.GetInt("score") < needTounlock)
            GetComponent<MeshRenderer>().material = blackMaterial;
    }
}
