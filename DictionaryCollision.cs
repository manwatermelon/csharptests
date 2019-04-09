using System.Collections.Generic;

namespace csharptest {
    public static class DictionaryCollision {
        public static int Collisions(long n) {
            Dictionary<long, string> tmp = new Dictionary<long, string>();
            List<string> collisions = new List<string>();
            for (long i = 0; i < n; i++) {
                string value = i.ToString();
                long hash = value.GetHashCode();
                if (tmp.TryGetValue(hash, out string collision)) {
                    collisions.Add(collision);
                    collisions.Add(value);
                } else {
                    tmp.Add(hash, value);
                }
            }
            return collisions.Count;
        }
    }
}