using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.LeetCode.Tests
{
    [TestClass]
    public class LeetCode0146Tests
    {
        [TestMethod]
        public void LRUCacheTest1()
        {
            var inputs = new (string Action, int[] Param)[]
            {
                ("put", new[] { 1, 1 }),
                ("put", new[] { 2, 2 }),
                ("get", new[] { 1 }),
                ("put", new[] { 3, 3 }),
                ("get", new[] { 2 }),
                ("put", new[] { 4, 4 }),
                ("get", new[] { 1 }),
                ("get", new[] { 3 }),
                ("get", new[] { 4 }),
            };
            var expected = new int?[] { null, null, 1, null, -1, null, -1, 3, 4 };
            var actual = Execute(inputs);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LRUCacheTest2()
        {
            var inputs = new (string Action, int[] Param)[]
            {
                ("put", new[] { 2, 1 }),
                ("put", new[] { 2, 2 }),
                ("get", new[] { 2 }),
                ("put", new[] { 1, 1 }),
                ("put", new[] { 4, 1 }),
                ("get", new[] { 2 }),
            };
            var expected = new int?[] { null, null, 2, null, null, -1 };
            var actual = Execute(inputs);

            CollectionAssert.AreEqual(expected, actual);
        }

        private int?[] Execute((string Action, int[] Param)[] inputs)
        {
            var result = new int?[inputs.Length];
            var cache = new LRUCache(2);

            for (var i = 0; i < inputs.Length; i++)
            {
                var input = inputs[i];
                if (input.Action == "put")
                {
                    cache.Put(input.Param[0], input.Param[1]);
                    result[i] = null;
                }
                else if (input.Action == "get")
                {
                    result[i] = cache.Get(input.Param[0]);
                }
            }

            return result;
        }
    }
}