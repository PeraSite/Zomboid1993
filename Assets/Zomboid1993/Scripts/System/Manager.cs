using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace NoSoliciting
{
    public class Manager : MonoBehaviour
    {
        // �������� ������ ���⿡ ���� �ǵ��� ����� ��ġ�� 0�̵Ǹ� ������ �Ѿ��?? �ƴϸ� 

        // HP
        private int Hp = 100;
        // �����
        private int Hunger = 100;
        // �� ���� ��ġ�� ������ �̺�Ʈ ����
        private int Money = 0;
        // ���
        private int Durability = 100;
        // ����
        private int Break;
        // �޽�����
        private int ThrowUp;
        // Ư�� ��ġ�� 100 �̻��� �Ǹ� Ư���� �̺�Ʈ�� �����


        void Start()
        {
         
        }

       
        void Update()
        {
            System();
        }

        void System()
        {
            //ü�� ����
            if(Hp <= 60)
            {
                // �̹��� ����
            }
            if(Hp <= 20)
            {
                // �̹��� ����
            }
            if(Hp <= 0)
            {
                //�� �ٲ�鼭 ���
            }

            // �����
            if (Hunger <= 0)
            {
                //����� ������ �̵�
            }
            // �ο�� ���� ��ġ�� �޾����� ���?

            // ���
            if (Durability <= 0)
            {
                //�̷��� �Ǹ� ���� ��� �Ұ��� ���� ����â ����
            }

            // ����
            if (Break <= 0)
            {
                // �Ǹ� �� ���̰� ����� or ����?
            }

            // �޽�����
            if (ThrowUp <= 0)
            {
                // ����� ����� �ϸ� ������ ī�޶� ����ŷ or �ǿ� ���õ� �����
            }
        }
    }
}
