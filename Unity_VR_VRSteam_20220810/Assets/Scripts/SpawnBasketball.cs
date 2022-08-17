using UnityEngine;
using Valve.VR.InteractionSystem;

namespace MonicaLee
{
    public class SpawnBasketball : MonoBehaviour
    {
        [SerializeField, Header("�x�y�w�s��")]
        private GameObject goBasketball;

        private UIElement btnSpawnBasketball;
        private Transform traPlayer;

        private void Awake()
        {
            traPlayer = GameObject.Find("Player").transform;
            btnSpawnBasketball = GameObject.Find("�ͦ��s�x�y").GetComponent<UIElement>();

            btnSpawnBasketball.onHandClick.AddListener((x) =>
            {
            Vector3 posBall = traPlayer.position + traPlayer.forward * 0.8f + traPlayer.up;
            Instantiate(goBasketball, posBall, Quaternion.identity); });
        }
    }
}

