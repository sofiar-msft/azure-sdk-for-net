﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using NUnit.Framework;

namespace Azure
{
    public class StoringNull
    {
        [Test]
        public void GetIntFromStoredNull()
        {
            Value nullValue = new((object)null);
            Assert.Throws<InvalidCastException>(() => _ = nullValue.As<int>());

            Value nullFastValue = new((object)null);
            Assert.Throws<InvalidCastException>(() => _ = nullFastValue.As<int>());

            bool success = nullFastValue.TryGetValue(out int result);
            Assert.False(success);

            Assert.AreEqual(default(int), result);
        }
    }
}
