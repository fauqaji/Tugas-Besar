using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AturScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Update()
    {
        LoadToScene();
    }
    public void LoadToScene()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Select Song");
        }
    }

}