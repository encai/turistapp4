using System;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testrating1()
        {
            Comment comment = new Comment("asdfgbejdt", 3);

                try
                {
                    comment.rating(6);
                    Assert.Fail();
                }
                catch (ArgumentException ae)
                {
                    
                    // ok
                }     
        }
        [TestMethod]
        public void Testrating2()
        {
            Comment comment = new Comment("asdfgbejdt", 3);

            try
            {
                comment.rating(0);
                Assert.Fail();
            }
            catch (ArgumentException ae)
            {

                // ok
            }
        }
        [TestMethod]
        public void Testcomment()
        {
            Comment comment = new Comment("asdfgbejdt", 3);

            try
            {
                comment.rating(6);
                Assert.Fail();
            }
            catch (ArgumentException ae)
            {

                // ok
            }
        }
    }
}
