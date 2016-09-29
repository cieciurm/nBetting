using NBetting.Web.Helpers.Types;
using Xunit;

namespace NBetting.Tests.Helpers
{
    public class MemberNamesGetterTests
    {
        private class ClassWithMemmbers
        {
            public void ActionWithoutArgumentAndVoid()
            {
            }

            public void ActionWithArgumentAndVoid(int arg)
            {
            }

            public int ActionWithoutArgumentAndInt()
            {
                return 0;
            }

            public int ActionWithArgumentAndInt(string arg)
            {
                return 0;
            }
        }

        [Fact]
        public void GetMemberName_ActionWithoutArgumentAndVoid_ReturnsMemberName()
        {
            var result = MemberNamesGetter.GetMemberName<ClassWithMemmbers>(x => x.ActionWithoutArgumentAndVoid());
            Assert.Equal("ActionWithoutArgumentAndVoid", result);
        }

        [Fact]
        public void GetMemberName_ActionWithArgumentAndVoid_ReturnsMemberName()
        {
            var result = MemberNamesGetter.GetMemberName<ClassWithMemmbers>(x => x.ActionWithArgumentAndVoid(default(int)));
            Assert.Equal("ActionWithArgumentAndVoid", result);
        }

        [Fact]
        public void GetMemberName_ActionWithoutArgumentAndInt_ReturnsMemberName()
        {
            var result = MemberNamesGetter.GetMemberName<ClassWithMemmbers>(x => x.ActionWithoutArgumentAndInt());
            Assert.Equal("ActionWithoutArgumentAndInt", result);
        }

        [Fact]
        public void GetMemberName_ActionWithArgumentAndInt_ReturnsMemberName()
        {
            var result = MemberNamesGetter.GetMemberName<ClassWithMemmbers>(x => x.ActionWithArgumentAndInt(default(string)));
            Assert.Equal("ActionWithArgumentAndInt", result);
        }
    }
}
