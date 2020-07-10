using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePersist : MonoBehaviour
{
    int startingScenIndex;

    private void Awake()
    {
        Time.timeScale = 1;/////////////////////////////////
        int numScenePersist = FindObjectsOfType<ScenePersist>().Length;
        if (numScenePersist > 1) Destroy(gameObject);
        else DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        startingScenIndex = SceneManager.GetActiveScene().buildIndex; 
    }

    // Update is called once per frame
    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex != startingScenIndex)
        {
            Destroy(gameObject);
        }
    }
}
