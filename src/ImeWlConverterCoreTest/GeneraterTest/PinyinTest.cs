﻿/*
 *   Copyright © 2009-2020 studyzy(深蓝,曾毅)

 *   This program "IME WL Converter(深蓝词库转换)" is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.

 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.

 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using System.Linq;
using NUnit.Framework;
using Studyzy.IMEWLConverter.Generaters;

namespace Studyzy.IMEWLConverter.Test.GeneraterTest;

[TestFixture]
internal class PinyinTest
{
    [OneTimeSetUp]
    public void SetUp()
    {
        generater = new PinyinGenerater();
    }

    private IWordCodeGenerater generater;

    [Test]
    public void TestGetOneWordPinyin()
    {
    }

    [TestCase("曾毅", "zeng yi")]
    [TestCase("音乐", "yin yue")]
    [TestCase("快乐", "kuai le")]
    [TestCase("银行", "yin hang")]
    [TestCase("行走", "xing zou")]
    public void TestGetLongWordsPinyin(string str, string py)
    {
        var result = generater.GetCodeOfString(str);
        Assert.Contains(py, result.ToCodeString(" ").ToArray());
    }
}
