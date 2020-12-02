using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQE_Pruefund2
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        int number1;
        int number2;
        int result;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            number1 = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            number2 = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = number1 + number2;
        }
        
        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            result = number1 - number2;
        }
        
        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = number1 * number2;
        }
        
        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = number1 / number2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, (int) result);
        }
       
    }
}
