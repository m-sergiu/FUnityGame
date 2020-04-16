using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LanseazaScenaDinButon : MonoBehaviour
{
    public void LoadSceneByIndex(int indexScena)
    {
        SceneManager.LoadScene(indexScena);
        Time.timeScale = 1;
    }
}
