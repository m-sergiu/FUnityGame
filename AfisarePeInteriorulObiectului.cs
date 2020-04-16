using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class AfisarePeInteriorulObiectului : MonoBehaviour
{
    public GameObject SferaCuImagineaPanoramica;

    private void Awake()
    {
        InverseazaSuprafataRedare();
    }

    void InverseazaSuprafataRedare()
    {
        Vector3[] normale = SferaCuImagineaPanoramica.GetComponent<MeshFilter>().sharedMesh.normals;
        for(int i = 0;  i<normale.Length; i++) { normale[i] = -normale[i]; }
        SferaCuImagineaPanoramica.GetComponent<MeshFilter>().sharedMesh.normals = normale;

        int[] triunghiuriText = SferaCuImagineaPanoramica.GetComponent<MeshFilter>().sharedMesh.triangles;
        int t;
        for (int i = 0; i < triunghiuriText.Length; i += 3) {
            t = triunghiuriText[i];
            triunghiuriText[i] = triunghiuriText[i + 2];
            triunghiuriText[i + 2] = t;
        }
        SferaCuImagineaPanoramica.GetComponent<MeshFilter>().sharedMesh.triangles = triunghiuriText;
    }
}
