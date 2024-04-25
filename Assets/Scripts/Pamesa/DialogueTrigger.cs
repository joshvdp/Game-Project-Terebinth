using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DialogueSystem
{
    public enum UIPlatformType
    {
        PC,
        Mobile
    }
    public class DialogueTrigger : MonoBehaviour
    {
        public UIPlatformType PlatformType;

        public GameObject[] colliderArray;

        private bool allMarksVisited = false;


        int index;
        [SerializeField] private GameObject Map_HP, Potions, Weapons, Inventory_Button, Start, Low_Health, Halfway, Vases, Cannons, Puzzle, End, IsFinished;
        

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.name == "Moveable Box")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 0;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }
            }

            if (collision.collider.name == "Dialogue Collider")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 2;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }
                
                //dialogueCollider.SetActive(false);
            }

            

            if (collision.collider.name == "Dialogue Collider (Map_HP)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 3;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Map_HP.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (Potions)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 4;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Potions.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (Weapons)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 5;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Weapons.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (Inventory Button)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 6;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Inventory_Button.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (Start)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 8;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Start.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (Low_Health)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 9;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Low_Health.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (Halfway)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 10;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Halfway.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (Vases)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 11;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Vases.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (Cannons)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 12;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Cannons.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (Puzzle)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 13;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                Puzzle.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (End)")
            {
                switch (PlatformType)
                {
                    case UIPlatformType.PC:
                        index = 1;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                    case UIPlatformType.Mobile:
                        index = 14;
                        DialogueHandler.Instance.EnableDialogue(index);
                        break;
                }

                End.SetActive(false);
            }

            if (collision.collider.name == "Dialogue Collider (IsFinished)")
            {
                if (!allMarksVisited)
                {
                    switch (PlatformType)
                    {
                        case UIPlatformType.PC:
                            index = 1;
                            DialogueHandler.Instance.EnableDialogue(index);
                            break;
                        case UIPlatformType.Mobile:
                            index = 15;
                            DialogueHandler.Instance.EnableDialogue(index);
                            break;
                    }
                }
                else
                {
                    IsFinished.SetActive(false);
                }
            }
        }
        private void Update()
        {
            if (!allMarksVisited)
            {
                allMarksVisited = CheckAllMarksVisited();
            }
        }
        bool CheckAllMarksVisited()
        {
            foreach (GameObject collider in colliderArray)
            {
                if (collider.activeSelf)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

