using OpenQA.Selenium;
using Kwill.Automation.Domain.Entities;
using Kwill.Automation.Domain.Repository;
using System.Threading;
using reference = Kwill.Automation.Data.References.References;

namespace Kwill.Automation.Domain.UserCases
{
    public class Register
    {
        readonly WillEntity will = new WillEntity();

        public WillEntity CreateNewUser(IWebDriver driver)
        {
            will.Date = "";
            return will;
        }
    }
}
