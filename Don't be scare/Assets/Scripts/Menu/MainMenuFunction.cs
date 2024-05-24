using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
        public GameObject fadeOut;
        public GameObject loadingText;
        public AudioSource buttonClick;

        public void NewGameButton()
        {
                StartCoroutine(NewGameStart());
        }

        IEnumerator NewGameStart()
        {
                buttonClick.Play();
                fadeOut.SetActive(true);
                yield return new WaitForSeconds(3);
                loadingText.SetActive(true);
                SceneManager.LoadScene(2);
        }
}
