

using NUnit.Framework;

namespace draft.Test
{
    class BasicCheckBoxTest : BaseTest
    {

        [Test]
        public static void SingleCheckBoxTest()
        {
            _page.NavigateToPage()
                .CheckSingleCheckBox()
                .AssertSingleCheckBoxDemoSuccessMessage()
                .UnCheckSingleCheckBox();
        }

        [Test]
        public static void MultipleCheckBoxTest()
        {
            _page.NavigateToPage()
                .CheckAllMultipleCheckBoxes()
                .AssertButtonName("Uncheck All");
        }

        [Test]
        public static void UncheckMultipleCheckBoxesTest()
        {
            _page.NavigateToPage()
                .CheckAllMultipleCheckBoxes()
                .ClickGroupButton()
                .AssertMultipleCheckBoxesUnchecked();
        }
    }
}

