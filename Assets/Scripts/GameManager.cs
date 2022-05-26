using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Tidag
{
    public class GameManager : MonoBehaviour
    {
        public List<Item> items;
        public List<ItemRenderer> itemrenderers;
        public TextMeshProUGUI locationText;
        public TextMeshProUGUI charactersText;
        public Location currentLocation;
        public Location rockland;
        public Location house;
        public void RenderAll()
        {
            for (int i = 0; i < items.Count; i++)
            {
                itemrenderers[i].SetItem(items[i]);
            }

            locationText.SetText(currentLocation.PlaceName);

            string charactertext = "";
            foreach (Character character in currentLocation.characters)
            {
                charactertext += character.displayName;
            }
            charactersText.SetText(charactertext==""?"<No Characters>":charactertext);
        }

        private void Start()
        {
            RenderAll();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (currentLocation == rockland)
                {
                    currentLocation = house;
                }
            }
            
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (currentLocation == house)
                {
                    currentLocation = rockland;
                }
            }

            if (Input.anyKeyDown)
            {
                RenderAll();
            }
        }
    }
}