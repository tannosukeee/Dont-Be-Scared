using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                StartCoroutine(TakeToMenu());
    }

        IEnumerator TakeToMenu()
        {
                yield return new WaitForSeconds(4f);
                SceneManager.LoadScene(1);
        }
}
