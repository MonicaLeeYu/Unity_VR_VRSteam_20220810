using TMPro;
using UnityEngine;

namespace MonicaLee
{
    /// <summary>
    /// 分數管理
    /// </summary>
    public class ScoreManager : MonoBehaviour
    {
        public static int addScore = 2;

        private string nameBasketball = "籃球";
        private TextMeshProUGUI textScore;        
        private int totalScore;

        private void Awake()
        {
            textScore = GameObject.Find("分數").GetComponent<TextMeshProUGUI>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameBasketball))
            {
                AddScore();
            }
        }
        private void AddScore()
        {
            totalScore += addScore;
            textScore.text = "SCORE " + totalScore;
        }
        /// <summary>
        /// 變更分數
        /// </summary>
        /// <param name="scoreToChange">要變更的分數</param>
        private void ChangeScore(int scoreToChange)
        {
            addScore = scoreToChange;
        }

        
    }
}

