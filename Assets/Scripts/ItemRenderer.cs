using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Tidag
{
    public class ItemRenderer : MonoBehaviour
    {
        private Image image;
        private TextMeshProUGUI textmesh;
        
        // Start is called before the first frame update
        void Start()
        {
            image = GetComponentInChildren<Image>();
            textmesh = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void SetItem(Item item)
        {
            image.sprite = item.Sprite;
            textmesh.SetText(item.Name);
        }
        
        
        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
