using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Helpers
{
    public class ModelMapper<T, S> where T : class where S : class
    {
        public async Task<S> ConvertModelToApp(T sourceClass)
        {
            return Mapper.Map<T, S>(sourceClass);
        }

        public async Task<T> ConvertModelToRepo(S sourceClass)
        {
            return Mapper.Map<S, T>(sourceClass);
        }

        public async Task<T> ConvertAppToRepo(S sourceList)
        {
            return Mapper.Map<S, T>(sourceList);
        }

        public async Task<S> ConvertRepoToApp(T sourceList)
        {
            return Mapper.Map<T, S>(sourceList);
        }
    }
}
