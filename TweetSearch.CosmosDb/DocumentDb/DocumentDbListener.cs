namespace TweetSearch.CosmosDb.DocumentDb
{
    using Antlr4.Runtime.Misc;
    using TweetSearch.CosmosDb.Util;

    public class DocumentDbListener : SearchBaseListener
    {
        private string projectionClause = "SELECT * FROM twt";
        private string whereClause;

        public string Output
        {
            get { return projectionClause + " " + whereClause; }
        }

        public override void EnterExpr([NotNull] SearchParser.ExprContext context)
        {
            this.whereClause = "WHERE";
        }

        public override void EnterFromText([NotNull] SearchParser.FromTextContext context)
        {
            var screenName = context.GetText().Substring(5).Enquote();
            this.whereClause = string.Concat(whereClause, " ", "twt.user.screen_name = ", screenName);
        }

        public override void EnterOp([NotNull] SearchParser.OpContext context)
        {
            var text = context.GetText();
            this.whereClause = string.Concat(this.whereClause, " ", text.ToUpper());
        }

        public override void EnterToText([NotNull] SearchParser.ToTextContext context)
        {
            var screenName = context.GetText().Substring(3).Enquote();
            this.whereClause = string.Concat(whereClause, " ", $"udf.matchArrayElement(twt.entities.user_mentions, {{ \"screen_name\" : {screenName} }} )");
        }

        public override void EnterHashText([NotNull] SearchParser.HashTextContext context)
        {
            var hashtag = context.GetText().Enquote();
            this.whereClause = string.Concat(whereClause, " ", $"udf.matchArrayElement(twt.entities.hashtags, {hashtag})");
        }

        public override void EnterExactText([NotNull] SearchParser.ExactTextContext context)
        {
            var text = context.GetText();
            this.whereClause = string.Concat(whereClause, " ", $"CONTAINS(twt.text, {text})");
        }
    }
}
