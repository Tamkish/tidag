using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tidag
{
    [CreateAssetMenu]
    public class Location : ScriptableObject
    {
        public string PlaceName;
        public List<Character> characters;
        public List<Item> items;
        
    }
}
