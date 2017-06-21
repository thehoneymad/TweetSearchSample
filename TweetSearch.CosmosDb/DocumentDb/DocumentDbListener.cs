namespace TweetSearch.CosmosDb.DocumentDb
{
    using Antlr4.Runtime.Misc;
    using System.Linq;

    public class DocumentDbListener : SearchBaseListener
    {
        public string Output { get; internal set; }

        public override void EnterFromText([NotNull] SearchParser.FromTextContext context)
        {
            var text = context.GetText();
            base.EnterFromText(context);
        }

        public override void EnterToText([NotNull] SearchParser.ToTextContext context)
        {
            var text = context.GetText();
            base.EnterToText(context);
        }

        public override void EnterExpr([NotNull] SearchParser.ExprContext context)
        {
            var text = context.GetText();
            var something = context.term().ToList();
            base.EnterExpr(context);
        }

        public override void EnterTerm([NotNull] SearchParser.TermContext context)
        {
            base.EnterTerm(context);
        }

        public override void EnterOp([NotNull] SearchParser.OpContext context)
        {
            base.EnterOp(context);
        }
    }
}
