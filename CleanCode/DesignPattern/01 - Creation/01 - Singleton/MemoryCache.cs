using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Singleton
{
    //Est critiqué car il viole le principe S mais en passant par un moteur
    //  d'injection de dépendances 
    public sealed class MemoryCache
    {
        //Lazy permet de créer l'objet quand on en a vraiment besoin
        private static Lazy<MemoryCache> _cache = new(()=>new MemoryCache());
        public static MemoryCache Instance => _cache.Value;

        private Dictionary<string, object> _cachedObject;


        //Pour ne pas que les autres puissent redéfinir la classe on doit mêtre
        //  la classe en "sealed" et ctor privé

        //Si on autorise les autres à redéfinir la classe on enlève le "sealed"
        //  de la classe et ctor protected
        private MemoryCache()
        {
            _cachedObject = new();
        }
        public void Add(string key, object value) => _cachedObject[key] = value;

        public object? Get(string key)
        {
            if(_cachedObject.ContainsKey(key)) return _cachedObject[key];
            return null;
        }
    }
}
