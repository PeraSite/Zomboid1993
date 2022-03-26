using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NoSoliciting
{
    public class Mouse : MonoBehaviour
    {
        [SerializeField] Texture2D cursorImg;

        [SerializeField] Texture2D clickCursor;       
      
        void Start()
        {
            Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.ForceSoftware);
        }

        void Update()
        {
            Press();
        }

        /*마우스 커서 만들기 
        클릭하면 bool 값을 이용해서 바꾸고 마우스에서 손을떄면 false; 가되서 다시 원상복구가됨;
        */

        void Press()
        {
            if (Input.GetMouseButton(0))
            {
                Cursor.SetCursor(clickCursor, Vector2.zero, CursorMode.ForceSoftware);
            }

            if (Input.GetMouseButtonUp(0))
            {
                Cursor.SetCursor(cursorImg, Vector2.zero, CursorMode.ForceSoftware);
            }
        }
    }
}
