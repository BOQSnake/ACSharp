using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssasinsCreed
{
    public class 시민1
    {
        int 체력;
        int 공격력;
        String 직업;
        public 시민1()
        {
            Console.WriteLine("시민:시민 생성됐습니다!");
            체력 = 100;
            공격력 = 0;
            직업 = "바예크스토커";

        }

        public void 오늘도_바예크를_호출해서_부탁해야지_여보시오_메자이()
        {
            Console.WriteLine("메자이를 호출해서 귀찮게 했습니다.");
        }
    }
}
