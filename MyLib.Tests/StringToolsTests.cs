using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MyLib;

namespace MyLib.Tests;

public class StringToolsTests
{
    [Fact]
    public void Reverse_Works()
    {
        Assert.Equal("cba", StringTools.Reverse("abc"));
    }

    [Fact]
    public void Reverse_Null_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => StringTools.Reverse(null!));
    }

    [Fact]
    public void WordCount_Works()
    {
        Assert.Equal(3, StringTools.WordCount("one  two   three"));
    }
}

