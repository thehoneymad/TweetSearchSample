namespace TweetSearch.CosmosDb.DocumentDb
{
    using Antlr4.Runtime.Misc;
    using TweetSearch.CosmosDb.Util;

    public class DocumentDbListener : SearchBaseListener
    {
        private string projection = "SELECT * FROM twt";
        private string join = string.Empty;

        public DocumentDbListener()
        {
            this.Output = projection;
        }
        public string Output { get; internal set; }

        public override void EnterExpr([NotNull] SearchParser.ExprContext context)
        {
            this.Output = string.Concat(Output, " ", "WHERE");
        }

        public override void EnterFromText([NotNull] SearchParser.FromTextContext context)
        {
            var userId = context.GetText().Substring(5).Enquote();
            this.Output = string.Concat(Output, " ", "twt.user.screen_name = ", userId);
        }

        public override void EnterOp([NotNull] SearchParser.OpContext context)
        {
            var text = context.GetText();
            this.Output = string.Concat(this.Output, " ", text.ToUpper());
        }

        public override void EnterToText([NotNull] SearchParser.ToTextContext context)
        {
            join = "JOIN user_mention in twt.entities.user_mentions";
            var userId = context.GetText().Substring(3).Enquote();
            this.Output = string.Concat(Output, " ", $"ARRAY_CONTAINS(twt.entities.user_mentions, {{ \"screen_name\" : {userId} }})");
        }

        public override void EnterHashText([NotNull] SearchParser.HashTextContext context)
        {
            var hashtag = context.GetText().Substring(3).Enquote();
            this.Output = string.Concat(Output, " ", $"ARRAY_CONTAINS(twt.entities.hashtags, {hashtag})");
        }
    }
}
