using System.Linq;
using System.Collections.Generic;
using System;
using Components;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Components.Tests
{
    /// <summary>This class contains parameterized unit tests for EnumerableExtension</summary>
    [TestClass]
    [PexClass(typeof(EnumerableExtension))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EnumerableExtensionTest
    {

        /// <summary>Test stub for All(IEnumerable`1&lt;Boolean&gt;)</summary>
        [PexMethod]
        public bool AllTest(IEnumerable<bool> source)
        {
            bool result = EnumerableExtension.All(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.AllTest(IEnumerable`1<Boolean>)
        }

        /// <summary>Test stub for All(IEnumerable`1&lt;!!0&gt;, !!0)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public bool AllTest01<T>(IEnumerable<T> source, T value)
        {
            bool result = EnumerableExtension.All<T>(source, value);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.AllTest01(IEnumerable`1<!!0>, !!0)
        }

        /// <summary>Test stub for AsKeyFor(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,!!1&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, TElement> AsKeyForTest<TKey, TElement>(IEnumerable<TKey> source, Func<TKey, TElement> elementSelector)
        {
            Dictionary<TKey, TElement> result
               = EnumerableExtension.AsKeyFor<TKey, TElement>(source, elementSelector);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.AsKeyForTest(IEnumerable`1<!!0>, Func`2<!!0,!!1>)
        }

        /// <summary>Test stub for AsKeyFor(IEnumerable`1&lt;!!0&gt;, IEnumerable`1&lt;!!1&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, TValue> AsKeyForTest01<TKey, TValue>(IEnumerable<TKey> source, IEnumerable<TValue> second)
        {
            Dictionary<TKey, TValue> result = EnumerableExtension.AsKeyFor<TKey, TValue>(source, second);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.AsKeyForTest01(IEnumerable`1<!!0>, IEnumerable`1<!!1>)
        }

        /// <summary>Test stub for AsyncIter(IEnumerable`1&lt;!!0&gt;, Action`1&lt;!!0&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public void AsyncIterTest<T>(IEnumerable<T> source, Action<T> action)
        {
            EnumerableExtension.AsyncIter<T>(source, action);
            // TODO: add assertions to method EnumerableExtensionTest.AsyncIterTest(IEnumerable`1<!!0>, Action`1<!!0>)
        }

        /// <summary>Test stub for Distinct(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,!!1&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<TSource> DistinctTest<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            IEnumerable<TSource> result = EnumerableExtension.Distinct<TSource, TKey>(source, keySelector);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.DistinctTest(IEnumerable`1<!!0>, Func`2<!!0,!!1>)
        }

        /// <summary>Test stub for DistinctKeys(IEnumerable`1&lt;Dictionary`2&lt;!!0,!!1&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<TKey> DistinctKeysTest<TKey, TElement>(IEnumerable<Dictionary<TKey, TElement>> source)
        {
            IEnumerable<TKey> result = EnumerableExtension.DistinctKeys<TKey, TElement>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.DistinctKeysTest(IEnumerable`1<Dictionary`2<!!0,!!1>>)
        }

        /// <summary>Test stub for Each(IEnumerable`1&lt;!!0&gt;, Action`1&lt;!!0&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> EachTest<T>(IEnumerable<T> source, Action<T> action)
        {
            IEnumerable<T> result = EnumerableExtension.Each<T>(source, action);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.EachTest(IEnumerable`1<!!0>, Action`1<!!0>)
        }

        /// <summary>Test stub for Each(IEnumerable`1&lt;!!0&gt;, Action`2&lt;!!0,Int32&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> EachTest01<T>(IEnumerable<T> source, Action<T, int> action)
        {
            IEnumerable<T> result = EnumerableExtension.Each<T>(source, action);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.EachTest01(IEnumerable`1<!!0>, Action`2<!!0,Int32>)
        }

        /// <summary>Test stub for Except(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<TSource> ExceptTest<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            IEnumerable<TSource> result = EnumerableExtension.Except<TSource>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ExceptTest(IEnumerable`1<!!0>, Func`2<!!0,Boolean>)
        }

        /// <summary>Test stub for ExceptKey(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,!!1&gt;&gt;, Func`2&lt;!!0,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<KeyValuePair<TKey, TSource>> ExceptKeyTest<TKey, TSource>(IEnumerable<KeyValuePair<TKey, TSource>> source, Func<TKey, bool> predicate)
        {
            IEnumerable<KeyValuePair<TKey, TSource>> result
               = EnumerableExtension.ExceptKey<TKey, TSource>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ExceptKeyTest(IEnumerable`1<KeyValuePair`2<!!0,!!1>>, Func`2<!!0,Boolean>)
        }

        /// <summary>Test stub for ExceptKey(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,!!1&gt;&gt;, !!0[])</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<KeyValuePair<TKey, TSource>> ExceptKeyTest01<TKey, TSource>(IEnumerable<KeyValuePair<TKey, TSource>> source, TKey[] keys)
        {
            IEnumerable<KeyValuePair<TKey, TSource>> result
               = EnumerableExtension.ExceptKey<TKey, TSource>(source, keys);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ExceptKeyTest01(IEnumerable`1<KeyValuePair`2<!!0,!!1>>, !!0[])
        }

        /// <summary>Test stub for ExceptNull(IEnumerable`1&lt;!!0&gt;)</summary>
        [PexGenericArguments(typeof(object))]
        [PexMethod]
        public IEnumerable<TSource> ExceptNullTest<TSource>(IEnumerable<TSource> source)
            where TSource : class
        {
            IEnumerable<TSource> result = EnumerableExtension.ExceptNull<TSource>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ExceptNullTest(IEnumerable`1<!!0>)
        }

        /// <summary>Test stub for ExceptNull(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,!!1&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(object))]
        [PexMethod]
        public IEnumerable<TSource> ExceptNullTest01<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
            where TResult : class
        {
            IEnumerable<TSource> result = EnumerableExtension.ExceptNull<TSource, TResult>(source, selector);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ExceptNullTest01(IEnumerable`1<!!0>, Func`2<!!0,!!1>)
        }

        /// <summary>Test stub for For(IEnumerable`1&lt;!!0&gt;, Action`1&lt;!!0&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> ForTest<T>(IEnumerable<T> source, Action<T> action)
        {
            IEnumerable<T> result = EnumerableExtension.For<T>(source, action);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ForTest(IEnumerable`1<!!0>, Action`1<!!0>)
        }

        /// <summary>Test stub for For(IEnumerable`1&lt;!!0&gt;, Action`2&lt;!!0,Int32&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> ForTest01<T>(IEnumerable<T> source, Action<T, int> action)
        {
            IEnumerable<T> result = EnumerableExtension.For<T>(source, action);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ForTest01(IEnumerable`1<!!0>, Action`2<!!0,Int32>)
        }

        /// <summary>Test stub for ForEach(IEnumerable`1&lt;!!0&gt;, Action`1&lt;!!0&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> ForEachTest<T>(IEnumerable<T> source, Action<T> action)
        {
            IEnumerable<T> result = EnumerableExtension.ForEach<T>(source, action);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ForEachTest(IEnumerable`1<!!0>, Action`1<!!0>)
        }

        /// <summary>Test stub for ForEach(IEnumerable`1&lt;!!0&gt;, Action`2&lt;!!0,Int32&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> ForEachTest01<T>(IEnumerable<T> source, Action<T, int> action)
        {
            IEnumerable<T> result = EnumerableExtension.ForEach<T>(source, action);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ForEachTest01(IEnumerable`1<!!0>, Action`2<!!0,Int32>)
        }

        /// <summary>Test stub for GetOrAdd(Dictionary`2&lt;!!0,!!1&gt;, !!0)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public TValue GetOrAddTest<TKey, TValue>(Dictionary<TKey, TValue> d, TKey key)
            where TValue : new()
        {
            TValue result = EnumerableExtension.GetOrAdd<TKey, TValue>(d, key);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GetOrAddTest(Dictionary`2<!!0,!!1>, !!0)
        }

        /// <summary>Test stub for GetOrAdd(Dictionary`2&lt;!!0,!!1&gt;, !!0, !!1)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public TValue GetOrAddTest01<TKey, TValue>(
            Dictionary<TKey, TValue> d,
            TKey key,
            TValue defaultValue
        )
        {
            TValue result = EnumerableExtension.GetOrAdd<TKey, TValue>(d, key, defaultValue);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GetOrAddTest01(Dictionary`2<!!0,!!1>, !!0, !!1)
        }

        /// <summary>Test stub for GetOrAdd(Dictionary`2&lt;!!0,!!1&gt;, !!0, Func`1&lt;!!1&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public TValue GetOrAddTest02<TKey, TValue>(
            Dictionary<TKey, TValue> d,
            TKey key,
            Func<TValue> createDefaultValue
        )
        {
            TValue result = EnumerableExtension.GetOrAdd<TKey, TValue>(d, key, createDefaultValue);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GetOrAddTest02(Dictionary`2<!!0,!!1>, !!0, Func`1<!!1>)
        }

        /// <summary>Test stub for GroupEvery(IEnumerable`1&lt;!!0&gt;, Int32)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<IEnumerable<T>> GroupEveryTest<T>(IEnumerable<T> source, int groupSize)
        {
            IEnumerable<IEnumerable<T>> result = EnumerableExtension.GroupEvery<T>(source, groupSize);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GroupEveryTest(IEnumerable`1<!!0>, Int32)
        }

        /// <summary>Test stub for GroupJoin(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,Dictionary`2&lt;!!1,!!2&gt;&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TInnerKey, IEnumerable<TSource>> GroupJoinTest<TOuterKey, TInnerKey, TSource>(IEnumerable<KeyValuePair<TOuterKey, Dictionary<TInnerKey, TSource>>> source)
        {
            Dictionary<TInnerKey, IEnumerable<TSource>> result
               = EnumerableExtension.GroupJoin<TOuterKey, TInnerKey, TSource>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GroupJoinTest(IEnumerable`1<KeyValuePair`2<!!0,Dictionary`2<!!1,!!2>>>)
        }

        /// <summary>Test stub for GroupJoin(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,Dictionary`2&lt;!!1,!!2&gt;&gt;&gt;, Func`2&lt;IEnumerable`1&lt;KeyValuePair`2&lt;!!1,!!2&gt;&gt;,!!3&gt;)</summary>
        [PexGenericArguments(new Type[] { typeof(int), typeof(int), typeof(int), typeof(int) })]
        [PexMethod]
        public Dictionary<TInnerKey, TElement> GroupJoinTest01<TOuterKey, TInnerKey, TSource, TElement>(
            IEnumerable<KeyValuePair<TOuterKey, Dictionary<TInnerKey, TSource>>> source,
            Func<IEnumerable<KeyValuePair<TInnerKey, TSource>>, TElement> elementSelector
        )
        {
            Dictionary<TInnerKey, TElement> result
               = EnumerableExtension.GroupJoin<TOuterKey, TInnerKey, TSource, TElement>(source, elementSelector);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GroupJoinTest01(IEnumerable`1<KeyValuePair`2<!!0,Dictionary`2<!!1,!!2>>>, Func`2<IEnumerable`1<KeyValuePair`2<!!1,!!2>>,!!3>)
        }

        /// <summary>Test stub for GroupToArrayDictionary(IEnumerable`1&lt;!!1&gt;, Func`2&lt;!!1,!!0&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, TSource[]> GroupToArrayDictionaryTest<TKey, TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            Dictionary<TKey, TSource[]> result
               = EnumerableExtension.GroupToArrayDictionary<TKey, TSource>(source, keySelector);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GroupToArrayDictionaryTest(IEnumerable`1<!!1>, Func`2<!!1,!!0>)
        }

        /// <summary>Test stub for GroupToDictionary(IEnumerable`1&lt;!!1&gt;, Func`2&lt;!!1,!!0&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, IEnumerable<TSource>> GroupToDictionaryTest<TKey, TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            Dictionary<TKey, IEnumerable<TSource>> result
               = EnumerableExtension.GroupToDictionary<TKey, TSource>(source, keySelector);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GroupToDictionaryTest(IEnumerable`1<!!1>, Func`2<!!1,!!0>)
        }

        /// <summary>Test stub for GroupToDictionary(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,!!1&gt;, Func`2&lt;IGrouping`2&lt;!!1,!!0&gt;,!!2&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, TElement> GroupToDictionaryTest01<TSource, TKey, TElement>(
            IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<IGrouping<TKey, TSource>, TElement> elementSelector
        )
        {
            Dictionary<TKey, TElement> result = EnumerableExtension.GroupToDictionary<TSource, TKey, TElement>
                                                    (source, keySelector, elementSelector);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GroupToDictionaryTest01(IEnumerable`1<!!0>, Func`2<!!0,!!1>, Func`2<IGrouping`2<!!1,!!0>,!!2>)
        }

        /// <summary>Test stub for GroupToDictionary(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,!!1&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, IEnumerable<TSource>> GroupToDictionaryTest02<TKey, TSource>(IEnumerable<KeyValuePair<TKey, TSource>> source)
        {
            Dictionary<TKey, IEnumerable<TSource>> result
               = EnumerableExtension.GroupToDictionary<TKey, TSource>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.GroupToDictionaryTest02(IEnumerable`1<KeyValuePair`2<!!0,!!1>>)
        }

        /// <summary>Test stub for Iter(IEnumerable`1&lt;!!0&gt;, Action`1&lt;!!0&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> IterTest<T>(IEnumerable<T> source, Action<T> action)
        {
            IEnumerable<T> result = EnumerableExtension.Iter<T>(source, action);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.IterTest(IEnumerable`1<!!0>, Action`1<!!0>)
        }

        /// <summary>Test stub for Iter(IEnumerable`1&lt;!!0&gt;, Action`2&lt;!!0,Int32&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> IterTest01<T>(IEnumerable<T> source, Action<T, int> action)
        {
            IEnumerable<T> result = EnumerableExtension.Iter<T>(source, action);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.IterTest01(IEnumerable`1<!!0>, Action`2<!!0,Int32>)
        }

        /// <summary>Test stub for Join(IEnumerable`1&lt;IEnumerable`1&lt;!!0&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> JoinTest<T>(IEnumerable<IEnumerable<T>> source)
        {
            IEnumerable<T> result = EnumerableExtension.Join<T>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.JoinTest(IEnumerable`1<IEnumerable`1<!!0>>)
        }

        /// <summary>Test stub for Join(IEnumerable`1&lt;String&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public string JoinTest01<T>(IEnumerable<string> source)
        {
            string result = EnumerableExtension.Join<T>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.JoinTest01(IEnumerable`1<String>)
        }

        /// <summary>Test stub for Join(IEnumerable`1&lt;String&gt;, String)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public string JoinTest02<T>(IEnumerable<string> source, string separator)
        {
            string result = EnumerableExtension.Join<T>(source, separator);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.JoinTest02(IEnumerable`1<String>, String)
        }

        /// <summary>Test stub for Join(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,Dictionary`2&lt;!!1,!!2&gt;&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<KeyValuePair<TInnerKey, TSource>> JoinTest03<TOuterKey, TInnerKey, TSource>(IEnumerable<KeyValuePair<TOuterKey, Dictionary<TInnerKey, TSource>>> source)
        {
            IEnumerable<KeyValuePair<TInnerKey, TSource>> result
               = EnumerableExtension.Join<TOuterKey, TInnerKey, TSource>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.JoinTest03(IEnumerable`1<KeyValuePair`2<!!0,Dictionary`2<!!1,!!2>>>)
        }

        /// <summary>Test stub for JoinKeys(IEnumerable`1&lt;Dictionary`2&lt;!!0,!!1&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<TKey> JoinKeysTest<TKey, TElement>(IEnumerable<Dictionary<TKey, TElement>> source)
        {
            IEnumerable<TKey> result = EnumerableExtension.JoinKeys<TKey, TElement>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.JoinKeysTest(IEnumerable`1<Dictionary`2<!!0,!!1>>)
        }

        /// <summary>Test stub for JoinValues(IEnumerable`1&lt;Dictionary`2&lt;!!0,!!1&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<TElement> JoinValuesTest<TKey, TElement>(IEnumerable<Dictionary<TKey, TElement>> source)
        {
            IEnumerable<TElement> result = EnumerableExtension.JoinValues<TKey, TElement>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.JoinValuesTest(IEnumerable`1<Dictionary`2<!!0,!!1>>)
        }

        /// <summary>Test stub for None(IEnumerable`1&lt;!!0&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public bool NoneTest<T>(IEnumerable<T> source)
        {
            bool result = EnumerableExtension.None<T>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.NoneTest(IEnumerable`1<!!0>)
        }

        /// <summary>Test stub for None(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public bool NoneTest01<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            bool result = EnumerableExtension.None<T>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.NoneTest01(IEnumerable`1<!!0>, Func`2<!!0,Boolean>)
        }

        /// <summary>Test stub for None(IEnumerable`1&lt;!!0&gt;, !!0)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public bool NoneTest02<T>(IEnumerable<T> source, T value)
        {
            bool result = EnumerableExtension.None<T>(source, value);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.NoneTest02(IEnumerable`1<!!0>, !!0)
        }

        /// <summary>Test stub for Shuffle(IEnumerable`1&lt;!!0&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<TSource> ShuffleTest<TSource>(IEnumerable<TSource> source)
        {
            IEnumerable<TSource> result = EnumerableExtension.Shuffle<TSource>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ShuffleTest(IEnumerable`1<!!0>)
        }

        /// <summary>Test stub for TakeLast(IEnumerable`1&lt;!!0&gt;, Int32)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<TSource> TakeLastTest<TSource>(IEnumerable<TSource> source, int count)
        {
            IEnumerable<TSource> result = EnumerableExtension.TakeLast<TSource>(source, count);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.TakeLastTest(IEnumerable`1<!!0>, Int32)
        }

        /// <summary>Test stub for TakeRandom(IEnumerable`1&lt;!!0&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public T TakeRandomTest<T>(IEnumerable<T> source)
        {
            T result = EnumerableExtension.TakeRandom<T>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.TakeRandomTest(IEnumerable`1<!!0>)
        }

        /// <summary>Test stub for TakeRandom(IEnumerable`1&lt;!!0&gt;, Int32)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<T> TakeRandomTest01<T>(IEnumerable<T> source, int count)
        {
            IEnumerable<T> result = EnumerableExtension.TakeRandom<T>(source, count);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.TakeRandomTest01(IEnumerable`1<!!0>, Int32)
        }

        /// <summary>Test stub for ToDictionary(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,!!1&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, TElement> ToDictionaryTest<TKey, TElement>(IEnumerable<KeyValuePair<TKey, TElement>> source)
        {
            Dictionary<TKey, TElement> result = EnumerableExtension.ToDictionary<TKey, TElement>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.ToDictionaryTest(IEnumerable`1<KeyValuePair`2<!!0,!!1>>)
        }

        /// <summary>Test stub for WhereAny(IEnumerable`1&lt;IEnumerable`1&lt;!!0&gt;&gt;, Func`2&lt;!!0,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<IEnumerable<TElement>> WhereAnyTest<TElement>(IEnumerable<IEnumerable<TElement>> source, Func<TElement, bool> predicate)
        {
            IEnumerable<IEnumerable<TElement>> result
               = EnumerableExtension.WhereAny<TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereAnyTest(IEnumerable`1<IEnumerable`1<!!0>>, Func`2<!!0,Boolean>)
        }

        /// <summary>Test stub for WhereAny(IEnumerable`1&lt;IEnumerable`1&lt;!!0&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<IEnumerable<TElement>> WhereAnyTest01<TElement>(IEnumerable<IEnumerable<TElement>> source)
        {
            IEnumerable<IEnumerable<TElement>> result = EnumerableExtension.WhereAny<TElement>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereAnyTest01(IEnumerable`1<IEnumerable`1<!!0>>)
        }

        /// <summary>Test stub for WhereContains(IEnumerable`1&lt;IEnumerable`1&lt;!!0&gt;&gt;, !!0)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<IEnumerable<TSource>> WhereContainsTest<TSource>(IEnumerable<IEnumerable<TSource>> source, TSource value)
        {
            IEnumerable<IEnumerable<TSource>> result = EnumerableExtension.WhereContains<TSource>(source, value)
              ;
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereContainsTest(IEnumerable`1<IEnumerable`1<!!0>>, !!0)
        }

        /// <summary>Test stub for WhereDictionary(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,!!1&gt;&gt;, Func`2&lt;KeyValuePair`2&lt;!!0,!!1&gt;,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, TElement> WhereDictionaryTest<TKey, TElement>(IEnumerable<KeyValuePair<TKey, TElement>> source, Func<KeyValuePair<TKey, TElement>, bool> predicate)
        {
            Dictionary<TKey, TElement> result
               = EnumerableExtension.WhereDictionary<TKey, TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereDictionaryTest(IEnumerable`1<KeyValuePair`2<!!0,!!1>>, Func`2<KeyValuePair`2<!!0,!!1>,Boolean>)
        }

        /// <summary>Test stub for WhereMany(IEnumerable`1&lt;!!0&gt;, Func`2&lt;!!0,Boolean&gt;[])</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<TElement> WhereManyTest<TElement>(IEnumerable<TElement> source, Func<TElement, bool>[] predicate)
        {
            IEnumerable<TElement> result = EnumerableExtension.WhereMany<TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereManyTest(IEnumerable`1<!!0>, Func`2<!!0,Boolean>[])
        }

        /// <summary>Test stub for WhereMany(IEnumerable`1&lt;!!0&gt;, Func`3&lt;!!0,Int32,Boolean&gt;[])</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<TElement> WhereManyTest01<TElement>(IEnumerable<TElement> source, Func<TElement, int, bool>[] predicate)
        {
            IEnumerable<TElement> result = EnumerableExtension.WhereMany<TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereManyTest01(IEnumerable`1<!!0>, Func`3<!!0,Int32,Boolean>[])
        }

        /// <summary>Test stub for WhereNone(IEnumerable`1&lt;IEnumerable`1&lt;!!0&gt;&gt;, Func`2&lt;!!0,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<IEnumerable<TElement>> WhereNoneTest<TElement>(IEnumerable<IEnumerable<TElement>> source, Func<TElement, bool> predicate)
        {
            IEnumerable<IEnumerable<TElement>> result
               = EnumerableExtension.WhereNone<TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereNoneTest(IEnumerable`1<IEnumerable`1<!!0>>, Func`2<!!0,Boolean>)
        }

        /// <summary>Test stub for WhereNone(IEnumerable`1&lt;IEnumerable`1&lt;!!0&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<IEnumerable<TElement>> WhereNoneTest01<TElement>(IEnumerable<IEnumerable<TElement>> source)
        {
            IEnumerable<IEnumerable<TElement>> result = EnumerableExtension.WhereNone<TElement>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereNoneTest01(IEnumerable`1<IEnumerable`1<!!0>>)
        }

        /// <summary>Test stub for WhereValue(Dictionary`2&lt;!!0,!!1&gt;, Func`2&lt;KeyValuePair`2&lt;!!0,!!1&gt;,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<TKey> WhereValueTest<TKey, TElement>(Dictionary<TKey, TElement> source, Func<KeyValuePair<TKey, TElement>, bool> predicate)
        {
            IEnumerable<TKey> result = EnumerableExtension.WhereValue<TKey, TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest(Dictionary`2<!!0,!!1>, Func`2<KeyValuePair`2<!!0,!!1>,Boolean>)
        }

        /// <summary>Test stub for WhereValue(KeyValuePair`2&lt;!!0,Dictionary`2&lt;!!1,!!2&gt;&gt;, Func`2&lt;KeyValuePair`2&lt;!!1,!!2&gt;,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<TKey> WhereValueTest01<TKeyOuter, TKey, TElement>(KeyValuePair<TKeyOuter, Dictionary<TKey, TElement>> source, Func<KeyValuePair<TKey, TElement>, bool> predicate)
        {
            IEnumerable<TKey> result
               = EnumerableExtension.WhereValue<TKeyOuter, TKey, TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest01(KeyValuePair`2<!!0,Dictionary`2<!!1,!!2>>, Func`2<KeyValuePair`2<!!1,!!2>,Boolean>)
        }

        /// <summary>Test stub for WhereValue(Dictionary`2&lt;!!0,Dictionary`2&lt;!!1,!!2&gt;&gt;, Func`2&lt;KeyValuePair`2&lt;!!1,!!2&gt;,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKeyOuter, IEnumerable<TKey>> WhereValueTest02<TKeyOuter, TKey, TElement>(Dictionary<TKeyOuter, Dictionary<TKey, TElement>> source, Func<KeyValuePair<TKey, TElement>, bool> predicate)
        {
            Dictionary<TKeyOuter, IEnumerable<TKey>> result
               = EnumerableExtension.WhereValue<TKeyOuter, TKey, TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest02(Dictionary`2<!!0,Dictionary`2<!!1,!!2>>, Func`2<KeyValuePair`2<!!1,!!2>,Boolean>)
        }

        /// <summary>Test stub for WhereValue(KeyValuePair`2&lt;!!2,Dictionary`2&lt;!!1,Dictionary`2&lt;!!0,!!3&gt;&gt;&gt;, Func`2&lt;KeyValuePair`2&lt;!!0,!!3&gt;,Boolean&gt;)</summary>
        [PexGenericArguments(new Type[] { typeof(int), typeof(int), typeof(int), typeof(int) })]
        [PexMethod]
        public Dictionary<TKeyOuter, IEnumerable<TKeyInner>> WhereValueTest03<TKeyInner, TKeyOuter, TKeyOuter2, TElement>(
            KeyValuePair<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, TElement>>> source,
            Func<KeyValuePair<TKeyInner, TElement>, bool> predicate
        )
        {
            Dictionary<TKeyOuter, IEnumerable<TKeyInner>> result
               = EnumerableExtension.WhereValue<TKeyInner, TKeyOuter, TKeyOuter2, TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest03(KeyValuePair`2<!!2,Dictionary`2<!!1,Dictionary`2<!!0,!!3>>>, Func`2<KeyValuePair`2<!!0,!!3>,Boolean>)
        }

        /// <summary>Test stub for WhereValue(Dictionary`2&lt;!!2,Dictionary`2&lt;!!1,Dictionary`2&lt;!!0,!!3&gt;&gt;&gt;, Func`2&lt;KeyValuePair`2&lt;!!0,!!3&gt;,Boolean&gt;)</summary>
        [PexGenericArguments(new Type[] { typeof(int), typeof(int), typeof(int), typeof(int) })]
        [PexMethod]
        public Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>> WhereValueTest04<TKeyInner, TKeyOuter, TKeyOuter2, TElement>(
            Dictionary<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, TElement>>> source,
            Func<KeyValuePair<TKeyInner, TElement>, bool> predicate
        )
        {
            Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>> result
               = EnumerableExtension.WhereValue<TKeyInner, TKeyOuter, TKeyOuter2, TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest04(Dictionary`2<!!2,Dictionary`2<!!1,Dictionary`2<!!0,!!3>>>, Func`2<KeyValuePair`2<!!0,!!3>,Boolean>)
        }

        /// <summary>Test stub for WhereValue(Dictionary`2&lt;!!0,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<TKey> WhereValueTest05<TKey>(Dictionary<TKey, bool> source)
        {
            IEnumerable<TKey> result = EnumerableExtension.WhereValue<TKey>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest05(Dictionary`2<!!0,Boolean>)
        }

        /// <summary>Test stub for WhereValue(KeyValuePair`2&lt;!!1,Dictionary`2&lt;!!0,Boolean&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<TKey> WhereValueTest06<TKey, TKeyOuter>(KeyValuePair<TKeyOuter, Dictionary<TKey, bool>> source)
        {
            IEnumerable<TKey> result = EnumerableExtension.WhereValue<TKey, TKeyOuter>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest06(KeyValuePair`2<!!1,Dictionary`2<!!0,Boolean>>)
        }

        /// <summary>Test stub for WhereValue(Dictionary`2&lt;!!1,Dictionary`2&lt;!!0,Boolean&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKeyOuter, IEnumerable<TKeyInner>> WhereValueTest07<TKeyInner, TKeyOuter>(Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>> source)
        {
            Dictionary<TKeyOuter, IEnumerable<TKeyInner>> result
               = EnumerableExtension.WhereValue<TKeyInner, TKeyOuter>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest07(Dictionary`2<!!1,Dictionary`2<!!0,Boolean>>)
        }

        /// <summary>Test stub for WhereValue(KeyValuePair`2&lt;!!2,Dictionary`2&lt;!!1,Dictionary`2&lt;!!0,Boolean&gt;&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKeyOuter, IEnumerable<TKeyInner>> WhereValueTest08<TKeyInner, TKeyOuter, TKeyOuter2>(KeyValuePair<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source)
        {
            Dictionary<TKeyOuter, IEnumerable<TKeyInner>> result
               = EnumerableExtension.WhereValue<TKeyInner, TKeyOuter, TKeyOuter2>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest08(KeyValuePair`2<!!2,Dictionary`2<!!1,Dictionary`2<!!0,Boolean>>>)
        }

        /// <summary>Test stub for WhereValue(Dictionary`2&lt;!!2,Dictionary`2&lt;!!1,Dictionary`2&lt;!!0,Boolean&gt;&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>> WhereValueTest09<TKeyInner, TKeyOuter, TKeyOuter2>(Dictionary<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source)
        {
            Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>> result
               = EnumerableExtension.WhereValue<TKeyInner, TKeyOuter, TKeyOuter2>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueTest09(Dictionary`2<!!2,Dictionary`2<!!1,Dictionary`2<!!0,Boolean>>>)
        }

        /// <summary>Test stub for WhereValueAny(Dictionary`2&lt;!!0,IEnumerable`1&lt;!!1&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, IEnumerable<TElement>> WhereValueAnyTest<TKey, TElement>(Dictionary<TKey, IEnumerable<TElement>> source)
        {
            Dictionary<TKey, IEnumerable<TElement>> result
               = EnumerableExtension.WhereValueAny<TKey, TElement>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueAnyTest(Dictionary`2<!!0,IEnumerable`1<!!1>>)
        }

        /// <summary>Test stub for WhereValueAny(Dictionary`2&lt;!!1,Dictionary`2&lt;!!0,IEnumerable`1&lt;!!2&gt;&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKeyOuter, Dictionary<TKey, IEnumerable<TElement>>> WhereValueAnyTest01<TKey, TKeyOuter, TElement>(Dictionary<TKeyOuter, Dictionary<TKey, IEnumerable<TElement>>> source)
        {
            Dictionary<TKeyOuter, Dictionary<TKey, IEnumerable<TElement>>> result
               = EnumerableExtension.WhereValueAny<TKey, TKeyOuter, TElement>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueAnyTest01(Dictionary`2<!!1,Dictionary`2<!!0,IEnumerable`1<!!2>>>)
        }

        /// <summary>Test stub for WhereValueAny(Dictionary`2&lt;!!0,IEnumerable`1&lt;!!1&gt;&gt;, Func`2&lt;!!1,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, IEnumerable<TElement>> WhereValueAnyTest02<TKey, TElement>(Dictionary<TKey, IEnumerable<TElement>> source, Func<TElement, bool> predicate)
        {
            Dictionary<TKey, IEnumerable<TElement>> result
               = EnumerableExtension.WhereValueAny<TKey, TElement>(source, predicate);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueAnyTest02(Dictionary`2<!!0,IEnumerable`1<!!1>>, Func`2<!!1,Boolean>)
        }

        /// <summary>Test stub for WhereValueNot(Dictionary`2&lt;!!0,Boolean&gt;)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public IEnumerable<TKey> WhereValueNotTest<TKey>(Dictionary<TKey, bool> source)
        {
            IEnumerable<TKey> result = EnumerableExtension.WhereValueNot<TKey>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueNotTest(Dictionary`2<!!0,Boolean>)
        }

        /// <summary>Test stub for WhereValueNot(KeyValuePair`2&lt;!!1,Dictionary`2&lt;!!0,Boolean&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public IEnumerable<TKey> WhereValueNotTest01<TKey, TKeyOuter>(KeyValuePair<TKeyOuter, Dictionary<TKey, bool>> source)
        {
            IEnumerable<TKey> result = EnumerableExtension.WhereValueNot<TKey, TKeyOuter>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueNotTest01(KeyValuePair`2<!!1,Dictionary`2<!!0,Boolean>>)
        }

        /// <summary>Test stub for WhereValueNot(Dictionary`2&lt;!!1,Dictionary`2&lt;!!0,Boolean&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKeyOuter, IEnumerable<TKeyInner>> WhereValueNotTest02<TKeyInner, TKeyOuter>(Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>> source)
        {
            Dictionary<TKeyOuter, IEnumerable<TKeyInner>> result
               = EnumerableExtension.WhereValueNot<TKeyInner, TKeyOuter>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueNotTest02(Dictionary`2<!!1,Dictionary`2<!!0,Boolean>>)
        }

        /// <summary>Test stub for WhereValueNot(KeyValuePair`2&lt;!!2,Dictionary`2&lt;!!1,Dictionary`2&lt;!!0,Boolean&gt;&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKeyOuter, IEnumerable<TKeyInner>> WhereValueNotTest03<TKeyInner, TKeyOuter, TKeyOuter2>(KeyValuePair<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source)
        {
            Dictionary<TKeyOuter, IEnumerable<TKeyInner>> result
               = EnumerableExtension.WhereValueNot<TKeyInner, TKeyOuter, TKeyOuter2>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueNotTest03(KeyValuePair`2<!!2,Dictionary`2<!!1,Dictionary`2<!!0,Boolean>>>)
        }

        /// <summary>Test stub for WhereValueNot(Dictionary`2&lt;!!2,Dictionary`2&lt;!!1,Dictionary`2&lt;!!0,Boolean&gt;&gt;&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>> WhereValueNotTest04<TKeyInner, TKeyOuter, TKeyOuter2>(Dictionary<TKeyOuter2, Dictionary<TKeyOuter, Dictionary<TKeyInner, bool>>> source)
        {
            Dictionary<TKeyOuter2, Dictionary<TKeyOuter, IEnumerable<TKeyInner>>> result
               = EnumerableExtension.WhereValueNot<TKeyInner, TKeyOuter, TKeyOuter2>(source);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WhereValueNotTest04(Dictionary`2<!!2,Dictionary`2<!!1,Dictionary`2<!!0,Boolean>>>)
        }

        /// <summary>Test stub for WithKey(Dictionary`2&lt;!!0,!!1&gt;, Func`2&lt;KeyValuePair`2&lt;!!0,!!1&gt;,!!2&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TResult, TElement> WithKeyTest<TKey, TElement, TResult>(Dictionary<TKey, TElement> source, Func<KeyValuePair<TKey, TElement>, TResult> keySelector)
        {
            Dictionary<TResult, TElement> result
               = EnumerableExtension.WithKey<TKey, TElement, TResult>(source, keySelector);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WithKeyTest(Dictionary`2<!!0,!!1>, Func`2<KeyValuePair`2<!!0,!!1>,!!2>)
        }

        /// <summary>Test stub for WithValue(Dictionary`2&lt;!!0,!!1&gt;, Func`2&lt;KeyValuePair`2&lt;!!0,!!1&gt;,!!2&gt;)</summary>
        [PexGenericArguments(typeof(int), typeof(int), typeof(int))]
        [PexMethod]
        public Dictionary<TKey, TResult> WithValueTest<TKey, TElement, TResult>(Dictionary<TKey, TElement> source, Func<KeyValuePair<TKey, TElement>, TResult> elementSelector)
        {
            Dictionary<TKey, TResult> result
               = EnumerableExtension.WithValue<TKey, TElement, TResult>(source, elementSelector);
            return result;
            // TODO: add assertions to method EnumerableExtensionTest.WithValueTest(Dictionary`2<!!0,!!1>, Func`2<KeyValuePair`2<!!0,!!1>,!!2>)
        }
    }
}
