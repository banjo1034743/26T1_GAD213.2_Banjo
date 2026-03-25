using UnityEngine;

namespace GAD213.P2.InteractionSystem
{
    public class AttackCollisionDetector : MonoBehaviour
    {
        #region Variables

        [Header("Attack Name")]

        [Space(10)]

        [Tooltip("Set this to the name in the inspector")]
        [SerializeField] private string _attackName;

        [Header("Tags to read for")]

        [Space(10)]

        [Tooltip("Set this to the current tag of dummy in the inspector")]
        [SerializeField] private string _testDummyTag;

        [Header("Scripts")]

        [Space(10)]

        [Tooltip("Initialise in the inspector")]
        [SerializeField] private AttackController _attackController;

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.CompareTag(_testDummyTag) == true)
            {
                _attackController.DealDamage(_attackName);
            }
        }

        #endregion
    }
}