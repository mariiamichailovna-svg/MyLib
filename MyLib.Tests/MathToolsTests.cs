using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MyLib;

namespace MyLib.Tests;

public class MathToolsTests
{
    [Fact]
    public void Add_Works()
    {
        Assert.Equal(7, MathTools.Add(3, 4));
    }

    [Fact]
    public void Sub_Works()
    {
        Assert.Equal(-1, MathTools.Sub(3, 4));
    }

    [Fact]
    public void Mul_Works()
    {
        Assert.Equal(12, MathTools.Mul(3, 4));
    }
}
