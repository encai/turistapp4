using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantAppVersion4.Model;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
namespace RestaurantAppVersion4.Model.Tests
{
    [TestClass()]
    public class CommentTests
    {
        private Comment p = new Comment(2, "123456778888");
        [TestMethod()]
        public void Testrating()
        {

            try
            {
                p.ComRating = 6;
                Assert.Fail();
            }
            catch (ArgumentException ae)
            {
                // OK
            }
        }

        [TestMethod()]
        public void Testrating2()
        {

            try
            {
                p.ComRating = 0;
                Assert.Fail();
            }
            catch (ArgumentException ae)
            {
                // OK
            }
        }

        [TestMethod()]
        public void Testtext()
        {

            try
            {
                p.ComText = "123456789";
                Assert.Fail();
            }
            catch (ArgumentException ae)
            {
                // OK
            }
        }
        [TestMethod]
        public void Testtext2()
        {

            try
            {
                p.ComText = "12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901";
                Assert.Fail();
            }
            catch (ArgumentException ae)
            {
                // OK
            }
        }
    }
}
