using UnityEngine;

public class Player : MonoBehaviour
{
    // 單行註解 2020.07.04 Alan
    //說明:

    /*多行註解
     * 
     * 
     * 
     * */

     #region 欄位區域

    // 命名規則
    // 1.具有意義的名稱
    // 2.不要使用數字開頭
    // 3.不要使用特殊符號包含:@#/*空格
    // 4.可以使用中文

    // 欄位語法
    // 類型 欄位名稱 = 值;
    // 沒有 = 值;
    // 整數、浮點數 預設值 0
    // 字串 預設值 ""
    // 布林值 false


    // 私人 private - 僅限於此類別使用 | 不會顯示 - 預設值
    // 公開 public - 所有類別皆可使用  | 會顯示

    // 欄位屬性 [屬性名稱()]
    // 標題 Header
    // 提示 ToolTip
    // 範圍 Range

    public int speed = 50;
    public float hp = 999.9f;
    public int coin;
    public int height = 500;
    public AudioClip soundJump;
    public AudioClip soundSlide;
    public AudioClip soundhit;
    public bool dead;

    #endregion
     #region 方法區域

    // C# 括號符號都是成對出現的()[]{}
    // 概要:方法的說明
    // 在方法上面添加三條/
    // 自訂方法 - 不會執行，需要呼叫
    // API - 功能倉庫
    //


    /// <summary>
    /// 角色跳躍:跳躍動畫、音效和動作(往上跳)
    /// </summary>
    private void Jump()
    {
        print("跳躍");
    }

    /// <summary>
    /// 角色滑行:滑行動畫、音效和縮小碰撞範圍
    /// </summary>
    private void Slide()
    {
        print("滑行");
    }

    /// <summary>
    /// 角色碰撞:碰到障礙物會扣血
    /// </summary>
    private void Hit()
    {

    }

    /// <summary>
    /// 吃金幣:金幣數量增加、更新介面及音效
    /// </summary>
    private void EatCoin()
    {

    }

    /// <summary>
    /// 角色死亡:動畫及遊戲結束
    /// </summary>
    private void Dead()
    {

    }
    #endregion
    #region 事件區域
    // 開始 Start
    // 遊戲開始時執行一次

    private void Start()
    {
        // 呼叫跳躍方法
        Jump();
    }
    // 更新 Update
    // 播放遊戲一秒執行約60次 - 60FPS
    // 移動、監聽玩家滑鼠、鍵盤與觸控
    private void Update()
    {
        Slide();
    }
    #endregion

}
