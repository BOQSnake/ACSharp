using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssasinsCreed
{
    class 맵 
    {
       
        static void Main(string[] args)
        {
            바예크 bayek = new 바예크();  //바예크 생성
            시민1 citizen = new 시민1(); //시민1 생성
            암살대상_겁나나쁜놈 target = new 암살대상_겁나나쁜놈(); //암살대상 생성



            target.시민들한테돈뜯기();  //암살대상한테 "시민들한테돈뜯기" 시키기
            bayek.암살하기(); //바예크한테 "암살하기" 시키기

        }
    }
}
