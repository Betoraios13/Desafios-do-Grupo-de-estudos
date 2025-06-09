using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;

using System.IO;

using scripts.Model.data.paths;

namespace scripts.Model.data
{
    public abstract class Data
    {
        public abstract void Save();
        public abstract void Load();
    }
}
