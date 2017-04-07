using System;
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
            PostQuery cut = new PostQuery();
            Assert.IsNotNull(cut);
        }

        [TestMethod]
        public void DictionaryTest()
        {
            PostQuery cut = new PostQuery();
            cut.Author = "wbsimms";
            cut.PerPage = "30";
            Assert.IsNotNull(cut);

            var dict = cut.GenerateQueryDictionary();
            Assert.IsNotNull(dict);
            Assert.AreEqual(2,dict.Count);
        }

    }


}
