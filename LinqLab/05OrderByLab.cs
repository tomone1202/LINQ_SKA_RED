using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class OrderByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public OrderByLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> 請使用Id升冪排序()
        {
            var result = Source.OrderBy(comparer => comparer.Id).ToList();
            return result;
        }

        public List<Sample> 請使用Id降冪排序()
        {
            var result = Source.OrderByDescending(comparer => comparer.Id).ToList();
            return result;
        }

        public List<Sample> 請使用Price昇冪排序後再使用Id昇冪排序Test()
        {
            var result = Source.OrderBy(comparer=>comparer.Price).ThenBy(x=>x.Id).ToList();
            return result;
        }
    }
}
