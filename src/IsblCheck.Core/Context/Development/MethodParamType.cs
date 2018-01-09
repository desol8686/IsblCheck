﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsblCheck.Core.Context.Development
{
  /// <summary>
  /// Тип параметра метода.
  /// </summary>
  public enum MethodParamType
  {
    /// <summary>
    /// Вариантный.
    /// </summary>
    Variant,

    /// <summary>
    /// Дата.
    /// </summary>
    Date,

    /// <summary>
    /// Дробное число.
    /// </summary>
    Float,

    /// <summary>
    /// Логический.
    /// </summary>
    Boolean,

    /// <summary>
    /// Строка.
    /// </summary>
    String,

    /// <summary>
    /// Целое число.
    /// </summary>
    Integer
  }
}
