using UnityEngine;

namespace Tidag
{
    [CreateAssetMenu(fileName = "NewItem",menuName = "Item")]
    public class Item : ScriptableObject
    {
        public string Name;
        public Sprite Sprite;
    }
}