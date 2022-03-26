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

        /*���콺 Ŀ�� ����� 
        Ŭ���ϸ� bool ���� �̿��ؼ� �ٲٰ� ���콺���� �������� false; ���Ǽ� �ٽ� ���󺹱�����;
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
