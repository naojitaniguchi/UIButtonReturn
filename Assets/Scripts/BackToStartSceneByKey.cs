using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToStartSceneByKey : MonoBehaviour
{
    [SerializeField] string Key;
    [SerializeField] string SceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Key))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
