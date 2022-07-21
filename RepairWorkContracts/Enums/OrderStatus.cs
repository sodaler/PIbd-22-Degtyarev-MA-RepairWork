﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairWorkContracts.Enums
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public enum OrderStatus
    {
        Принят = 0,
        Выполняется = 1,
        Готов = 2,
        Выдан = 3
    }
}

