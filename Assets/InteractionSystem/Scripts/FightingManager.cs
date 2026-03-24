using UnityEngine;

namespace GAD213.P2.InteractionSystem
{
    public class FightingManager : MonoBehaviour
    {
        #region Variables

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
                _attackController.AttackWeakLow();
            }
        }

        #endregion

        #region Unity Methods

        // Update is called once per frame
        void Update()
        {
            CallAttackWeakLow();
        }

        #endregion
    }
}