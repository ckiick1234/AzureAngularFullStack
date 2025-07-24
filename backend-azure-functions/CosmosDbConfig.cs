namespace Serverless.Api
{
    public static class CosmosDbConfig{
        public static readonly string DbPrimaryKey = "";
        public static readonly string DbName = "bookmarks";//"<your cosmos-db-name>";
        public static readonly string DbContainerName = "Bookmarks";
        public static readonly string DbEndpointUri = "https://exnosqlcosmosdb.documents.azure.com:443/";
    }
}
