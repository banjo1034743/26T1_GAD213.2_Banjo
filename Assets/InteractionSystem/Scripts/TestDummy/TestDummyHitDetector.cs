using UnityEngine;

namespace GAD213.P2.InteractionSystem
{
    public class TestDummyHitDetector : HitDetector
    {
        #region Variables

        [Header("Data")]

        [SerializeField] private string _playerHitboxTag;

        #endregion

        #region Unity Methods

        protected override void OnTriggerEnter2D(Collider2D other)
        {
            if (other.transform.CompareTag(_playerHitboxTag))
            {
                Debug.Log("The player has hit me!");
            }
        }

        #endregion
    }
}