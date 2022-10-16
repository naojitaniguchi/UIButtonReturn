using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneByButtonSubmit : MonoBehaviour
{
    [SerializeField] string NextScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Submit()
    {
        Debug.Log("Submit");
        SceneManager.LoadScene(NextScene);
    }
}
