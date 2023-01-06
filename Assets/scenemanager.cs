using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public void oneplus()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }

    public void oneminus()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); }

    public void twoplus()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); }

    public void twominus()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); }

    public void threeplus()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3); }

    public void threeminus()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3); }

    public void fourplus()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4); }

    public void fourminus()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4); }
}
