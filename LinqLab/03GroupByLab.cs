﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{

    public class GroupByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public GroupByLab()
        {
            Source = new SampleDate().GetData();
        }
        public IList<IGrouping<string, Sample>> 使用UserName作為群組依據()
        {
            var result = Source.GroupBy(x => x.UserName).ToList();


            return result;
        }

        public IEnumerable<IGrouping<TempObj, Sample>> 使用UserName和CreateTime作為群組依據()
        {
            var result = Source.GroupBy(x => new TempObj() { UserName= x.UserName,CreateTime = x.CreateTime}).ToList();
            return result;
        }
    }
}
