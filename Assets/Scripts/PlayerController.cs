using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IShopCustomer, IPlayerInventory
{
    [SerializeField] private int initSpeed;
    [SerializeField] public  int speed;
    [SerializeField] private int initGold;
    [SerializeField] private int gold;

    private Animator _animator;
    private Rigidbody2D _rb;
    private Vector2 movement;

    //public Inventory _inventory;
    private List<Item.ItemType> _items = new List<Item.ItemType>();
    private List<Item.ItemType> equipedItems = new List<Item.ItemType>(2);
    private int yellowFlowers;
    private int orangeFlowers;
    private int redFlowers;

    private string animationName = "Default";

    private void Awake()
    {
        Cursor.visible = false;
    }

    void Start()
    {
        gold = initGold;
        speed = initSpeed;
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();

        _items.Add(Item.ItemType.WhiteShirt);
        _items.Add(Item.ItemType.NoAccessory);
        equipedItems.Add(Item.ItemType.WhiteShirt);
        equipedItems.Add(Item.ItemType.NoAccessory);
    }

    private void Update()
    {
        //handle inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //trigger animations
        _animator.SetFloat("Horizontal", movement.x);
        _animator.SetFloat("Vertical", movement.y);
        _animator.SetFloat("Speed", movement.sqrMagnitude);
    }


    void FixedUpdate()
    {
        //move the character
        transform.position += new Vector3(movement.x, movement.y) * speed * Time.deltaTime;
    }

    //used to change the character's sprites 
    private void LateUpdate()
    {
    }

    public void BoughtItem(Item.ItemType itemType)
    {
        _items.Add(itemType);
    }

    public bool TrySpendGold(int spendGoldAmount)
    {
        if(gold > spendGoldAmount)
        {
            gold -= spendGoldAmount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Item.ItemType> GetInventoryItems()
    {
        return _items;
    }

    public List<Item.ItemType> GetEquipedItems()
    {
        return equipedItems;
    }

    public void EquipItem(Item.ItemType itemToEquip)
    {
        foreach (Item.ItemType item in equipedItems)
        {
            //the player can only have 2 items, 1 outfit (shirt) and 1 accessory (headpiece)
            if (Item.GetLabel(item) == Item.GetLabel(itemToEquip))
            {
                equipedItems.Remove(item);
                equipedItems.Add(itemToEquip);
                UpdateAnimations();
            }
            else if (equipedItems.Count < 2)
            {
                equipedItems.Add(itemToEquip);
            }
        }
        UpdateAnimations();
    }

    private void UpdateAnimations()
    {
        Item.ItemType accessory = Item.ItemType.NoAccessory;
        Item.ItemType outfit = Item.ItemType.WhiteShirt;

        int shirt = 0;
        int hat = 0;

        foreach (Item.ItemType item in equipedItems)
        {
            //the player can only have 2 items, 1 outfit (shirt) and 1 accessory (headpiece)
            if (Item.GetLabel(item) == "Accessory")
            {
                accessory = item;
            }
            else if(Item.GetLabel(item) == "Outfit")
            {
                outfit = item;
            }
        }

        switch (accessory)
        {
            case Item.ItemType.NoAccessory: hat = 0;
                break;
            case Item.ItemType.FlowersCirclet: hat = 4;
                break;
            case Item.ItemType.RedFlowerCirclet: hat = 3;
                break;
            case Item.ItemType.YellowFlowerCirclet: hat = 1;
                break;
            case Item.ItemType.OrangeFlowerCirclet: hat = 2;
                break;
            case Item.ItemType.FarmerHat:
                break;
            default: hat = 0;
                break;
        }

        switch (outfit)
        {
            case Item.ItemType.WhiteShirt: shirt = 0;
                break;
            case Item.ItemType.RedShirt: shirt = 3;
                break;
            case Item.ItemType.YellowShirt: shirt = 1;
                break;
            case Item.ItemType.OrangeShirt: shirt = 2;
                break;
            default: shirt = 0;
                break;
        }

        if (shirt == 0 && hat == 0)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "Default";
        }
        if (shirt == 0 && hat == 1)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "WhiteFlowersY";
        }
        if (shirt == 0 && hat == 2)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "WhiteFlowersO";
        }
        if (shirt == 0 && hat == 3)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "WhiteFlowersR";
        }
        if (shirt == 0 && hat == 4)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "Hat";
        }
        if (shirt == 1 && hat == 0)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "Yellow";
        }
        if (shirt == 1 && hat == 1)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "YellowFlowerY";
        }
        if (shirt == 1 && hat == 2)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "YellowFlowerO";
        }
        if (shirt == 1 && hat == 3)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "YellowFlowerR";
        }
        if (shirt == 1 && hat == 4)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "HatYellow";
        }
        if (shirt == 2 && hat == 0)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "Orange";
        }
        if (shirt == 2 && hat == 1)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "OrangeFlowersY";
        }
        if (shirt == 2 && hat == 2)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "OrangeFlowersO";
        }
        if (shirt == 2 && hat == 3)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "OrangeFlowersR";
        }
        if (shirt == 2 && hat == 4)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "HatOrange";
        }
        if (shirt == 3 && hat == 0)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "Red";
        }
        if (shirt == 3 && hat == 1)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "RedFlowersY";
        }
        if (shirt == 3 && hat == 2)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "RedFlowersO";
        }
        if (shirt == 3 && hat == 3)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "RedFlowersR";
        }
        if (shirt == 3 && hat == 4)
        {
            //disable previous animation bool
            _animator.SetBool(animationName, false);
            //set new animation bool variable name
            animationName = "HatRed";
        }

        _animator.SetBool(animationName, true);
    }

    public void CollectFlower(int flowerType)
    {
        if (flowerType == 0) yellowFlowers++;
        if (flowerType == 1) orangeFlowers++;
        if (flowerType == 2) redFlowers++;
    }

    public void AddGold(int goldAmount)
    {
        gold += goldAmount;
    }
}
