using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bnaya.Samples
{
    public class Query
    {
        private static readonly Random _rnd = new ();

        public IQueryable<Blog> Blogs() =>
            Enumerable.Range(0, 100)
                        .Select(i => new Blog(i, $"Blog {i}",
                            Enumerable.Range(0, _rnd.Next(10, 200))
                                    .Select(j => new Post(
                                        j,
                                        $"Post {i}-{j}",
                                        $"some content of the post {i}: {j}"))
                                        .ToArray())).AsQueryable<Blog>();
    }
}
