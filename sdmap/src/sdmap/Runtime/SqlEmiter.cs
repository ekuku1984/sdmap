﻿using Antlr4.Runtime.Tree;
using sdmap.Functional;
using sdmap.Parser.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static sdmap.Parser.G4.SdmapParser;

namespace sdmap.Runtime
{
    public class SqlEmiter : SqlEmiterBase
    {
        public SqlEmiter(NamedSqlContext parseTree)
            : base(parseTree)
        {
        }

        public static SqlEmiter Create(NamedSqlContext parseTree)
        {
            return new SqlEmiter(parseTree);
        }

        public override Result<EmitFunction> Compile(SdmapContext context)
        {
            return NamedSqlVisitor.Compile((NamedSqlContext)_parseTree, context);
        }
    }
}