using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Leave_Button : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Arena");
    }
}
