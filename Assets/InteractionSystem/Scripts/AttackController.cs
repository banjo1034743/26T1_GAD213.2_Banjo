using UnityEngine;

namespace GAD213.P2.InteractionSystem
{
    public class AttackController : MonoBehaviour
    {
        #region Variables

        [Header("Scripts")]

        [SerializeField] private FightingAnimationController _animationController;

        #endregion

        #region Methods

        public void AttackWeakLow()
        {
            Debug.Log("We ahve used our Low Weak Attack!");

            _animationController.ToggleAttackWeakLowState();
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