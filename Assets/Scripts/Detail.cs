using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D : MonoBehaviour
{
    public void Detail(){
        SceneManager.LoadScene("Detail_Image");
    }

    public void BackMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
