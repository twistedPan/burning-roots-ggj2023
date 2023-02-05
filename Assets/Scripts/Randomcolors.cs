using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomcolors : MonoBehaviour
{
    [SerializeField] private Material[] bodyMaterials;
    [SerializeField] private Material[] detailsMaterials;
    [SerializeField] private Material[] bladeMaterials;
    [SerializeField] private Material[] hoverpadMaterials;

    [SerializeField] private GameObject[] vehicles;
    void Start()
    {
        foreach (GameObject go in vehicles)
        {
            go.transform.GetChild(0).Find("body").GetComponent<SkinnedMeshRenderer>().material = bodyMaterials[UnityEngine.Random.Range(0, 4)];
            go.transform.GetChild(0).Find("details").GetComponent<SkinnedMeshRenderer>().material = detailsMaterials[UnityEngine.Random.Range(0, 4)];
            go.transform.GetChild(0).Find("blade").GetComponent<SkinnedMeshRenderer>().material = bladeMaterials[UnityEngine.Random.Range(0, 4)];
            go.transform.GetChild(0).Find("hoverpods").GetComponent<SkinnedMeshRenderer>().material = hoverpadMaterials[UnityEngine.Random.Range(0, 4)];
        }
    }
}
