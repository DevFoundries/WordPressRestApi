using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressRestApi.QueryModel;

namespace WordPressRestApi.Test.QueryModel
{
    [TestClass]
    public class CategoriesQueryTest
    {
        [TestMethod]
        public void CtorTest()
        {
            CategoriesQuery cut = new CategoriesQuery();
            Assert.IsNotNull(cut);
        }

        [TestMethod]
        public void DictionaryTest()
        {
            CategoriesQuery cut = new CategoriesQuery {PerPage = "30", HideEmpty = "true"};
            Assert.IsNotNull(cut);

            var dict = cut.GenerateQueryDictionary();
            Assert.IsNotNull(dict);
            Assert.AreEqual(2,dict.Count);
        }
    }
}
