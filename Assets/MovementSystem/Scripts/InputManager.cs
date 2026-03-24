using UnityEditor.VersionControl;
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

        // === INPUT DEVICES ===

        private InputDevice _inputDeviceGamepad;

        private const int _usingGamepad = 0;

        private InputDevice _inputDeviceKeyboard;

        private const int _usingKeyboard = 1;

        #endregion

        #region Methods
        
        public Vector2 GetMoveValue()
        {
            Debug.Log(_inputActionMove.ReadValue<Vector2>());

            // If we are using the controller, we return this
            return _inputActionMove.ReadValue<Vector2>();

            // otherwise, return values related to what buttons we have pressed on our keyboard
        }

        /// <summary>
        /// Our other methods call this to check whether the player is using a keyboard or controller.
        /// We want to return one of the const int values to represent one of these options
        /// </summary>
        /// <returns></returns>
        public int InputDeviceUsed() 
        {
            if (_inputDeviceGamepad.wasUpdatedThisFrame)
            {
                Debug.Log("We are using the Gamepad!");
                return _usingGamepad;
            }
            else if (_inputDeviceKeyboard.wasUpdatedThisFrame)
            {
                Debug.Log("We are using the keyboard!");
                return _usingKeyboard;
            }
            else
            {
                return 1;
            }

        }

        private void InitializeInputActions()
        {
            _inputActionMap = _inputActionAsset.FindActionMap("MovementSystem");

            _inputActionMove = _inputActionMap.FindAction("Move");

            InputDevice[] devices = new InputDevice[] { InputSystem.AddDevice<Gamepad>(), InputSystem.AddDevice<Keyboard>() };

            _inputActionAsset.devices = devices;

            _inputDeviceGamepad = devices[0];
            _inputDeviceKeyboard = devices[1];
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