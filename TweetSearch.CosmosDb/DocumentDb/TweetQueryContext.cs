namespace TweetSearch.CosmosDb.DocumentDb
{
    using Antlr4.Runtime;
    using Antlr4.Runtime.Tree;

    public class TweetQueryContext
    {
        private DocumentDbListener listener;

        public TweetQueryContext()
        {
            this.listener = new DocumentDbListener();
        }

        public SearchParser.ExprContext GenerateAST(string input)
        {
            var inputStream = new AntlrInputStream(input);
            var lexer = new SearchLexer(inputStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new SearchParser(tokens);
            parser.ErrorHandler = new BailErrorStrategy();

            return parser.expr();
        }

        public string GenerateQuery(string inputText)
        {
            var astree = this.GenerateAST(inputText);
            ParseTreeWalker.Default.Walk(listener, astree);
            return listener.Output;
        }
    }
}
