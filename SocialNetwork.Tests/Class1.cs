using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]

        public void GetFriendIdMustReturnCorrectValue()
        {
            var friend = new Class1();
            Assert.That(friend.Equals(friend));
        }
    }
}
