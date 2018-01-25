using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssasinsCreed
{
    public class 암살대상_겁나나쁜놈
    {
        int 체력;
        int 공격력;
        String 직업;
        public 암살대상_겁나나쁜놈()
        {
            Console.WriteLine("암살대상_겁나나쁜놈:암살대상 생성됐어 ㅅㅂ 개발자새꺄\n");
            체력 = 300;
            공격력 = 150;

            직업 = "비리많은성직자";
        }

        public void 시민들한테돈뜯기()
        {
            Console.WriteLine("시민들한테 돈을 뜯었습니다. \n");
        }
    }
}
