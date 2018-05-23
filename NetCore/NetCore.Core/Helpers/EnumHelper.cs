using System;
using System.Collections.Generic;
using System.Linq;
namespace NetCore.Core
{
    public class EnumHelper
    {
        public static List<T> GetList<T>(){
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
        }
    }
}