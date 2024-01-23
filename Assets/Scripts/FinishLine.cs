using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // SceneManagement namespace 사용

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishEffect.Play(); // 입자 효과 실행
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene() // method 생성
    {
        SceneManager.LoadScene(0); // SceneManager : SceneManagement namespace안에 있는 class 중 하나
    }
}
