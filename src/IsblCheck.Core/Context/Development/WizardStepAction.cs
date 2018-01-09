﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsblCheck.Core.Context.Development
{
  /// <summary>
  /// Действие этапа мастера действий.
  /// </summary>
  public class WizardStepAction
  {
    /// <summary>
    /// Имя события.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Заголовок события.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Текст вычисления.
    /// </summary>
    public string CalculationText { get; set; }
  }
}
