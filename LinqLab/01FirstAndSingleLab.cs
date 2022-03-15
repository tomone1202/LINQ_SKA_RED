using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
   public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample 搜尋UserName等於demo的資料使用First()
        {
            Sample result = Source.First(p=>p.UserName=="demo");
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用FirstOrDefault()
        {
            Sample result= Source.FirstOrDefault(p=>p.UserName=="skilltree");
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用First()
        {
            Sample result = Source.First(p => p.UserName == "skilltree");
            return result;
        }

        public Sample 搜尋UserName等於demo的資料使用Single()
        {
            Sample result = Source.Single(p => p.UserName == "demo");
            return result;
        }

        public Sample 搜尋UserName等於bill的資料使用Single()
        {
            Sample result = Source.Single(p => p.UserName == "bill");
            return result;
        }
        public Sample 搜尋UserName等於bill的資料使用SingleOrDefault()
        {
            Sample result = Source.SingleOrDefault(p => p.UserName == "bill");
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用SingleOrDefault()
        {
            Sample result = Source.SingleOrDefault(p => p.UserName == "skilltree");
            return result;
        }
    }
}
