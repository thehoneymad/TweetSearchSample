namespace TweetSearch.CosmosDb.DocumentDb
{
    using Antlr4.Runtime.Misc;
    using TweetSearch.CosmosDb.Util;

    public class DocumentDbListener : SearchBaseListener
    {
        private string projection = "SELECT VALUE twt FROM twt";
        private string join = "JOIN mention in twt.entities.user_mentions";
        private string where = string.Empty;

        public string Output
        {
            get { return projection + " " + join + " " + where; }
        }

        public override void EnterExpr([NotNull] SearchParser.ExprContext context)
        {
            this.where = string.Concat(where, " ", "WHERE");
        }

        public override void EnterFromText([NotNull] SearchParser.FromTextContext context)
        {
            var screenName = context.GetText().Substring(5).Enquote();
            this.where = string.Concat(where, " ", "twt.user.screen_name = ", screenName);
        }

        public override void EnterOp([NotNull] SearchParser.OpContext context)
        {
            var text = context.GetText();
            this.where = string.Concat(this.where, " ", text.ToUpper());
        }

        public override void EnterToText([NotNull] SearchParser.ToTextContext context)
        {
            var screenName = context.GetText().Substring(3).Enquote();
            this.where = string.Concat(where, " ", $"mention.screen_name = {screenName}");
        }

        public override void EnterHashText([NotNull] SearchParser.HashTextContext context)
        {
            var hashtag = context.GetText().Substring(3).Enquote();
            this.where = string.Concat(where, " ", $"ARRAY_CONTAINS(twt.entities.hashtags, {hashtag})");
        }
    }
}
