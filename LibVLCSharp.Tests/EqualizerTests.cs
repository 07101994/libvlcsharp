﻿using LibVLCSharp.Shared;
using NUnit.Framework;

namespace LibVLCSharp.Tests
{
    [TestFixture]
    public class EqualizerTests : BaseSetup
    {
        [Test]
        public void BasicNativeCallTest()
        {
            var equalizer = new Equalizer();
            equalizer.SetAmp(-1, 1);
            Assert.AreEqual(-1, equalizer.Amp(1));
        }
    }
}