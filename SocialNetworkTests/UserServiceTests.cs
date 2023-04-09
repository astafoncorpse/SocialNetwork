using SocialNetwork.BLL.Models;

namespace SocialNetworkTests
{
    [TestClass]
    public class UserServiceTests
    {
        [TestMethod]
        public void Register()
        {
            UserRegistrationData userRegistrationData = new UserRegistrationData();
            userRegistrationData.Password = "password";
            Assert.IsNotNull(userRegistrationData);

            userRegistrationData.Email = "email";
            Assert.IsNotNull(userRegistrationData.Email);

        }
        
    }
}