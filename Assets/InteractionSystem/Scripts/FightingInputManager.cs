using UnityEngine;
using UnityEngine.InputSystem;

namespace GAD213.P2.InteractionSystem
{
    public class FightingInputManager : MonoBehaviour
    {
        #region Variables

        [Header("<b>Input System</b>")]

        [Space(15)]

        [SerializeField] private PlayerInput _playerInput;

        [SerializeField] private InputActionAsset _inputActionAsset; // Need to initialise seperatley as will throw an error in OnEnable otherwise

        private InputActionMap _inputActionMap;

        // === INPUT ACTIONS ===

        private InputAction _inputActionMove;

        private InputAction _inputActionAttackWeakLow;

        // === INPUT DEVICES ===

        private const int _usingGamepad = 0;

        private const int _usingKeyboard = 1;

        #endregion

        #region Methods

        /// <summary>
        /// Called in FightingManager, which determines whether AttackController runs functionality
        /// for attack
        /// </summary>
        /// <returns></returns>
        public bool AttackWeakLowPerformed()
        {
            switch (_inputActionAttackWeakLow.WasPerformedThisFrame())
            {
                case true:
                    return true;
                case false:
                    return false;
            }
        }

        private void InitializeInputActions()
        {
            _inputActionMap = _inputActionAsset.FindActionMap("Fighting");

            _inputActionMove = _inputActionMap.FindAction("Move");

            _inputActionAttackWeakLow = _inputActionMap.FindAction("Attack Weak Low");
        }

        #endregion

        #region Unity Methods

        void Start()
        {
            InitializeInputActions();
        }

        private void OnEnable()
        {
            _inputActionAsset.Enable();
        }

        private void OnDisable()
        {
            _inputActionAsset.Disable();
        }

        #endregion
    }
}