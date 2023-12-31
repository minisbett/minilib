﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Constants;

/// <summary>
/// Provides common constant strings.
/// </summary>
public static class StringConstants
{
  /// <summary>
  /// An array of all printable ASCII characters. (32-126)
  /// """ !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~"""
  /// </summary>
  public static readonly char[] PRINTABLE_ASCII = Enumerable.Range(32, 95).Select(x => (char)x).ToArray();
}
