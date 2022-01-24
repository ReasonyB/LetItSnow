using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMange : MonoBehaviour
{
    public void OnClickSkipToStart(){
        SceneManager.LoadScene(1);
    }
}
