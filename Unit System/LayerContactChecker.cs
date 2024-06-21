using UnityEngine;

namespace LancyStudio.Platformer2D
{
    public abstract class LayerContactChecker : MonoBehaviour
    {
        [Header("Параметры")]
        [SerializeField] protected LayerMask collisionLayer = 0;

        [SerializeField]
        [Tooltip("Смещение точки проверки соприкосновения объекта со слоем")]
        protected Vector3 offset = Vector2.zero;

        /// <summary>
        /// Свойство, которое возвращает позицию точки проверки коллизии transform.position со смещением offset
        /// </summary>
        protected Vector3 Pos
        {
            get => new Vector3(
                transform.position.x + offset.x,
                transform.position.y + offset.y,
                transform.position.z + offset.z
            );
        }

        public abstract bool IsContactedWithLayer();
    }
}