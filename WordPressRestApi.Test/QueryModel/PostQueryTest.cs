using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressRestApi.QueryModel;

namespace WordPressRestApi.Test.QueryModel
{
    [TestClass]
    public class PostQueryTest
    {
        [TestMethod]
        public void CtorTest()
        {
            PostsQuery cut = new PostsQuery();
            Assert.IsNotNull(cut);
        }

        [TestMethod]
        public void DictionaryTest()
        {
            PostsQuery cut = new PostsQuery();
            cut.Author = 1;
            cut.PerPage = 30;
            cut.Categories = new List<int>(){131, 158};
            Assert.IsNotNull(cut);

            var dict = cut.GenerateQueryDictionary();
            Assert.IsNotNull(dict);
            Assert.AreEqual(3,dict.Count);
        }

    }


}
