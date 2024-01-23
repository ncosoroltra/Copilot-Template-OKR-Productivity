using Azure;
using Azure.AI.TextAnalytics;
using FileHelpers;

namespace sentiment
{
    internal class Program
    {
        static string languageKey = "3cd323d5a06b43a8b627d65b0b7ec324";
        static string languageEndpoint = "https://ls-testsentimentanalysis.cognitiveservices.azure.com/";

        static readonly AzureKeyCredential credentials = new AzureKeyCredential(languageKey);
        static readonly Uri endpoint = new Uri(languageEndpoint);
        static readonly TextAnalyticsClient client = new TextAnalyticsClient(endpoint, credentials);

        static Dictionary<int, string> listResults = new Dictionary<int, string>();

        static string document = @".\SentimentAnalysis-Feedback.csv";

        static async Task Main(string[] args)
        {
            if (args.Length == 1)
                document = args[0];

            Console.WriteLine($"Using document: {document}");
            Console.WriteLine("Do some Sentiment Analysis ...");

            var engine = new FileHelperEngine<Feedback>();

            // To Read Use:
            var result = engine.ReadFile(document);

            foreach (var item in result)
            {
                var text = item.tweet_text ?? string.Empty;
                var sentiment = await SentimentAnalysisAsync(client, text.Trim());
                item.Sentiment = sentiment.Item1;
                item.Score = sentiment.Item2;
            }

            // To Write Use:
            engine.WriteFile(document, result);

            Console.WriteLine("END.");
        }

        static async Task<Tuple<string, double>> SentimentAnalysisAsync(TextAnalyticsClient client, string input)
        {
            if (string.IsNullOrEmpty(input)) return new Tuple<string, double>("", 0.0);

            var result = await client.AnalyzeSentimentAsync(input, "es", options: new AnalyzeSentimentOptions()
            {
                IncludeOpinionMining = true
            });

            return new Tuple<string, double>(result.Value.Sentiment.ToString(), result.Value.ConfidenceScores.Positive);
        }
    }
}
