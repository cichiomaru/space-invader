using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SpaceInvader.Menu {
    public class ScoreUI : BaseMenu {
        private DataController dataManager;

        public TMP_Text score1;
        public TMP_Text score2;
        public TMP_Text highscore;

        private void Awake() {
            dataManager = FindObjectOfType<DataController>();
        }
        private void Start() {
            SetHighScore(dataManager.data.highscore);
        }

        public void SetHighScore(int _highscore) {
            highscore.text = _highscore.ToString("0000");
        }
        public void SetScore1(int _score1) {
            score1.text = _score1.ToString("0000");
        }
    } 
}
