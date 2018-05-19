using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {

public void switchtoshop()
    {
        SceneManager.LoadScene("Shop", LoadSceneMode.Single);

    }

public void switchtogame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);

    }
}
