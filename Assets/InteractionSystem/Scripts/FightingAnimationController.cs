using UnityEngine;

namespace GAD213.P2.InteractionSystem
{
    public class FightingAnimationController : MonoBehaviour
    {
        #region Variables

        [Header("Components")]

        [SerializeField] private Animator _playerAnimator;

        // === ANIMATION STATES ===

        // Our const int values start at 5 as our MovementSystem animation uses these in the Animator
        // that begin from 0 and end at 4. Starting at 0 here would cause a mixup in the Animator when
        // it is checking which state it should transition to

        private const int _attackWeakLowState = 5;

        #endregion

        #region Methods

        public void ToggleAttackWeakLowState()
        {
            _playerAnimator.SetInteger("currentAnimationState", _attackWeakLowState);
        }

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        #endregion
    }
}