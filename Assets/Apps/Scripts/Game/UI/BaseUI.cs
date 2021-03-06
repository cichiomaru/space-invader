using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Game.UI {
    public abstract class BaseUI : MonoBehaviour {
        protected GameManager gameManager;

        protected void Awake() {
            gameManager = FindObjectOfType<GameManager>();
        }
        public void Hide() {
            gameObject.SetActive(false);
        }

        public void Show() {
            gameObject.SetActive(true);
        }
    } 
}
