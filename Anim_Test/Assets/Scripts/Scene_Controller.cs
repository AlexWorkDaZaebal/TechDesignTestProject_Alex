using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    public void LoadScene(int sceneId)
    {
        StartCoroutine(startScene(sceneId));
    }

    IEnumerator startScene(int sceneId)
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(sceneId);
    }

}
