using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("男子")]
   public Transform man;
    [Header("殭屍")]
   public Transform zombie;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"), Range(0.5f, 10f)]
    public float turn = 1.3f;
    [Header("縮放"), Range(0f, 3f)]
    public float size = 0.5f;
    [Header("男子動畫元件")]
    public Animator animan;
    [Header("殭屍動畫元件")]
    public Animator anizombie;

    private void Start()
    {
        print("開始事件執行中");
    }

  //  public float test = 1;



    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        man.Rotate(0, joystick.Horizontal * turn, 0);
        zombie.Rotate(0, joystick.Horizontal * turn, 0);

        man.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        man.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(man.localScale.x, 0.7f, 3f);

        zombie.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        zombie.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(man.localScale.x, 0.7f, 3f);

       

      // test= Mathf.Clamp(test, 0.5f, 5f);
    }
        public void Attack()
        {
            print("死亡");
        animan.SetTrigger("死亡");
        anizombie.SetTrigger("死亡");

        }
    public void run()
    {
        print("跑步");
        animan.SetTrigger("跑步");
        anizombie.SetTrigger("跑步");

    }





}
