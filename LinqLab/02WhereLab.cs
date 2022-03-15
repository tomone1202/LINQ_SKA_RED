using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> 搜尋Id大於8的資料()
        {
            var result = Source.Where(x => x.Id > 8);
            return result.ToList();
        }

        public List<Sample> 搜尋Price等於200的資料()
        {

            var result = Source.Where(x => x.Price == 200);
            return result.ToList();
        }

        public List<Sample> 搜尋UserName開頭為d的資料()
        {
            var result = Source.Where(x => x.UserName.StartsWith("d"));
            return result.ToList();
        }

        public List<Sample> 搜尋UserName包含e的資料()
        {
            var result = Source.Where(x => x.UserName.Contains("e"));
            return result.ToList();
        }

        public List<Sample> 搜尋UserName結尾為o的資料()
        {
            var result = Source.Where(x => x.UserName.EndsWith("o"));
            return result.ToList();
        }

        public List<Sample> 搜尋UserName是demo和joey的資料()
        {
            var whereStr = new[] { "demo", "joey" };
            var result = Source.Where(x => whereStr.Contains(x.UserName));
            return result.ToList();
        }

        public bool 判斷是否有Id等於99的資料()
        {

            var result = Source.Any(x => x.Id == 99);
            return result;
        }


        public int SumOfPriceOfOneUser(string username)
        {
            var result = Source.Where(predicate => predicate.UserName.Contains(username));
            return result.Sum(x => x.Price);
        }

        public List<Sample> SampleFromYearMonth(DateTime dateTime)
        {
            var result = Source.Where(predicate => predicate.CreateTime.Year == dateTime.Year && predicate.CreateTime.Month == dateTime.Month).ToList();
            return result;
        }

        public int NumberOfSampleWithIn30Days(DateTime dateTime)
        {
            var result = Source
                .Where(x =>Math.Abs ((dateTime - x.CreateTime).Days) <= 30)
                .Count();
            return result;
        }

        public int NumberOfPeopleHaveItem(int itemId)
        {
            var result = Source
                .Where(predicate =>predicate.Item.Contains(itemId))
                .GroupBy(x => x.UserName)
                .ToList();
            return result.Count;
        }
    }
}
