using GAD213.P1.MovementSystem;
using UnityEngine;

namespace GAD213.P2.InteractionSystem
{
    public class AttackController : MonoBehaviour
    {
        #region Variables

        [Header("Animations")]

        [Space(10)]

        private float attackWeakLowDuration;

        bool performed = false;

        [SerializeField] private AnimationClip _attackWeakLowAnimation;

        [Header("Scripts")]

        [Space(10)]

        [SerializeField] private FightingManager _fightingManager;

        [SerializeField] private FightingAnimationController _animationController;

        #endregion

        #region Methods

        public void AttackWeakLow()
        {
            Debug.Log("We ahve used our Low Weak Attack!");
            
            _animationController.ToggleAttackWeakLowState();

            //performed = true;
        }

        //void Duration()
        //{
        //    if (performed)
        //    {
        //        if (attackWeakLowDuration > 0)
        //        {
        //            attackWeakLowDuration -= Time.deltaTime;

        //            if (attackWeakLowDuration <= 0)
        //            {
        //                _fightingManager.IsAttacking = false;

        //                SetAttackDurations();

        //                performed = false;
        //            }
        //        }
        //    }
        //}

        //private void SetAttackDurations()
        //{
        //    attackWeakLowDuration = _attackWeakLowAnimation.length * 2;
        //}

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //SetAttackDurations();
        }

        // Update is called once per frame
        void Update()
        {
            //Duration();
        }

        #endregion
    }
}