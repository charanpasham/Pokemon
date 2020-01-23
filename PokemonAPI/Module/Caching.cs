using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;

namespace PokemonAPI.Module
{
    public static class CacheManager<T>
    {
        // declare the data structure to store it in cache.
        private static MemoryCache _cached = new MemoryCache(new MemoryCacheOptions()
        {
            SizeLimit = 1024
        });

        public static async Task<T> HttpGet(int key, Func<Task<T>> createItem)
        {
            if (!_cached.TryGetValue(key, out T cacheEntry)) {

                // Execute the API call.
                cacheEntry =  await createItem();


                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // Set cache entry size by extension method.
                    .SetSize(1);
             

                // Save data in cache
                _cached.Set(key, cacheEntry, cacheEntryOptions);
                
            }
            return cacheEntry;
        }

    }
}
