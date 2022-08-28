using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IShopCustomer
{
    [SerializeField] private int initSpeed;
    [SerializeField] public  int speed;
    [SerializeField] private int initGold;
    [SerializeField] private int gold;

    private Animator _animator;
    private Rigidbody2D _rb;
    private Vector2 movement;

    public Inventory _inventory;

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
        _inventory.AddItemToInventory(itemType);
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

    public void ChangeItems()
    {
        var items = _inventory.GetEquipedItems();
        var outfit = Item.ItemType.WhiteShirt;
        var accessory = Item.ItemType.NoAccessory;

        foreach(Item.ItemType item in items)
        {
            //grab the items by their label
            if (Item.GetLabel(item) == "Outfit") outfit = item;
            if (Item.GetLabel(item) == "Accessory") accessory = item;
        }



    }
}
