﻿using Biblioteca.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BLL.Ports
{
    public interface IImprumutRepository
    {
        List<Imprumut> GetImprumutList();
    }
}
