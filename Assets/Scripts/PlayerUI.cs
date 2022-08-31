
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    private PlayerController player;

    public TextMeshProUGUI goldUI;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        goldUI.SetText(player.GetGold().ToString());
    }
}
