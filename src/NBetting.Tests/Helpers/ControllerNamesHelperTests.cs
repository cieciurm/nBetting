using System;
using System.Collections.Generic;
using NBetting.Web.Controllers;
using NBetting.Web.Helpers.Types;
using Xunit;

namespace NBetting.Tests.Helpers
{
    public class ControllerNamesHelperTests
    {
        [Fact]
        public void GetName_HomeController_ReturnsHome()
        {
            var result = ControllerNamesHelper.GetName<HomeController>();

            Assert.Equal("Home", result);
        }

        [Fact]
        public void GetActionName_ActionNameIsIndex_ReturnsIndex()
        {
            var result = ControllerNamesHelper.GetActionName<HomeController>(x => x.Index());

            Assert.Equal("Index", result);
        }
    }
}
