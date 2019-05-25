using Core.Codeforce.Tasks._1167A;
using NUnit.Framework;

namespace Test.Codeforce.Tasks._1667A
{
    [TestFixture]
    public class TestTask
    {
        [Test]
        public void TaskTest()
        {
            var task = new Task();
            
            Assert.True(task.Solve("89326035155".Length, "89326035155"));
            
            Assert.True(task.Solve("893260351535".Length, "893260351535"));
            
            Assert.False(task.Solve("89326034".Length, "89326034"));
            
            Assert.False(task.Solve("79326035155".Length, "79326035155"));
        }
    }
}
