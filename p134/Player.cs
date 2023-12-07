using System;
using System.Collections.Generic;
using System.Text;

namespace SampleRPG
{
    class Player
    {
        //プレイヤー情報(プライベート)
        private string name;

        private int hp;
        //パブリックで、コンストラクタ(メンバ変数決め)と、メンバメソッドぷを入力
        public Player(string name,int hp)
        {
            this.name = name; //初期値をこっちが指定に
            this.hp = hp;     //　　　（同じく）
        }


        //hpについて、約束を付けて-3902hpとかにしないようにする

        //hp変数に値を代入

        public void Setup(int hp)
        {
            this.hp = hp;
            if(this.hp < 0)
            {
                this.hp = 0;
            }


        } 

        public void Setname(string name)
        
        {
            this.name = name;
            int LONG = name.Length;
            if(LONG <= 8 )
            {
                this.name = name;
            }
        }

        public int Gethp()
        {
            return this.hp;

        }

        public string Getname()
        {
            return this.name;
        }


        //攻撃メソッド
        public void attack()
        {
            Console.WriteLine(this.name + "は攻撃した。");
        }
        //防御メソッド
        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した。");
        }
    }
}