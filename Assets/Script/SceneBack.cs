using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBack : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Title");
    }
}