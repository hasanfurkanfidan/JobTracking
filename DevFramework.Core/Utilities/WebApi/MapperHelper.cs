using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Utilities.WebApi
{
   public class MapperHelper
    {
        public static T MapToSameType<T>(T entity)
        {
            Mapper.Initialize(p =>
            {
                p.CreateMap<T, T>();
            });
            T result = Mapper.Map<T, T>(entity);
            return result;

        }
    }
}
