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

using Studyzy.IMEWLConverter.Entities;

namespace Studyzy.IMEWLConverter.Filters;

public class RankPercentageFilter : IBatchFilter
{
    public int Percentage { get; set; }

    public WordLibraryList Filter(WordLibraryList list)
    {
        if (Percentage == 100) return list;
        var count = list.Count * Percentage / 100;
        list.Sort((a, b) => a.Rank - b.Rank);
        var result = new WordLibraryList();
        for (var i = 0; i < count; i++) result.Add(list[i]);
        return result;
    }
}
