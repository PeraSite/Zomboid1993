using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NoSoliciting
{
    public class One : MonoBehaviour
    {
        public void SceneChange()
        {
            SceneManager.LoadScene("PressButton");
        }
    }
}
