using UnityEngine;

namespace DebugScripts
{
    public class SpawnDebugArea: MonoBehaviour
    {
        [SerializeField][Min(0.5f)] private float _radius;
        
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(transform.position, _radius);
        }
    }
}