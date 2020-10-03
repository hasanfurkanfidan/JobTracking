using DevFramework.Core.CrossCuttingConcerns.Cachings;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Aspects.PostSharp.CacheAspect
{
    [Serializable]
    public class CacheRemoveAspect:OnMethodBoundaryAspect
    {
        string _pattern;
        Type _cacheType;
        ICacheManager _cacheManager;
        public CacheRemoveAspect(Type cacheType)
        {
            _cacheType = cacheType;
        }
        public CacheRemoveAspect(string pattern, Type cacheType)
        {
            _cacheType = cacheType;
            _pattern = pattern;
        }
        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType))
            {
                throw new Exception("Wrong Cache Manager");

            }
            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);
        }
        public override void OnSuccess(MethodExecutionArgs args)
        {
            _cacheManager.RemoveByPattern(string.IsNullOrEmpty(_pattern) ? string.Format($"{0}.{1}.*", args.Method.ReflectedType.Namespace, args.Method.ReflectedType.Name):_pattern);


        }
    }
}
