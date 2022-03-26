using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace NoSoliciting
{
    public class Manager : MonoBehaviour
    {
        // 선택지를 누르면 여기에 적용 되도록 만들기 수치가 0이되면 씬으로 넘어갈지?? 아니면 

        // HP
        private int Hp = 100;
        // 배고픔
        private int Hunger = 100;
        // 돈 일정 수치가 넘으면 이벤트 연결
        private int Money = 0;
        // 장비
        private int Durability = 100;
        // 골절
        private int Break;
        // 메스꺼움
        private int ThrowUp;
        // 특정 수치가 100 이상이 되면 특정한 이벤트로 연결됨


        void Start()
        {
         
        }

       
        void Update()
        {
            System();
        }

        void System()
        {
            //체력 관련
            if(Hp <= 60)
            {
                // 이미지 변경
            }
            if(Hp <= 20)
            {
                // 이미지 변경
            }
            if(Hp <= 0)
            {
                //씬 바뀌면서 사망
            }

            // 배고픔
            if (Hunger <= 0)
            {
                //배고픔 씬으로 이동
            }
            // 싸우면 골절 수치랑 메쓰꺼움 장비?

            // 장비
            if (Durability <= 0)
            {
                //이렇게 되면 무기 사용 불가능 무기 선택창 막힘
            }

            // 골절
            if (Break <= 0)
            {
                // 피를 더 깍이게 만든다 or 죽음?
            }

            // 메스꺼움
            if (ThrowUp <= 0)
            {
                // 디버프 생기게 하면 좋은데 카메라 쉐이킹 or 피에 관련된 디버프
            }
        }
    }
}
