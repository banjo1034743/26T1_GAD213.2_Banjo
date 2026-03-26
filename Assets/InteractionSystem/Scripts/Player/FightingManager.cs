using GAD213.P1.MovementSystem;
using UnityEngine;

namespace GAD213.P2.InteractionSystem
{
    public class FightingManager : MonoBehaviour
    {
        #region Variables

        // === VARIABLES ===

        public bool IsAttacking { get { return _isAttacking; } set { _isAttacking = value; } }

        [SerializeField] private bool _isAttacking = false;

        [Header("Scripts")]

        [Space(10)]

        [SerializeField] private FightingInputManager _inputManager;

        [SerializeField] private AttackController _attackController;

        #endregion

        #region Methods

        private void CallAttackWeakLow()
        {
            if (_inputManager.AttackWeakLowPerformed() == true)
            {
                _isAttacking = true;
                _attackController.AttackWeakLow();
            }
        }

        private void CheckIfNotAttacking()
        {
            if (_inputManager.AttackWeakLowPerformed() == false)
            {
                _isAttacking = false;
            }
        }

        #endregion

        #region Unity Methods

        // Update is called once per frame
        void Update()
        {
            CallAttackWeakLow();

            //CheckIfNotAttacking();
        }

        #endregion
    }
}