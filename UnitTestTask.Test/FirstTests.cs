﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTask.Test
{
    [TestFixture]
    public class FirstTests
    {
        [Test]
        public void FTest()
        {
            Assert.IsTrue(2 == 7);
        }
    }
}
