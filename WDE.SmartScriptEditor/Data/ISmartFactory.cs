﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WDE.Common.Database;
using WDE.SmartScriptEditor.Models;

namespace WDE.SmartScriptEditor.Data
{
    public interface ISmartFactory
    {
        SmartEvent EventFactory(int id);

        SmartEvent EventFactory(ISmartScriptLine line);

        SmartAction ActionFactory(int id, SmartSource source, SmartTarget target);

        SmartAction ActionFactory(ISmartScriptLine line);

        SmartSource SourceFactory(int id);

        SmartTarget TargetFactory(int id);
    }
}
