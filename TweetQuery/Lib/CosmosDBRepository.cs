namespace TweetQuery.Lib
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Azure.Documents.Client;
    using Microsoft.Azure.Documents.Linq;

    public class CosmosDBRepository<T> where T : class
    {
        private readonly string Endpoint = "https://tweet.documents.azure.com:443/";
        private readonly string Key = "vpKXCEgTEVH23mW4oi8H7mi2ZhaqpJITIXpIteSOssKc8nW9KKNjNCUmcwtCimmTL8W3yIdKaeLgq71tN4jejA==";
        private readonly string DatabaseId = "tweetdb";
        private readonly string CollectionId = "tweets";
        private DocumentClient client;

        public CosmosDBRepository()
        {
            client = new DocumentClient(new Uri(Endpoint), Key);
        }

        public async Task<IEnumerable<T>> GetItemsAsync(string sql)
        {
            if (string.IsNullOrEmpty(sql))
                throw new ArgumentNullException(nameof(sql));

            FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1 };

            var query = this.client.CreateDocumentQuery<T>(
                 UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId),
                 sql, queryOptions)
                 .AsDocumentQuery();

            List<T> results = new List<T>();
            while (query.HasMoreResults)
            {
                results.AddRange(await query.ExecuteNextAsync<T>());
            }

            return results;
        }
    }
}
