﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using IxMilia.Step.Tokens;

namespace IxMilia.Step.Syntax
{
    internal class StepAutoSyntax : StepSyntax
    {
        public override StepSyntaxType SyntaxType => StepSyntaxType.Auto;

        public StepAutoSyntax()
            : this(new StepAsteriskToken(-1, -1))
        {
        }

        public StepAutoSyntax(StepAsteriskToken value)
            : base(value.Line, value.Column)
        {
        }

        public override string ToString(StepWriter writer)
        {
            return "*";
        }
    }
}
