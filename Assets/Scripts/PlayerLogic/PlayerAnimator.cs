using Sirenix.OdinInspector;
using UnityEngine;

namespace PlayerLogic
{
    public class PlayerAnimator: MonoBehaviour
    {
        [SerializeField][ChildGameObjectsOnly(IncludeSelf = true)]
        private Animator _animator;
        
        
    }
}