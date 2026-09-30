using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Swizzle
{
    [TestFixture]
    public class HalfSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new hvec2(new GlmHalf(8.5), new GlmHalf(9));
                var v = ov.swizzle.xx;
                Assert.AreEqual(new GlmHalf(8.5), v.x);
                Assert.AreEqual(new GlmHalf(8.5), v.y);
            }
            {
                var ov = new hvec2(new GlmHalf(9.5), new GlmHalf(5.5));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new GlmHalf(9.5), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
                Assert.AreEqual(new GlmHalf(9.5), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(2.5), new GlmHalf(-9.5));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new GlmHalf(2.5), v.x);
                Assert.AreEqual(new GlmHalf(2.5), v.y);
                Assert.AreEqual(new GlmHalf(2.5), v.z);
                Assert.AreEqual(new GlmHalf(2.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-2), new GlmHalf(7));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
                Assert.AreEqual(new GlmHalf(7), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-3.5), new GlmHalf(-7));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new GlmHalf(-3.5), v.x);
                Assert.AreEqual(new GlmHalf(-3.5), v.y);
                Assert.AreEqual(new GlmHalf(-7), v.z);
            }
            {
                var ov = new hvec2(GlmHalf.One, new GlmHalf(-2));
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
                Assert.AreEqual(GlmHalf.One, v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-8.5), new GlmHalf(4.5));
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(-8.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(7), new GlmHalf(-1.5));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new GlmHalf(7), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
            }
            {
                var ov = new hvec2(new GlmHalf(0.5), new GlmHalf(-3));
                var v = ov.swizzle.xyx;
                Assert.AreEqual(new GlmHalf(0.5), v.x);
                Assert.AreEqual(new GlmHalf(-3), v.y);
                Assert.AreEqual(new GlmHalf(0.5), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(-8), new GlmHalf(5));
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(new GlmHalf(-8), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(-8), v.z);
                Assert.AreEqual(new GlmHalf(-8), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(7), GlmHalf.One);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new GlmHalf(7), v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
                Assert.AreEqual(new GlmHalf(7), v.z);
                Assert.AreEqual(GlmHalf.One, v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-4.5), new GlmHalf(-7));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new GlmHalf(-4.5), v.x);
                Assert.AreEqual(new GlmHalf(-7), v.y);
                Assert.AreEqual(new GlmHalf(-7), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(6), new GlmHalf(-9.5));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(-9.5), v.y);
                Assert.AreEqual(new GlmHalf(-9.5), v.z);
                Assert.AreEqual(new GlmHalf(6), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(7), new GlmHalf(5.5));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new GlmHalf(7), v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(5.5), v.z);
                Assert.AreEqual(new GlmHalf(5.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-5.5), new GlmHalf(2));
                var v = ov.swizzle.yx;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
            }
            {
                var ov = new hvec2(new GlmHalf(-4), new GlmHalf(8.5));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new GlmHalf(8.5), v.x);
                Assert.AreEqual(new GlmHalf(-4), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(8.5), new GlmHalf(-3));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(new GlmHalf(-3), v.x);
                Assert.AreEqual(new GlmHalf(8.5), v.y);
                Assert.AreEqual(new GlmHalf(8.5), v.z);
                Assert.AreEqual(new GlmHalf(8.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-2), GlmHalf.Zero);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
                Assert.AreEqual(GlmHalf.Zero, v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-9), new GlmHalf(2.5));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new GlmHalf(2.5), v.x);
                Assert.AreEqual(new GlmHalf(-9), v.y);
                Assert.AreEqual(new GlmHalf(2.5), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(-3), new GlmHalf(3));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new GlmHalf(3), v.x);
                Assert.AreEqual(new GlmHalf(-3), v.y);
                Assert.AreEqual(new GlmHalf(3), v.z);
                Assert.AreEqual(new GlmHalf(-3), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-9.5), new GlmHalf(-2));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-9.5), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
                Assert.AreEqual(new GlmHalf(-2), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-0.5), GlmHalf.One);
                var v = ov.swizzle.yy;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
            }
            {
                var ov = new hvec2(new GlmHalf(6), new GlmHalf(-5.5));
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new GlmHalf(-5.5), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
                Assert.AreEqual(new GlmHalf(6), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(-3), new GlmHalf(5));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new GlmHalf(5), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(-3), v.z);
                Assert.AreEqual(new GlmHalf(-3), v.w);
            }
            {
                var ov = new hvec2(GlmHalf.Zero, GlmHalf.One);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
                Assert.AreEqual(GlmHalf.One, v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-1), new GlmHalf(-9));
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new GlmHalf(-9), v.x);
                Assert.AreEqual(new GlmHalf(-9), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(-4.5), new GlmHalf(8));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new GlmHalf(8), v.x);
                Assert.AreEqual(new GlmHalf(8), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
                Assert.AreEqual(new GlmHalf(-4.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-3), new GlmHalf(6.5));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new GlmHalf(6.5), v.x);
                Assert.AreEqual(new GlmHalf(6.5), v.y);
                Assert.AreEqual(new GlmHalf(6.5), v.z);
                Assert.AreEqual(new GlmHalf(6.5), v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new hvec2(new GlmHalf(-6.5), new GlmHalf(9.5));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(-6.5), v.y);
            }
            {
                var ov = new hvec2(new GlmHalf(-2.5), new GlmHalf(-8.5));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-2.5), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(-8), new GlmHalf(6));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(new GlmHalf(-8), v.x);
                Assert.AreEqual(new GlmHalf(-8), v.y);
                Assert.AreEqual(new GlmHalf(-8), v.z);
                Assert.AreEqual(new GlmHalf(-8), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(3.5), new GlmHalf(9.5));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new GlmHalf(3.5), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(new GlmHalf(3.5), v.z);
                Assert.AreEqual(new GlmHalf(9.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-6), GlmHalf.Zero);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new GlmHalf(-6), v.x);
                Assert.AreEqual(new GlmHalf(-6), v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(-5), new GlmHalf(8));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new GlmHalf(-5), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
                Assert.AreEqual(new GlmHalf(-5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-9), new GlmHalf(6.5));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new GlmHalf(-9), v.x);
                Assert.AreEqual(new GlmHalf(-9), v.y);
                Assert.AreEqual(new GlmHalf(6.5), v.z);
                Assert.AreEqual(new GlmHalf(6.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-8.5), new GlmHalf(9.5));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
            }
            {
                var ov = new hvec2(new GlmHalf(7), new GlmHalf(-4));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new GlmHalf(7), v.x);
                Assert.AreEqual(new GlmHalf(-4), v.y);
                Assert.AreEqual(new GlmHalf(7), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(-2), new GlmHalf(-5));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
                Assert.AreEqual(new GlmHalf(-2), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(7.5), new GlmHalf(7));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new GlmHalf(7.5), v.x);
                Assert.AreEqual(new GlmHalf(7), v.y);
                Assert.AreEqual(new GlmHalf(7.5), v.z);
                Assert.AreEqual(new GlmHalf(7), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(4), new GlmHalf(2.5));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new GlmHalf(4), v.x);
                Assert.AreEqual(new GlmHalf(2.5), v.y);
                Assert.AreEqual(new GlmHalf(2.5), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(0.5), new GlmHalf(-5));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new GlmHalf(0.5), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(-5), v.z);
                Assert.AreEqual(new GlmHalf(0.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-4.5), new GlmHalf(-1.5));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new GlmHalf(-4.5), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
                Assert.AreEqual(new GlmHalf(-1.5), v.z);
                Assert.AreEqual(new GlmHalf(-1.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-6.5), new GlmHalf(-5.5));
                var v = ov.swizzle.gr;
                Assert.AreEqual(new GlmHalf(-5.5), v.x);
                Assert.AreEqual(new GlmHalf(-6.5), v.y);
            }
            {
                var ov = new hvec2(new GlmHalf(1.5), new GlmHalf(-2));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(1.5), v.y);
                Assert.AreEqual(new GlmHalf(1.5), v.z);
            }
            {
                var ov = new hvec2(GlmHalf.Zero, GlmHalf.One);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(GlmHalf.Zero, v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
                Assert.AreEqual(GlmHalf.Zero, v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(5), new GlmHalf(4.5));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(5), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec2(GlmHalf.One, GlmHalf.Zero);
                var v = ov.swizzle.grg;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(2), new GlmHalf(8.5));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(new GlmHalf(8.5), v.x);
                Assert.AreEqual(new GlmHalf(2), v.y);
                Assert.AreEqual(new GlmHalf(8.5), v.z);
                Assert.AreEqual(new GlmHalf(2), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-8.5), new GlmHalf(-4));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new GlmHalf(-4), v.x);
                Assert.AreEqual(new GlmHalf(-8.5), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(-4), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(5.5), new GlmHalf(-1));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
            }
            {
                var ov = new hvec2(GlmHalf.Zero, new GlmHalf(-6.5));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(-6.5), v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(-5), new GlmHalf(-6.5));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(-6.5), v.y);
                Assert.AreEqual(new GlmHalf(-5), v.z);
                Assert.AreEqual(new GlmHalf(-5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(0.5), new GlmHalf(3));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new GlmHalf(3), v.x);
                Assert.AreEqual(new GlmHalf(3), v.y);
                Assert.AreEqual(new GlmHalf(0.5), v.z);
                Assert.AreEqual(new GlmHalf(3), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(-8.5), new GlmHalf(5));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new GlmHalf(5), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(5), v.z);
            }
            {
                var ov = new hvec2(new GlmHalf(1.5), new GlmHalf(6));
                var v = ov.swizzle.gggr;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(6), v.y);
                Assert.AreEqual(new GlmHalf(6), v.z);
                Assert.AreEqual(new GlmHalf(1.5), v.w);
            }
            {
                var ov = new hvec2(new GlmHalf(8), new GlmHalf(-5));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new GlmHalf(-5), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(-5), v.z);
                Assert.AreEqual(new GlmHalf(-5), v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new hvec2(new GlmHalf(-4.5), new GlmHalf(-9.5));
                var v1 = new hvec2(new GlmHalf(-6.5), new GlmHalf(9));
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(-6.5), v0.x);
                Assert.AreEqual(new GlmHalf(9), v0.y);
            
                Assert.AreEqual(new GlmHalf(-4.5), v2.x);
                Assert.AreEqual(new GlmHalf(-9.5), v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new hvec2(new GlmHalf(6), new GlmHalf(6.5));
                var v1 = new GlmHalf(new GlmHalf(-7));
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(-7), v0.x);
                Assert.AreEqual(new GlmHalf(6.5), v0.y);
            
                Assert.AreEqual(new GlmHalf(6), v2);
            }
            {
                var v0 = new hvec2(new GlmHalf(6), new GlmHalf(-0.5));
                var v1 = new GlmHalf(new GlmHalf(-6));
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(6), v0.x);
                Assert.AreEqual(new GlmHalf(-6), v0.y);
            
                Assert.AreEqual(new GlmHalf(-0.5), v2);
            }
            {
                var v0 = new hvec2(new GlmHalf(1.5), GlmHalf.One);
                var v1 = new hvec2(new GlmHalf(6.5), new GlmHalf(-8));
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(6.5), v0.x);
                Assert.AreEqual(new GlmHalf(-8), v0.y);
            
                Assert.AreEqual(new GlmHalf(1.5), v2.x);
                Assert.AreEqual(GlmHalf.One, v2.y);
            }
        }

    }
}
