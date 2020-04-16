using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InchideAplicatia : MonoBehaviour
{
    public void ExitApp()
    {
#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
