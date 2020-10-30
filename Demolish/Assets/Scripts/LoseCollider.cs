using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("LoadFirstlevel", 1.0f);
        Debug.Log(collision.gameObject.name);
    }
    public void LoadFirstlevel()
    {
      SceneManager.LoadScene("Game Over");
    }

}

