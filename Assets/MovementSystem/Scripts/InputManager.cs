using UnityEngine;
using UnityEngine.InputSystem;

namespace GAD213.P1.MovementSystem
{
    public class InputManager : MonoBehaviour
    {
        #region Variables

        [Header("Input System")]

        [SerializeField] private InputActionAsset _inputActionAsset;

        private InputActionMap _inputActionMap;

        // === INPUT ACTIONS ===

        private InputAction _inputActionMove;

        #endregion

        #region Methods
        
        public Vector2 GetMoveValue()
        {
            //Debug.Log(_inputActionMove.ReadValue<Vector2>());

            // If we are using the controller, we return this
            return _inputActionMove.ReadValue<Vector2>();

            // otherwise, return values related to what buttons we have pressed on our keyboard
        }

        /// <summary>
        /// Our other methods call this to check whether the player is using a keyboard or controller.
        /// We want to return one of the const int values to represent one of these options
        /// </summary>
        /// <returns></returns>
        public int ControlSchemeUsed() 
        {
            return 0;
        }

        private void InitializeInputActions()
        {
            _inputActionMap = _inputActionAsset.FindActionMap("MovementSystem");

            _inputActionMove = _inputActionMap.FindAction("Move");
        }

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
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