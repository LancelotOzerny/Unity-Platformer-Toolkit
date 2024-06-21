using UnityEngine;
namespace LancyStudio.Platformer2D
{
    public class LayerContactCheckerSphere : LayerContactChecker
    {
        [SerializeField] private float radius = 1f;

        public override bool IsContactedWithLayer()
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(Pos, radius, collisionLayer);
            return colliders.Length > 0;
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawSphere(Pos, radius);
        }
    }
}