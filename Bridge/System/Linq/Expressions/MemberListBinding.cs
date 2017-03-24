using Bridge;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions
{
    [External]
    [Name("System.Object")]
    [Cast("{this}.btype === 2")]
    public sealed class MemberListBinding : MemberBinding
    {
        [Name(true)] //[Field]
        public extern ReadOnlyCollection<ElementInit> Initializers { get; private set; }

        internal extern MemberListBinding();
    }
}