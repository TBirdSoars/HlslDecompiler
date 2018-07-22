﻿namespace HlslDecompiler.Hlsl
{
    public class AbsoluteOperation : Operation
    {
        public AbsoluteOperation(HlslTreeNode value)
        {
            AddChild(value);
        }

        public override string ToString()
        {
            return $"abs({Children[0]})";
        }
    }
}
