using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NoSoliciting
{
    public class Three : MonoBehaviour
    {
        public void SceneChange()
        {
            SceneManager.LoadScene("Play");
        }
    }
}
