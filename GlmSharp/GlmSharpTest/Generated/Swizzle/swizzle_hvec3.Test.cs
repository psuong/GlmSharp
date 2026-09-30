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
    public class HalfSwizzleVec3Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(1.5), new GlmHalf(5.5));
                var v = ov.swizzle.xx;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(7), new GlmHalf(-9.5), new GlmHalf(-2.5));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new GlmHalf(7), v.x);
                Assert.AreEqual(new GlmHalf(7), v.y);
                Assert.AreEqual(new GlmHalf(7), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(-2), new GlmHalf(0.5));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(3), new GlmHalf(2.5), new GlmHalf(-1));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(new GlmHalf(3), v.x);
                Assert.AreEqual(new GlmHalf(3), v.y);
                Assert.AreEqual(new GlmHalf(3), v.z);
                Assert.AreEqual(new GlmHalf(2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), new GlmHalf(-8), new GlmHalf(-6));
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
                Assert.AreEqual(new GlmHalf(-1), v.z);
                Assert.AreEqual(new GlmHalf(-6), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1.5), new GlmHalf(-2.5), new GlmHalf(-3.5));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new GlmHalf(-1.5), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
                Assert.AreEqual(new GlmHalf(-2.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), new GlmHalf(-3.5), new GlmHalf(4));
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
                Assert.AreEqual(new GlmHalf(-3.5), v.z);
                Assert.AreEqual(new GlmHalf(-1), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6), new GlmHalf(-4), new GlmHalf(-7.5));
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(new GlmHalf(-6), v.x);
                Assert.AreEqual(new GlmHalf(-6), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(-4), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-5), new GlmHalf(-2), new GlmHalf(1.5));
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(new GlmHalf(-5), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
                Assert.AreEqual(new GlmHalf(1.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(6), new GlmHalf(8), new GlmHalf(2));
                var v = ov.swizzle.xxz;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(6), v.y);
                Assert.AreEqual(new GlmHalf(2), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(7.5), new GlmHalf(0.5), new GlmHalf(-9));
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(new GlmHalf(7.5), v.x);
                Assert.AreEqual(new GlmHalf(7.5), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
                Assert.AreEqual(new GlmHalf(7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(9.5), new GlmHalf(2.5), new GlmHalf(-5));
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(new GlmHalf(9.5), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
                Assert.AreEqual(new GlmHalf(-5), v.z);
                Assert.AreEqual(new GlmHalf(2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(-0.5), new GlmHalf(5));
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(new GlmHalf(-7), v.x);
                Assert.AreEqual(new GlmHalf(-7), v.y);
                Assert.AreEqual(new GlmHalf(5), v.z);
                Assert.AreEqual(new GlmHalf(5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-9.5), new GlmHalf(-1), new GlmHalf(5.5));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new GlmHalf(-9.5), v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(1.5), new GlmHalf(-9.5), new GlmHalf(-4));
                var v = ov.swizzle.xyx;
                Assert.AreEqual(new GlmHalf(1.5), v.x);
                Assert.AreEqual(new GlmHalf(-9.5), v.y);
                Assert.AreEqual(new GlmHalf(1.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-0.5), new GlmHalf(8.5), new GlmHalf(3.5));
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(new GlmHalf(-0.5), v.x);
                Assert.AreEqual(new GlmHalf(8.5), v.y);
                Assert.AreEqual(new GlmHalf(-0.5), v.z);
                Assert.AreEqual(new GlmHalf(-0.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4), new GlmHalf(2.5), new GlmHalf(-6));
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new GlmHalf(-4), v.x);
                Assert.AreEqual(new GlmHalf(2.5), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(9), new GlmHalf(-9), new GlmHalf(9.5));
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(new GlmHalf(9), v.x);
                Assert.AreEqual(new GlmHalf(-9), v.y);
                Assert.AreEqual(new GlmHalf(9), v.z);
                Assert.AreEqual(new GlmHalf(9.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(5), new GlmHalf(-8), new GlmHalf(-7));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new GlmHalf(5), v.x);
                Assert.AreEqual(new GlmHalf(-8), v.y);
                Assert.AreEqual(new GlmHalf(-8), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-4), new GlmHalf(2.5), new GlmHalf(7));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new GlmHalf(-4), v.x);
                Assert.AreEqual(new GlmHalf(2.5), v.y);
                Assert.AreEqual(new GlmHalf(2.5), v.z);
                Assert.AreEqual(new GlmHalf(-4), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(6.5), new GlmHalf(-2.5), new GlmHalf(2));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new GlmHalf(6.5), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-2.5), v.z);
                Assert.AreEqual(new GlmHalf(-2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-2.5), new GlmHalf(5), new GlmHalf(2));
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(5), v.z);
                Assert.AreEqual(new GlmHalf(2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(1.5), new GlmHalf(-1), new GlmHalf(-3.5));
                var v = ov.swizzle.xyz;
                Assert.AreEqual(new GlmHalf(1.5), v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
                Assert.AreEqual(new GlmHalf(-3.5), v.z);
            }
            {
                var ov = new hvec3(GlmHalf.Zero, new GlmHalf(-2), new GlmHalf(8.5));
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(new GlmHalf(8.5), v.z);
                Assert.AreEqual(GlmHalf.Zero, v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-8.5), new GlmHalf(1.5), new GlmHalf(-5));
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(1.5), v.y);
                Assert.AreEqual(new GlmHalf(-5), v.z);
                Assert.AreEqual(new GlmHalf(1.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(9), new GlmHalf(-4.5), new GlmHalf(4.5));
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(new GlmHalf(9), v.x);
                Assert.AreEqual(new GlmHalf(-4.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(7), new GlmHalf(-3.5), new GlmHalf(-4));
                var v = ov.swizzle.xz;
                Assert.AreEqual(new GlmHalf(7), v.x);
                Assert.AreEqual(new GlmHalf(-4), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(7.5), new GlmHalf(2.5), new GlmHalf(-6));
                var v = ov.swizzle.xzx;
                Assert.AreEqual(new GlmHalf(7.5), v.x);
                Assert.AreEqual(new GlmHalf(-6), v.y);
                Assert.AreEqual(new GlmHalf(7.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-3.5), new GlmHalf(-2.5), new GlmHalf(-2));
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(new GlmHalf(-3.5), v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(new GlmHalf(-3.5), v.z);
                Assert.AreEqual(new GlmHalf(-3.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-9), new GlmHalf(4.5), new GlmHalf(-5));
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(new GlmHalf(-9), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8.5), new GlmHalf(3), new GlmHalf(6.5));
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(new GlmHalf(8.5), v.x);
                Assert.AreEqual(new GlmHalf(6.5), v.y);
                Assert.AreEqual(new GlmHalf(8.5), v.z);
                Assert.AreEqual(new GlmHalf(6.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(7.5), new GlmHalf(-5.5), new GlmHalf(-5.5));
                var v = ov.swizzle.xzy;
                Assert.AreEqual(new GlmHalf(7.5), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
                Assert.AreEqual(new GlmHalf(-5.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(2.5), new GlmHalf(3), new GlmHalf(-4));
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(new GlmHalf(2.5), v.x);
                Assert.AreEqual(new GlmHalf(-4), v.y);
                Assert.AreEqual(new GlmHalf(3), v.z);
                Assert.AreEqual(new GlmHalf(2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-2), new GlmHalf(7.5), new GlmHalf(-2.5));
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(7.5), v.z);
                Assert.AreEqual(new GlmHalf(7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(7), new GlmHalf(-4), new GlmHalf(-9.5));
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(new GlmHalf(7), v.x);
                Assert.AreEqual(new GlmHalf(-9.5), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(-9.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-8), new GlmHalf(-0.5), new GlmHalf(-2.5));
                var v = ov.swizzle.xzz;
                Assert.AreEqual(new GlmHalf(-8), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-2.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-5.5), new GlmHalf(6.5), new GlmHalf(2.5));
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(new GlmHalf(-5.5), v.x);
                Assert.AreEqual(new GlmHalf(2.5), v.y);
                Assert.AreEqual(new GlmHalf(2.5), v.z);
                Assert.AreEqual(new GlmHalf(-5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6.5), new GlmHalf(5), new GlmHalf(5));
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(5), v.z);
                Assert.AreEqual(new GlmHalf(5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(8.5), new GlmHalf(4.5));
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-3.5), GlmHalf.Zero, new GlmHalf(-9));
                var v = ov.swizzle.yx;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(new GlmHalf(-3.5), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(0.5), new GlmHalf(-3), new GlmHalf(-7));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new GlmHalf(-3), v.x);
                Assert.AreEqual(new GlmHalf(0.5), v.y);
                Assert.AreEqual(new GlmHalf(0.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-2), GlmHalf.One, new GlmHalf(8));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
                Assert.AreEqual(new GlmHalf(-2), v.w);
            }
            {
                var ov = new hvec3(GlmHalf.One, new GlmHalf(-6.5), new GlmHalf(7));
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
                Assert.AreEqual(GlmHalf.One, v.z);
                Assert.AreEqual(new GlmHalf(-6.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(1.5), new GlmHalf(-7), new GlmHalf(-7.5));
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(new GlmHalf(-7), v.x);
                Assert.AreEqual(new GlmHalf(1.5), v.y);
                Assert.AreEqual(new GlmHalf(1.5), v.z);
                Assert.AreEqual(new GlmHalf(-7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-9.5), new GlmHalf(6.5), new GlmHalf(-0.5));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new GlmHalf(6.5), v.x);
                Assert.AreEqual(new GlmHalf(-9.5), v.y);
                Assert.AreEqual(new GlmHalf(6.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-3.5), new GlmHalf(0.5), new GlmHalf(-9));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new GlmHalf(0.5), v.x);
                Assert.AreEqual(new GlmHalf(-3.5), v.y);
                Assert.AreEqual(new GlmHalf(0.5), v.z);
                Assert.AreEqual(new GlmHalf(-3.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(8), new GlmHalf(7.5));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new GlmHalf(8), v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
                Assert.AreEqual(new GlmHalf(8), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4.5), new GlmHalf(4.5), new GlmHalf(7.5));
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(-4.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7.5), new GlmHalf(-5), new GlmHalf(7.5));
                var v = ov.swizzle.yxz;
                Assert.AreEqual(new GlmHalf(-5), v.x);
                Assert.AreEqual(new GlmHalf(-7.5), v.y);
                Assert.AreEqual(new GlmHalf(7.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(0.5), new GlmHalf(2), new GlmHalf(-4.5));
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(0.5), v.y);
                Assert.AreEqual(new GlmHalf(-4.5), v.z);
                Assert.AreEqual(new GlmHalf(0.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-0.5), new GlmHalf(5), new GlmHalf(2));
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(new GlmHalf(5), v.x);
                Assert.AreEqual(new GlmHalf(-0.5), v.y);
                Assert.AreEqual(new GlmHalf(2), v.z);
                Assert.AreEqual(new GlmHalf(5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(-8.5), new GlmHalf(-4.5));
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(-4.5), v.z);
                Assert.AreEqual(new GlmHalf(-4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), new GlmHalf(5.5), new GlmHalf(-2));
                var v = ov.swizzle.yy;
                Assert.AreEqual(new GlmHalf(5.5), v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-2), new GlmHalf(-6), new GlmHalf(5));
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new GlmHalf(-6), v.x);
                Assert.AreEqual(new GlmHalf(-6), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-9), new GlmHalf(3.5), new GlmHalf(-9.5));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new GlmHalf(3.5), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
                Assert.AreEqual(new GlmHalf(-9), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), new GlmHalf(2), new GlmHalf(8));
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(2), v.y);
                Assert.AreEqual(new GlmHalf(-1), v.z);
                Assert.AreEqual(new GlmHalf(2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(8), new GlmHalf(8));
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(new GlmHalf(8), v.x);
                Assert.AreEqual(new GlmHalf(8), v.y);
                Assert.AreEqual(new GlmHalf(-7), v.z);
                Assert.AreEqual(new GlmHalf(8), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6), new GlmHalf(1.5), new GlmHalf(2.5));
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new GlmHalf(1.5), v.x);
                Assert.AreEqual(new GlmHalf(1.5), v.y);
                Assert.AreEqual(new GlmHalf(1.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-8.5), new GlmHalf(5), new GlmHalf(-8));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new GlmHalf(5), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(5), v.z);
                Assert.AreEqual(new GlmHalf(-8.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-9.5), new GlmHalf(-0.5), new GlmHalf(-3.5));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new GlmHalf(-0.5), v.x);
                Assert.AreEqual(new GlmHalf(-0.5), v.y);
                Assert.AreEqual(new GlmHalf(-0.5), v.z);
                Assert.AreEqual(new GlmHalf(-0.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), new GlmHalf(-1), new GlmHalf(-9.5));
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
                Assert.AreEqual(new GlmHalf(-1), v.z);
                Assert.AreEqual(new GlmHalf(-9.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6.5), GlmHalf.One, new GlmHalf(-1));
                var v = ov.swizzle.yyz;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
                Assert.AreEqual(new GlmHalf(-1), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-9.5), new GlmHalf(-4.5), new GlmHalf(-5));
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(new GlmHalf(-4.5), v.x);
                Assert.AreEqual(new GlmHalf(-4.5), v.y);
                Assert.AreEqual(new GlmHalf(-5), v.z);
                Assert.AreEqual(new GlmHalf(-9.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4), new GlmHalf(-5), new GlmHalf(4.5));
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(new GlmHalf(-5), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(-5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(6), new GlmHalf(-5.5), new GlmHalf(3.5));
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(new GlmHalf(-5.5), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
                Assert.AreEqual(new GlmHalf(3.5), v.z);
                Assert.AreEqual(new GlmHalf(3.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(2.5), new GlmHalf(6), GlmHalf.One);
                var v = ov.swizzle.yz;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(-2), new GlmHalf(-3));
                var v = ov.swizzle.yzx;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-3), v.y);
                Assert.AreEqual(new GlmHalf(-7), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-0.5), new GlmHalf(-4), new GlmHalf(4.5));
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(new GlmHalf(-4), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(-0.5), v.z);
                Assert.AreEqual(new GlmHalf(-0.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6), new GlmHalf(-3), new GlmHalf(-5));
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(new GlmHalf(-3), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(-6), v.z);
                Assert.AreEqual(new GlmHalf(-3), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), new GlmHalf(-4), new GlmHalf(-6));
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(new GlmHalf(-4), v.x);
                Assert.AreEqual(new GlmHalf(-6), v.y);
                Assert.AreEqual(new GlmHalf(-1), v.z);
                Assert.AreEqual(new GlmHalf(-6), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(6), new GlmHalf(1.5), new GlmHalf(6));
                var v = ov.swizzle.yzy;
                Assert.AreEqual(new GlmHalf(1.5), v.x);
                Assert.AreEqual(new GlmHalf(6), v.y);
                Assert.AreEqual(new GlmHalf(1.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-4.5), GlmHalf.Zero, new GlmHalf(4));
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(new GlmHalf(4), v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
                Assert.AreEqual(new GlmHalf(-4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4.5), new GlmHalf(5.5), new GlmHalf(2.5));
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(new GlmHalf(5.5), v.x);
                Assert.AreEqual(new GlmHalf(2.5), v.y);
                Assert.AreEqual(new GlmHalf(5.5), v.z);
                Assert.AreEqual(new GlmHalf(5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8), new GlmHalf(1.5), new GlmHalf(-7));
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(new GlmHalf(1.5), v.x);
                Assert.AreEqual(new GlmHalf(-7), v.y);
                Assert.AreEqual(new GlmHalf(1.5), v.z);
                Assert.AreEqual(new GlmHalf(-7), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(-3), new GlmHalf(3.5));
                var v = ov.swizzle.yzz;
                Assert.AreEqual(new GlmHalf(-3), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(new GlmHalf(3.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-5), new GlmHalf(8), new GlmHalf(6));
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(new GlmHalf(8), v.x);
                Assert.AreEqual(new GlmHalf(6), v.y);
                Assert.AreEqual(new GlmHalf(6), v.z);
                Assert.AreEqual(new GlmHalf(-5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8.5), new GlmHalf(-0.5), new GlmHalf(9.5));
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(new GlmHalf(-0.5), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
                Assert.AreEqual(new GlmHalf(9.5), v.z);
                Assert.AreEqual(new GlmHalf(-0.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(2), new GlmHalf(-8));
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(-8), v.y);
                Assert.AreEqual(new GlmHalf(-8), v.z);
                Assert.AreEqual(new GlmHalf(-8), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4), new GlmHalf(-7.5), new GlmHalf(7.5));
                var v = ov.swizzle.zx;
                Assert.AreEqual(new GlmHalf(7.5), v.x);
                Assert.AreEqual(new GlmHalf(-4), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-3.5), new GlmHalf(6), new GlmHalf(-1.5));
                var v = ov.swizzle.zxx;
                Assert.AreEqual(new GlmHalf(-1.5), v.x);
                Assert.AreEqual(new GlmHalf(-3.5), v.y);
                Assert.AreEqual(new GlmHalf(-3.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(8), new GlmHalf(-2));
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(5.5), v.z);
                Assert.AreEqual(new GlmHalf(5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(9.5), new GlmHalf(7.5), new GlmHalf(-5.5));
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(new GlmHalf(-5.5), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
                Assert.AreEqual(new GlmHalf(9.5), v.z);
                Assert.AreEqual(new GlmHalf(7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-2.5), new GlmHalf(-8.5), new GlmHalf(-6.5));
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-2.5), v.z);
                Assert.AreEqual(new GlmHalf(-6.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-0.5), new GlmHalf(6), new GlmHalf(-1));
                var v = ov.swizzle.zxy;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(-0.5), v.y);
                Assert.AreEqual(new GlmHalf(6), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(9), new GlmHalf(8), new GlmHalf(-8.5));
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(9), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
                Assert.AreEqual(new GlmHalf(9), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(4.5), GlmHalf.Zero);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(GlmHalf.One, GlmHalf.One, new GlmHalf(3));
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(new GlmHalf(3), v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
                Assert.AreEqual(GlmHalf.One, v.z);
                Assert.AreEqual(new GlmHalf(3), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8), new GlmHalf(-2), new GlmHalf(-4.5));
                var v = ov.swizzle.zxz;
                Assert.AreEqual(new GlmHalf(-4.5), v.x);
                Assert.AreEqual(new GlmHalf(8), v.y);
                Assert.AreEqual(new GlmHalf(-4.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-6), new GlmHalf(0.5), new GlmHalf(-1.5));
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(new GlmHalf(-1.5), v.x);
                Assert.AreEqual(new GlmHalf(-6), v.y);
                Assert.AreEqual(new GlmHalf(-1.5), v.z);
                Assert.AreEqual(new GlmHalf(-6), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1.5), new GlmHalf(-2), new GlmHalf(-9));
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(new GlmHalf(-9), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
                Assert.AreEqual(new GlmHalf(-2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(6), new GlmHalf(9.5), new GlmHalf(-1.5));
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(new GlmHalf(-1.5), v.x);
                Assert.AreEqual(new GlmHalf(6), v.y);
                Assert.AreEqual(new GlmHalf(-1.5), v.z);
                Assert.AreEqual(new GlmHalf(-1.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(3), new GlmHalf(-3), new GlmHalf(-7.5));
                var v = ov.swizzle.zy;
                Assert.AreEqual(new GlmHalf(-7.5), v.x);
                Assert.AreEqual(new GlmHalf(-3), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(5), new GlmHalf(4.5), new GlmHalf(-6));
                var v = ov.swizzle.zyx;
                Assert.AreEqual(new GlmHalf(-6), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(8), new GlmHalf(-2.5), new GlmHalf(-1.5));
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(new GlmHalf(-1.5), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
                Assert.AreEqual(new GlmHalf(8), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6.5), new GlmHalf(9), new GlmHalf(-7.5));
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(new GlmHalf(-7.5), v.x);
                Assert.AreEqual(new GlmHalf(9), v.y);
                Assert.AreEqual(new GlmHalf(-6.5), v.z);
                Assert.AreEqual(new GlmHalf(9), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-0.5), new GlmHalf(6), new GlmHalf(4.5));
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(6), v.y);
                Assert.AreEqual(new GlmHalf(-0.5), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(7.5), new GlmHalf(-8), new GlmHalf(-2.5));
                var v = ov.swizzle.zyy;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(-8), v.y);
                Assert.AreEqual(new GlmHalf(-8), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(7.5), new GlmHalf(-5.5), new GlmHalf(5));
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(new GlmHalf(5), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
                Assert.AreEqual(new GlmHalf(-5.5), v.z);
                Assert.AreEqual(new GlmHalf(7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-5.5), new GlmHalf(-2.5), new GlmHalf(6.5));
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(new GlmHalf(6.5), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-2.5), v.z);
                Assert.AreEqual(new GlmHalf(-2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-3.5), new GlmHalf(-6.5), new GlmHalf(6));
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(-6.5), v.y);
                Assert.AreEqual(new GlmHalf(-6.5), v.z);
                Assert.AreEqual(new GlmHalf(6), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(9.5), new GlmHalf(9));
                var v = ov.swizzle.zyz;
                Assert.AreEqual(new GlmHalf(9), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
                Assert.AreEqual(new GlmHalf(9), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(4), new GlmHalf(-7.5), new GlmHalf(6));
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(-7.5), v.y);
                Assert.AreEqual(new GlmHalf(6), v.z);
                Assert.AreEqual(new GlmHalf(4), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7.5), new GlmHalf(5), new GlmHalf(5.5));
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(new GlmHalf(5.5), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(5.5), v.z);
                Assert.AreEqual(new GlmHalf(5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(9.5), new GlmHalf(0.5), new GlmHalf(9.5));
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(new GlmHalf(9.5), v.x);
                Assert.AreEqual(new GlmHalf(0.5), v.y);
                Assert.AreEqual(new GlmHalf(9.5), v.z);
                Assert.AreEqual(new GlmHalf(9.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4.5), new GlmHalf(2.5), new GlmHalf(-4));
                var v = ov.swizzle.zz;
                Assert.AreEqual(new GlmHalf(-4), v.x);
                Assert.AreEqual(new GlmHalf(-4), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-6), new GlmHalf(-4.5), new GlmHalf(2));
                var v = ov.swizzle.zzx;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(2), v.y);
                Assert.AreEqual(new GlmHalf(-6), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(2), new GlmHalf(-2.5), new GlmHalf(-6.5));
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(-6.5), v.y);
                Assert.AreEqual(new GlmHalf(2), v.z);
                Assert.AreEqual(new GlmHalf(2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(1.5), new GlmHalf(3.5));
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(new GlmHalf(3.5), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(1.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(1.5), new GlmHalf(9), new GlmHalf(-5));
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(new GlmHalf(-5), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(1.5), v.z);
                Assert.AreEqual(new GlmHalf(-5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6.5), new GlmHalf(-9), new GlmHalf(-4.5));
                var v = ov.swizzle.zzy;
                Assert.AreEqual(new GlmHalf(-4.5), v.x);
                Assert.AreEqual(new GlmHalf(-4.5), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-4.5), new GlmHalf(-9), new GlmHalf(-2));
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
                Assert.AreEqual(new GlmHalf(-4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8), new GlmHalf(-3), new GlmHalf(-1.5));
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(new GlmHalf(-1.5), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
                Assert.AreEqual(new GlmHalf(-3), v.z);
                Assert.AreEqual(new GlmHalf(-3), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-8), new GlmHalf(-9), new GlmHalf(-2.5));
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
                Assert.AreEqual(new GlmHalf(-2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6), new GlmHalf(6), GlmHalf.One);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(GlmHalf.One, v.y);
                Assert.AreEqual(GlmHalf.One, v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(8.5), new GlmHalf(8.5), new GlmHalf(-2.5));
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-2.5), v.z);
                Assert.AreEqual(new GlmHalf(8.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-2.5), new GlmHalf(-3), new GlmHalf(2.5));
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(new GlmHalf(2.5), v.x);
                Assert.AreEqual(new GlmHalf(2.5), v.y);
                Assert.AreEqual(new GlmHalf(2.5), v.z);
                Assert.AreEqual(new GlmHalf(-3), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(1.5), new GlmHalf(7), new GlmHalf(2));
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(2), v.y);
                Assert.AreEqual(new GlmHalf(2), v.z);
                Assert.AreEqual(new GlmHalf(2), v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new hvec3(new GlmHalf(9.5), new GlmHalf(4), new GlmHalf(7.5));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new GlmHalf(9.5), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-2), new GlmHalf(-1), new GlmHalf(1.5));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-6), new GlmHalf(3.5), new GlmHalf(-9));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(new GlmHalf(-6), v.x);
                Assert.AreEqual(new GlmHalf(-6), v.y);
                Assert.AreEqual(new GlmHalf(-6), v.z);
                Assert.AreEqual(new GlmHalf(-6), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(-8), new GlmHalf(0.5));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(-8), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(2), new GlmHalf(-7), new GlmHalf(9));
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(2), v.y);
                Assert.AreEqual(new GlmHalf(2), v.z);
                Assert.AreEqual(new GlmHalf(9), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(2), new GlmHalf(-5.5), new GlmHalf(-3));
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(2), v.y);
                Assert.AreEqual(new GlmHalf(-5.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(9), new GlmHalf(0.5), new GlmHalf(0.5));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new GlmHalf(9), v.x);
                Assert.AreEqual(new GlmHalf(9), v.y);
                Assert.AreEqual(new GlmHalf(0.5), v.z);
                Assert.AreEqual(new GlmHalf(9), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(5), new GlmHalf(6), new GlmHalf(4));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new GlmHalf(5), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(6), v.z);
                Assert.AreEqual(new GlmHalf(6), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(5.5), new GlmHalf(-2.5));
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(new GlmHalf(-7), v.x);
                Assert.AreEqual(new GlmHalf(-7), v.y);
                Assert.AreEqual(new GlmHalf(5.5), v.z);
                Assert.AreEqual(new GlmHalf(-2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-5), new GlmHalf(5.5), new GlmHalf(-7.5));
                var v = ov.swizzle.rrb;
                Assert.AreEqual(new GlmHalf(-5), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(-7.5), v.z);
            }
            {
                var ov = new hvec3(GlmHalf.Zero, new GlmHalf(2.5), new GlmHalf(3));
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(GlmHalf.Zero, v.y);
                Assert.AreEqual(new GlmHalf(3), v.z);
                Assert.AreEqual(GlmHalf.Zero, v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), new GlmHalf(-3.5), new GlmHalf(-2));
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
                Assert.AreEqual(new GlmHalf(-3.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(2), new GlmHalf(4.5), new GlmHalf(2.5));
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(2), v.y);
                Assert.AreEqual(new GlmHalf(2.5), v.z);
                Assert.AreEqual(new GlmHalf(2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-8.5), new GlmHalf(-1.5), new GlmHalf(-9));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-3), new GlmHalf(3.5), new GlmHalf(-4.5));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new GlmHalf(-3), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(new GlmHalf(-3), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(-3.5), new GlmHalf(-4.5));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new GlmHalf(5.5), v.x);
                Assert.AreEqual(new GlmHalf(-3.5), v.y);
                Assert.AreEqual(new GlmHalf(5.5), v.z);
                Assert.AreEqual(new GlmHalf(5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(7), new GlmHalf(-5.5), new GlmHalf(6));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new GlmHalf(7), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
                Assert.AreEqual(new GlmHalf(7), v.z);
                Assert.AreEqual(new GlmHalf(-5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-8.5), new GlmHalf(-4.5), new GlmHalf(2));
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(-4.5), v.y);
                Assert.AreEqual(new GlmHalf(-8.5), v.z);
                Assert.AreEqual(new GlmHalf(2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4), new GlmHalf(4.5), new GlmHalf(8.5));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new GlmHalf(-4), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(3.5), new GlmHalf(5.5), new GlmHalf(-6));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new GlmHalf(3.5), v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(5.5), v.z);
                Assert.AreEqual(new GlmHalf(3.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4), GlmHalf.Zero, new GlmHalf(7.5));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new GlmHalf(4), v.x);
                Assert.AreEqual(GlmHalf.Zero, v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
                Assert.AreEqual(GlmHalf.Zero, v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(6.5), new GlmHalf(4.5), new GlmHalf(-4.5));
                var v = ov.swizzle.rggb;
                Assert.AreEqual(new GlmHalf(6.5), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(4.5), v.z);
                Assert.AreEqual(new GlmHalf(-4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-2.5), new GlmHalf(1.5), new GlmHalf(1.5));
                var v = ov.swizzle.rgb;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(1.5), v.y);
                Assert.AreEqual(new GlmHalf(1.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(7.5), new GlmHalf(9.5), new GlmHalf(0.5));
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(new GlmHalf(7.5), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
                Assert.AreEqual(new GlmHalf(0.5), v.z);
                Assert.AreEqual(new GlmHalf(7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-8.5), new GlmHalf(-1.5), GlmHalf.One);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
                Assert.AreEqual(GlmHalf.One, v.z);
                Assert.AreEqual(new GlmHalf(-1.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), new GlmHalf(3.5), new GlmHalf(-4));
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(-4), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-9.5), new GlmHalf(-8.5), new GlmHalf(8));
                var v = ov.swizzle.rb;
                Assert.AreEqual(new GlmHalf(-9.5), v.x);
                Assert.AreEqual(new GlmHalf(8), v.y);
            }
            {
                var ov = new hvec3(GlmHalf.One, new GlmHalf(7), new GlmHalf(-2));
                var v = ov.swizzle.rbr;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(GlmHalf.One, v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-6), new GlmHalf(-9), new GlmHalf(7));
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(new GlmHalf(-6), v.x);
                Assert.AreEqual(new GlmHalf(7), v.y);
                Assert.AreEqual(new GlmHalf(-6), v.z);
                Assert.AreEqual(new GlmHalf(-6), v.w);
            }
            {
                var ov = new hvec3(GlmHalf.One, new GlmHalf(7.5), new GlmHalf(2.5));
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(new GlmHalf(2.5), v.y);
                Assert.AreEqual(GlmHalf.One, v.z);
                Assert.AreEqual(new GlmHalf(7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4), new GlmHalf(9), new GlmHalf(8.5));
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(new GlmHalf(-4), v.x);
                Assert.AreEqual(new GlmHalf(8.5), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(8.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(-7), new GlmHalf(-2.5));
                var v = ov.swizzle.rbg;
                Assert.AreEqual(new GlmHalf(-7), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-7), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-7.5), new GlmHalf(-7), new GlmHalf(8.5));
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(new GlmHalf(-7.5), v.x);
                Assert.AreEqual(new GlmHalf(8.5), v.y);
                Assert.AreEqual(new GlmHalf(-7), v.z);
                Assert.AreEqual(new GlmHalf(-7.5), v.w);
            }
            {
                var ov = new hvec3(GlmHalf.Zero, new GlmHalf(8), new GlmHalf(5.5));
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
                Assert.AreEqual(new GlmHalf(8), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(3.5), new GlmHalf(-1), new GlmHalf(-5.5));
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(new GlmHalf(3.5), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
                Assert.AreEqual(new GlmHalf(-1), v.z);
                Assert.AreEqual(new GlmHalf(-5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), GlmHalf.Zero, new GlmHalf(6.5));
                var v = ov.swizzle.rbb;
                Assert.AreEqual(new GlmHalf(-7), v.x);
                Assert.AreEqual(new GlmHalf(6.5), v.y);
                Assert.AreEqual(new GlmHalf(6.5), v.z);
            }
            {
                var ov = new hvec3(GlmHalf.Zero, new GlmHalf(2), GlmHalf.Zero);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(GlmHalf.Zero, v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
                Assert.AreEqual(GlmHalf.Zero, v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4.5), new GlmHalf(-4), new GlmHalf(-4));
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(new GlmHalf(-4.5), v.x);
                Assert.AreEqual(new GlmHalf(-4), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(-4), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(6), new GlmHalf(2), new GlmHalf(3.5));
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(new GlmHalf(3.5), v.z);
                Assert.AreEqual(new GlmHalf(3.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4.5), new GlmHalf(-8.5), new GlmHalf(-5));
                var v = ov.swizzle.gr;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(-4.5), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-8), new GlmHalf(-4.5), new GlmHalf(3.5));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new GlmHalf(-4.5), v.x);
                Assert.AreEqual(new GlmHalf(-8), v.y);
                Assert.AreEqual(new GlmHalf(-8), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(9.5), new GlmHalf(-6.5), new GlmHalf(0.5));
                var v = ov.swizzle.grrr;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
                Assert.AreEqual(new GlmHalf(9.5), v.z);
                Assert.AreEqual(new GlmHalf(9.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(1.5), new GlmHalf(4), new GlmHalf(-2));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new GlmHalf(4), v.x);
                Assert.AreEqual(new GlmHalf(1.5), v.y);
                Assert.AreEqual(new GlmHalf(1.5), v.z);
                Assert.AreEqual(new GlmHalf(4), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4), new GlmHalf(-0.5), new GlmHalf(-6));
                var v = ov.swizzle.grrb;
                Assert.AreEqual(new GlmHalf(-0.5), v.x);
                Assert.AreEqual(new GlmHalf(-4), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(-6), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-5), new GlmHalf(-9), new GlmHalf(-3));
                var v = ov.swizzle.grg;
                Assert.AreEqual(new GlmHalf(-9), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-4), new GlmHalf(8), new GlmHalf(6.5));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(new GlmHalf(8), v.x);
                Assert.AreEqual(new GlmHalf(-4), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
                Assert.AreEqual(new GlmHalf(-4), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1.5), new GlmHalf(8.5), new GlmHalf(-9));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new GlmHalf(8.5), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
                Assert.AreEqual(new GlmHalf(8.5), v.z);
                Assert.AreEqual(new GlmHalf(8.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), GlmHalf.One, new GlmHalf(4.5));
                var v = ov.swizzle.grgb;
                Assert.AreEqual(GlmHalf.One, v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
                Assert.AreEqual(GlmHalf.One, v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(1.5), new GlmHalf(-1.5), new GlmHalf(6.5));
                var v = ov.swizzle.grb;
                Assert.AreEqual(new GlmHalf(-1.5), v.x);
                Assert.AreEqual(new GlmHalf(1.5), v.y);
                Assert.AreEqual(new GlmHalf(6.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-5.5), new GlmHalf(9), new GlmHalf(-4));
                var v = ov.swizzle.grbr;
                Assert.AreEqual(new GlmHalf(9), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(-5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(6.5), new GlmHalf(5.5));
                var v = ov.swizzle.grbg;
                Assert.AreEqual(new GlmHalf(6.5), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(5.5), v.z);
                Assert.AreEqual(new GlmHalf(6.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-5.5), new GlmHalf(-6.5), new GlmHalf(-6.5));
                var v = ov.swizzle.grbb;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
                Assert.AreEqual(new GlmHalf(-6.5), v.z);
                Assert.AreEqual(new GlmHalf(-6.5), v.w);
            }
            {
                var ov = new hvec3(GlmHalf.One, new GlmHalf(4.5), new GlmHalf(-2.5));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(3.5), new GlmHalf(-3.5), new GlmHalf(6.5));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new GlmHalf(-3.5), v.x);
                Assert.AreEqual(new GlmHalf(-3.5), v.y);
                Assert.AreEqual(new GlmHalf(3.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-5.5), new GlmHalf(-3.5), new GlmHalf(-4));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new GlmHalf(-3.5), v.x);
                Assert.AreEqual(new GlmHalf(-3.5), v.y);
                Assert.AreEqual(new GlmHalf(-5.5), v.z);
                Assert.AreEqual(new GlmHalf(-5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-5.5), new GlmHalf(-1), new GlmHalf(4.5));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
                Assert.AreEqual(new GlmHalf(-5.5), v.z);
                Assert.AreEqual(new GlmHalf(-1), v.w);
            }
            {
                var ov = new hvec3(GlmHalf.Zero, new GlmHalf(3.5), new GlmHalf(4.5));
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(new GlmHalf(3.5), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(7.5), new GlmHalf(7.5), new GlmHalf(-7.5));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new GlmHalf(7.5), v.x);
                Assert.AreEqual(new GlmHalf(7.5), v.y);
                Assert.AreEqual(new GlmHalf(7.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(6), new GlmHalf(-5.5));
                var v = ov.swizzle.gggr;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(6), v.y);
                Assert.AreEqual(new GlmHalf(6), v.z);
                Assert.AreEqual(new GlmHalf(5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(9.5), new GlmHalf(8), new GlmHalf(5.5));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new GlmHalf(8), v.x);
                Assert.AreEqual(new GlmHalf(8), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
                Assert.AreEqual(new GlmHalf(8), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(6), new GlmHalf(4.5));
                var v = ov.swizzle.gggb;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(6), v.y);
                Assert.AreEqual(new GlmHalf(6), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8.5), new GlmHalf(-9.5), new GlmHalf(2.5));
                var v = ov.swizzle.ggb;
                Assert.AreEqual(new GlmHalf(-9.5), v.x);
                Assert.AreEqual(new GlmHalf(-9.5), v.y);
                Assert.AreEqual(new GlmHalf(2.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-8.5), new GlmHalf(1.5), new GlmHalf(6.5));
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(new GlmHalf(1.5), v.x);
                Assert.AreEqual(new GlmHalf(1.5), v.y);
                Assert.AreEqual(new GlmHalf(6.5), v.z);
                Assert.AreEqual(new GlmHalf(-8.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(0.5), new GlmHalf(-2), new GlmHalf(-4));
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(-2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(9), new GlmHalf(4.5), new GlmHalf(-3));
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(-3), v.z);
                Assert.AreEqual(new GlmHalf(-3), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6.5), new GlmHalf(-3.5), new GlmHalf(-5));
                var v = ov.swizzle.gb;
                Assert.AreEqual(new GlmHalf(-3.5), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-8.5), new GlmHalf(6), new GlmHalf(-8));
                var v = ov.swizzle.gbr;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(-8), v.y);
                Assert.AreEqual(new GlmHalf(-8.5), v.z);
            }
            {
                var ov = new hvec3(GlmHalf.One, new GlmHalf(-6.5), new GlmHalf(-7));
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(-7), v.y);
                Assert.AreEqual(GlmHalf.One, v.z);
                Assert.AreEqual(GlmHalf.One, v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-9), new GlmHalf(7.5), new GlmHalf(9.5));
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(new GlmHalf(7.5), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
                Assert.AreEqual(new GlmHalf(7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4), new GlmHalf(-1.5), new GlmHalf(-6));
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(new GlmHalf(-1.5), v.x);
                Assert.AreEqual(new GlmHalf(-6), v.y);
                Assert.AreEqual(new GlmHalf(-4), v.z);
                Assert.AreEqual(new GlmHalf(-6), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8.5), new GlmHalf(2), new GlmHalf(-3.5));
                var v = ov.swizzle.gbg;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(-3.5), v.y);
                Assert.AreEqual(new GlmHalf(2), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(2.5), new GlmHalf(9.5), new GlmHalf(-9));
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(new GlmHalf(9.5), v.x);
                Assert.AreEqual(new GlmHalf(-9), v.y);
                Assert.AreEqual(new GlmHalf(9.5), v.z);
                Assert.AreEqual(new GlmHalf(2.5), v.w);
            }
            {
                var ov = new hvec3(GlmHalf.One, new GlmHalf(-3.5), new GlmHalf(5));
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(new GlmHalf(-3.5), v.x);
                Assert.AreEqual(new GlmHalf(5), v.y);
                Assert.AreEqual(new GlmHalf(-3.5), v.z);
                Assert.AreEqual(new GlmHalf(-3.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-8.5), new GlmHalf(3), new GlmHalf(-9));
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(new GlmHalf(3), v.x);
                Assert.AreEqual(new GlmHalf(-9), v.y);
                Assert.AreEqual(new GlmHalf(3), v.z);
                Assert.AreEqual(new GlmHalf(-9), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(7.5), new GlmHalf(-1), new GlmHalf(-8.5));
                var v = ov.swizzle.gbb;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(-8.5), v.y);
                Assert.AreEqual(new GlmHalf(-8.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-9.5), new GlmHalf(-2.5), new GlmHalf(3));
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(3), v.y);
                Assert.AreEqual(new GlmHalf(3), v.z);
                Assert.AreEqual(new GlmHalf(-9.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8), new GlmHalf(-2), new GlmHalf(-9.5));
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-9.5), v.y);
                Assert.AreEqual(new GlmHalf(-9.5), v.z);
                Assert.AreEqual(new GlmHalf(-2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8), new GlmHalf(-8), new GlmHalf(2));
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(new GlmHalf(-8), v.x);
                Assert.AreEqual(new GlmHalf(2), v.y);
                Assert.AreEqual(new GlmHalf(2), v.z);
                Assert.AreEqual(new GlmHalf(2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(2.5), new GlmHalf(-6.5));
                var v = ov.swizzle.br;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(-7), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(-9.5), new GlmHalf(-6.5));
                var v = ov.swizzle.brr;
                Assert.AreEqual(new GlmHalf(-6.5), v.x);
                Assert.AreEqual(new GlmHalf(-7), v.y);
                Assert.AreEqual(new GlmHalf(-7), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(3.5), new GlmHalf(6), new GlmHalf(2));
                var v = ov.swizzle.brrr;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(new GlmHalf(3.5), v.z);
                Assert.AreEqual(new GlmHalf(3.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-8.5), new GlmHalf(1.5), new GlmHalf(9));
                var v = ov.swizzle.brrg;
                Assert.AreEqual(new GlmHalf(9), v.x);
                Assert.AreEqual(new GlmHalf(-8.5), v.y);
                Assert.AreEqual(new GlmHalf(-8.5), v.z);
                Assert.AreEqual(new GlmHalf(1.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-1.5), new GlmHalf(-7), new GlmHalf(4.5));
                var v = ov.swizzle.brrb;
                Assert.AreEqual(new GlmHalf(4.5), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
                Assert.AreEqual(new GlmHalf(-1.5), v.z);
                Assert.AreEqual(new GlmHalf(4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(-8.5), GlmHalf.Zero);
                var v = ov.swizzle.brg;
                Assert.AreEqual(GlmHalf.Zero, v.x);
                Assert.AreEqual(new GlmHalf(4.5), v.y);
                Assert.AreEqual(new GlmHalf(-8.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(9), GlmHalf.Zero, new GlmHalf(2));
                var v = ov.swizzle.brgr;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(9), v.y);
                Assert.AreEqual(GlmHalf.Zero, v.z);
                Assert.AreEqual(new GlmHalf(9), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8.5), new GlmHalf(4), new GlmHalf(-3));
                var v = ov.swizzle.brgg;
                Assert.AreEqual(new GlmHalf(-3), v.x);
                Assert.AreEqual(new GlmHalf(8.5), v.y);
                Assert.AreEqual(new GlmHalf(4), v.z);
                Assert.AreEqual(new GlmHalf(4), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(6.5), new GlmHalf(8.5), new GlmHalf(9));
                var v = ov.swizzle.brgb;
                Assert.AreEqual(new GlmHalf(9), v.x);
                Assert.AreEqual(new GlmHalf(6.5), v.y);
                Assert.AreEqual(new GlmHalf(8.5), v.z);
                Assert.AreEqual(new GlmHalf(9), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(4), new GlmHalf(-6));
                var v = ov.swizzle.brb;
                Assert.AreEqual(new GlmHalf(-6), v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(-6), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(6.5), new GlmHalf(-0.5), new GlmHalf(-4.5));
                var v = ov.swizzle.brbr;
                Assert.AreEqual(new GlmHalf(-4.5), v.x);
                Assert.AreEqual(new GlmHalf(6.5), v.y);
                Assert.AreEqual(new GlmHalf(-4.5), v.z);
                Assert.AreEqual(new GlmHalf(6.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-6.5), new GlmHalf(-5), new GlmHalf(7));
                var v = ov.swizzle.brbg;
                Assert.AreEqual(new GlmHalf(7), v.x);
                Assert.AreEqual(new GlmHalf(-6.5), v.y);
                Assert.AreEqual(new GlmHalf(7), v.z);
                Assert.AreEqual(new GlmHalf(-5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(-4.5), new GlmHalf(6));
                var v = ov.swizzle.brbb;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(6), v.z);
                Assert.AreEqual(new GlmHalf(6), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7.5), new GlmHalf(-1.5), new GlmHalf(7.5));
                var v = ov.swizzle.bg;
                Assert.AreEqual(new GlmHalf(7.5), v.x);
                Assert.AreEqual(new GlmHalf(-1.5), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(-7), new GlmHalf(-9));
                var v = ov.swizzle.bgr;
                Assert.AreEqual(new GlmHalf(-9), v.x);
                Assert.AreEqual(new GlmHalf(-7), v.y);
                Assert.AreEqual(new GlmHalf(-7), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-2), new GlmHalf(2.5), new GlmHalf(-1));
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(2.5), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
                Assert.AreEqual(new GlmHalf(-2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(8), new GlmHalf(-5), new GlmHalf(1.5));
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(new GlmHalf(1.5), v.x);
                Assert.AreEqual(new GlmHalf(-5), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
                Assert.AreEqual(new GlmHalf(-5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-9), new GlmHalf(9.5), new GlmHalf(-8));
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(new GlmHalf(-8), v.x);
                Assert.AreEqual(new GlmHalf(9.5), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
                Assert.AreEqual(new GlmHalf(-8), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(9.5), new GlmHalf(-9), new GlmHalf(-2.5));
                var v = ov.swizzle.bgg;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(-9), v.y);
                Assert.AreEqual(new GlmHalf(-9), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-1), new GlmHalf(-8.5), new GlmHalf(-8.5));
                var v = ov.swizzle.bggr;
                Assert.AreEqual(new GlmHalf(-8.5), v.x);
                Assert.AreEqual(new GlmHalf(-8.5), v.y);
                Assert.AreEqual(new GlmHalf(-8.5), v.z);
                Assert.AreEqual(new GlmHalf(-1), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4), new GlmHalf(7.5), new GlmHalf(2));
                var v = ov.swizzle.bggg;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(7.5), v.y);
                Assert.AreEqual(new GlmHalf(7.5), v.z);
                Assert.AreEqual(new GlmHalf(7.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-2.5), new GlmHalf(-5.5), new GlmHalf(2));
                var v = ov.swizzle.bggb;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(-5.5), v.y);
                Assert.AreEqual(new GlmHalf(-5.5), v.z);
                Assert.AreEqual(new GlmHalf(2), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-5.5), new GlmHalf(4), new GlmHalf(2));
                var v = ov.swizzle.bgb;
                Assert.AreEqual(new GlmHalf(2), v.x);
                Assert.AreEqual(new GlmHalf(4), v.y);
                Assert.AreEqual(new GlmHalf(2), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-3.5), new GlmHalf(8.5), new GlmHalf(6.5));
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(new GlmHalf(6.5), v.x);
                Assert.AreEqual(new GlmHalf(8.5), v.y);
                Assert.AreEqual(new GlmHalf(6.5), v.z);
                Assert.AreEqual(new GlmHalf(-3.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(-2.5), new GlmHalf(-3));
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(new GlmHalf(-3), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-3), v.z);
                Assert.AreEqual(new GlmHalf(-2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(5), new GlmHalf(-7.5), new GlmHalf(-2.5));
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(-7.5), v.y);
                Assert.AreEqual(new GlmHalf(-2.5), v.z);
                Assert.AreEqual(new GlmHalf(-2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(3.5), new GlmHalf(-5.5), new GlmHalf(6));
                var v = ov.swizzle.bb;
                Assert.AreEqual(new GlmHalf(6), v.x);
                Assert.AreEqual(new GlmHalf(6), v.y);
            }
            {
                var ov = new hvec3(new GlmHalf(9.5), new GlmHalf(-3.5), new GlmHalf(-0.5));
                var v = ov.swizzle.bbr;
                Assert.AreEqual(new GlmHalf(-0.5), v.x);
                Assert.AreEqual(new GlmHalf(-0.5), v.y);
                Assert.AreEqual(new GlmHalf(9.5), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(-4.5), new GlmHalf(-8), new GlmHalf(0.5));
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(new GlmHalf(0.5), v.x);
                Assert.AreEqual(new GlmHalf(0.5), v.y);
                Assert.AreEqual(new GlmHalf(-4.5), v.z);
                Assert.AreEqual(new GlmHalf(-4.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(7), new GlmHalf(-5.5), new GlmHalf(5.5));
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(new GlmHalf(5.5), v.x);
                Assert.AreEqual(new GlmHalf(5.5), v.y);
                Assert.AreEqual(new GlmHalf(7), v.z);
                Assert.AreEqual(new GlmHalf(-5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-9.5), new GlmHalf(-4.5), new GlmHalf(3));
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(new GlmHalf(3), v.x);
                Assert.AreEqual(new GlmHalf(3), v.y);
                Assert.AreEqual(new GlmHalf(-9.5), v.z);
                Assert.AreEqual(new GlmHalf(3), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-4.5), new GlmHalf(8), new GlmHalf(0.5));
                var v = ov.swizzle.bbg;
                Assert.AreEqual(new GlmHalf(0.5), v.x);
                Assert.AreEqual(new GlmHalf(0.5), v.y);
                Assert.AreEqual(new GlmHalf(8), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(5.5), new GlmHalf(-0.5), new GlmHalf(3.5));
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(new GlmHalf(3.5), v.x);
                Assert.AreEqual(new GlmHalf(3.5), v.y);
                Assert.AreEqual(new GlmHalf(-0.5), v.z);
                Assert.AreEqual(new GlmHalf(5.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-7), new GlmHalf(-2.5), new GlmHalf(-2.5));
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(new GlmHalf(-2.5), v.x);
                Assert.AreEqual(new GlmHalf(-2.5), v.y);
                Assert.AreEqual(new GlmHalf(-2.5), v.z);
                Assert.AreEqual(new GlmHalf(-2.5), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(7), new GlmHalf(-7.5), new GlmHalf(-7));
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(new GlmHalf(-7), v.x);
                Assert.AreEqual(new GlmHalf(-7), v.y);
                Assert.AreEqual(new GlmHalf(-7.5), v.z);
                Assert.AreEqual(new GlmHalf(-7), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(4.5), new GlmHalf(-4.5), new GlmHalf(-2));
                var v = ov.swizzle.bbb;
                Assert.AreEqual(new GlmHalf(-2), v.x);
                Assert.AreEqual(new GlmHalf(-2), v.y);
                Assert.AreEqual(new GlmHalf(-2), v.z);
            }
            {
                var ov = new hvec3(new GlmHalf(4), new GlmHalf(4.5), new GlmHalf(6.5));
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(new GlmHalf(6.5), v.x);
                Assert.AreEqual(new GlmHalf(6.5), v.y);
                Assert.AreEqual(new GlmHalf(6.5), v.z);
                Assert.AreEqual(new GlmHalf(4), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(9.5), new GlmHalf(-7), new GlmHalf(6.5));
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(new GlmHalf(6.5), v.x);
                Assert.AreEqual(new GlmHalf(6.5), v.y);
                Assert.AreEqual(new GlmHalf(6.5), v.z);
                Assert.AreEqual(new GlmHalf(-7), v.w);
            }
            {
                var ov = new hvec3(new GlmHalf(-5), new GlmHalf(-5), new GlmHalf(-1));
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(new GlmHalf(-1), v.x);
                Assert.AreEqual(new GlmHalf(-1), v.y);
                Assert.AreEqual(new GlmHalf(-1), v.z);
                Assert.AreEqual(new GlmHalf(-1), v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new hvec3(new GlmHalf(-8.5), GlmHalf.Zero, new GlmHalf(-9));
                var v1 = new hvec2(new GlmHalf(-8.5), new GlmHalf(-9.5));
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(-8.5), v0.x);
                Assert.AreEqual(new GlmHalf(-9.5), v0.y);
                Assert.AreEqual(new GlmHalf(-9), v0.z);
            
                Assert.AreEqual(new GlmHalf(-8.5), v2.x);
                Assert.AreEqual(GlmHalf.Zero, v2.y);
            }
            {
                var v0 = new hvec3(new GlmHalf(9), new GlmHalf(7), new GlmHalf(4));
                var v1 = new hvec2(new GlmHalf(7.5), new GlmHalf(-3));
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(7.5), v0.x);
                Assert.AreEqual(new GlmHalf(7), v0.y);
                Assert.AreEqual(new GlmHalf(-3), v0.z);
            
                Assert.AreEqual(new GlmHalf(9), v2.x);
                Assert.AreEqual(new GlmHalf(4), v2.y);
            }
            {
                var v0 = new hvec3(new GlmHalf(4.5), new GlmHalf(-9.5), new GlmHalf(5.5));
                var v1 = new hvec2(new GlmHalf(-8), new GlmHalf(-6.5));
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(4.5), v0.x);
                Assert.AreEqual(new GlmHalf(-8), v0.y);
                Assert.AreEqual(new GlmHalf(-6.5), v0.z);
            
                Assert.AreEqual(new GlmHalf(-9.5), v2.x);
                Assert.AreEqual(new GlmHalf(5.5), v2.y);
            }
            {
                var v0 = new hvec3(new GlmHalf(3.5), new GlmHalf(-2.5), new GlmHalf(9));
                var v1 = new hvec3(new GlmHalf(9.5), new GlmHalf(-0.5), new GlmHalf(2.5));
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(9.5), v0.x);
                Assert.AreEqual(new GlmHalf(-0.5), v0.y);
                Assert.AreEqual(new GlmHalf(2.5), v0.z);
            
                Assert.AreEqual(new GlmHalf(3.5), v2.x);
                Assert.AreEqual(new GlmHalf(-2.5), v2.y);
                Assert.AreEqual(new GlmHalf(9), v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new hvec3(GlmHalf.One, new GlmHalf(-7), new GlmHalf(-4));
                var v1 = new GlmHalf(new GlmHalf(-8));
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(-8), v0.x);
                Assert.AreEqual(new GlmHalf(-7), v0.y);
                Assert.AreEqual(new GlmHalf(-4), v0.z);
            
                Assert.AreEqual(GlmHalf.One, v2);
            }
            {
                var v0 = new hvec3(new GlmHalf(-6), new GlmHalf(-7.5), new GlmHalf(-4));
                var v1 = new GlmHalf(new GlmHalf(4));
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(-6), v0.x);
                Assert.AreEqual(new GlmHalf(4), v0.y);
                Assert.AreEqual(new GlmHalf(-4), v0.z);
            
                Assert.AreEqual(new GlmHalf(-7.5), v2);
            }
            {
                var v0 = new hvec3(new GlmHalf(9.5), new GlmHalf(4), new GlmHalf(-6));
                var v1 = new hvec2(new GlmHalf(4), new GlmHalf(2.5));
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(4), v0.x);
                Assert.AreEqual(new GlmHalf(2.5), v0.y);
                Assert.AreEqual(new GlmHalf(-6), v0.z);
            
                Assert.AreEqual(new GlmHalf(9.5), v2.x);
                Assert.AreEqual(new GlmHalf(4), v2.y);
            }
            {
                var v0 = new hvec3(new GlmHalf(1.5), new GlmHalf(-2.5), new GlmHalf(2));
                var v1 = new GlmHalf(new GlmHalf(6.5));
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(1.5), v0.x);
                Assert.AreEqual(new GlmHalf(-2.5), v0.y);
                Assert.AreEqual(new GlmHalf(6.5), v0.z);
            
                Assert.AreEqual(new GlmHalf(2), v2);
            }
            {
                var v0 = new hvec3(new GlmHalf(7.5), new GlmHalf(4), new GlmHalf(-8.5));
                var v1 = new hvec2(new GlmHalf(9.5), new GlmHalf(3.5));
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(9.5), v0.x);
                Assert.AreEqual(new GlmHalf(4), v0.y);
                Assert.AreEqual(new GlmHalf(3.5), v0.z);
            
                Assert.AreEqual(new GlmHalf(7.5), v2.x);
                Assert.AreEqual(new GlmHalf(-8.5), v2.y);
            }
            {
                var v0 = new hvec3(new GlmHalf(5), new GlmHalf(1.5), new GlmHalf(-7));
                var v1 = new hvec2(new GlmHalf(-0.5), new GlmHalf(-7.5));
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(5), v0.x);
                Assert.AreEqual(new GlmHalf(-0.5), v0.y);
                Assert.AreEqual(new GlmHalf(-7.5), v0.z);
            
                Assert.AreEqual(new GlmHalf(1.5), v2.x);
                Assert.AreEqual(new GlmHalf(-7), v2.y);
            }
            {
                var v0 = new hvec3(new GlmHalf(-6.5), new GlmHalf(1.5), new GlmHalf(9.5));
                var v1 = new hvec3(new GlmHalf(-3), new GlmHalf(-4), new GlmHalf(4));
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new GlmHalf(-3), v0.x);
                Assert.AreEqual(new GlmHalf(-4), v0.y);
                Assert.AreEqual(new GlmHalf(4), v0.z);
            
                Assert.AreEqual(new GlmHalf(-6.5), v2.x);
                Assert.AreEqual(new GlmHalf(1.5), v2.y);
                Assert.AreEqual(new GlmHalf(9.5), v2.z);
            }
        }

    }
}
