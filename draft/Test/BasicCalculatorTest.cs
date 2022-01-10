using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft.Test
{
    class BasicCalculatorTest : BaseTest
    {
        [TestCase("25", "25.5", false, "50.5", TestName = "25 + 25,5 = 50,5")]
        [TestCase("5", "25.5", true, "30", TestName = "5 + 25,5 = -30")]
        [TestCase("1.99", "0.959", false, "2.949", TestName = "1,99 + 0,959 = 2,949")]
        [TestCase("-1", "-9.99", true, "-10", TestName = "-1 + -9,99 = -10")]
        public static void TestSumBlock(string firstInputValue, string secondInputValue, bool shouldBeChecked, string result)
        {

            basicCalculatorPage.NavigateToDefaultPage()
                .EnterFirstInputField(firstInputValue)
                .EnterSecondInputValue(secondInputValue)
                .CheckIfIntegersOnly(shouldBeChecked)
                .ClickCalculateButton()
                .VerifyResult(result);

        }

    }
}
