using System.Collections;
using TMPro;
using UnityEngine;

namespace MyFps
{
    public class XrFirstTrigger : WorldMenu
    {
        #region Variables
        public GameObject locomotion;

        public GameObject theArrow;

        //sequence UI        
        [SerializeField]
        private string sequence = "Looks like a weapon on that table";

        public AudioSource line03;
        #endregion

        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(PlaySequence());
        }

        //Ʈ���� �۵��� �÷���
        IEnumerator PlaySequence()
        {
            //�÷��� ĳ���� ��Ȱ��ȭ(�÷��� ����)
            locomotion.SetActive(false);

            //��� ���: "Looks like a weapon on that table.", ���� ���
            ShowMenuUI(sequence);
            line03.Play();

            //1�� ������
            yield return new WaitForSeconds(2f);

            //ȭ��ǥ Ȱ��ȭ
            theArrow.SetActive(true);

            //1�� ������
            yield return new WaitForSeconds(1f);

            //�ʱ�ȭ
            HideMenuUI();

            //�÷��� ĳ���� Ȱ��ȭ(�ٽ� �÷���)
            locomotion.SetActive(true);

            //Ʈ���� �浹ü ��Ȱ��ȭ - ų
            Destroy(gameObject);
            //transform.GetComponent<BoxCollider>().enabled = false;
        }
    }
}