using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaDeCarregamento : MonoBehaviour
{
    public void LoadByName()
    {
        SceneManager.LoadScene("Level");
    }
}
