using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssasinsCreed
{
    public class 바예크
    {
        Random random = new Random();
        int 체력;
        int 공격력;
        String 직업; 

        public 바예크()
        {

            Console.WriteLine("바예크:바예크 생성됨~!\n");
           체력 = 300;
           공격력 = 100;
           직업 = "마스터 암살자";
        }

        public void 암살하기()
        {
            int randomNumber = random.Next(0,5);
            if(randomNumber == 3)
            {
                Console.WriteLine("암살성공했습니다! \n");
            }
            else
            {
                Console.WriteLine("아 ㅅㅂ 이새끼 토꼈음");
            }
        }



        public void 마누라랑놀기()
        {
            Console.WriteLine("잘놀았습니다! \n");
        }

    }
}
