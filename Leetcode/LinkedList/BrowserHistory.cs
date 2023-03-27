namespace Leetcode;

public class BrowserHistory
{
    private class HistoryEntry
    {
        public HistoryEntry(string url)
        {
            Url = url;
        }

        public HistoryEntry? Prev { get; set; }
        public HistoryEntry? Next { get; set; }
        public string Url { get; set; }
    }
    
    private HistoryEntry BrowsingHistory { get; set; }

    public BrowserHistory(string homepage)
    {
        BrowsingHistory = new HistoryEntry(homepage);
    }
    
    public void Visit(string url)
    {
        BrowsingHistory.Next = new HistoryEntry(url);
        BrowsingHistory.Next.Prev = BrowsingHistory;
        BrowsingHistory = BrowsingHistory.Next;
    }
    
    public string Back(int steps)
    {
        var counter = 0;
        while (BrowsingHistory.Prev != null && counter < steps)
        {
            BrowsingHistory = BrowsingHistory.Prev;
            counter++;
        }

        return BrowsingHistory.Url;
    }
    
    public string Forward(int steps)
    {
        var counter = 0;
        while (BrowsingHistory.Next != null && counter < steps)
        {
            BrowsingHistory = BrowsingHistory.Next;
            counter++;
        }

        return BrowsingHistory.Url;
    }
}