// Pattern: Hash set and dictionary for relationships and per-user tweets, plus timestamps to order tweets in the news feed
// When to use: When each user has a changing set of followees and the latest items from all followed users must be merged and sorted
// Complexity: PostTweet, Follow, Unfollow: O(1); GetNewsFeed: O(T + T log T), where T is the number of collected tweets

public class Twitter {
    Dictionary<int, List<int>> tweets = new Dictionary<int, List<int>>();
    Dictionary<int, int> tweetTime = new Dictionary<int, int>();
    Dictionary<int, HashSet<int>> followers = new Dictionary<int, HashSet<int>>();
    int timestamp = 0;

    public Twitter() {
        
    }
    
    public void PostTweet(int userId, int tweetId) {
        if(!tweets.ContainsKey(userId)) {
            tweets[userId] = new List<int>();
        }
        tweets[userId].Add(tweetId);
        timestamp++;
        tweetTime[tweetId] = timestamp;
    }
    
    public IList<int> GetNewsFeed(int userId) {
        if(userId == null) {
            return new List<int>(0);
        }

        List<int> users = new List<int>();
        users.Add(userId);
        if(followers.ContainsKey(userId)) {
            users.AddRange(followers[userId]);
        }

        List<int> feed = new List<int>();
        foreach(int user in users) {
            if(tweets.ContainsKey(user))
            {
                feed.AddRange(tweets[user]);
            }
        }

        return feed.OrderByDescending(tweetId => tweetTime[tweetId])
                .Take(10)
                .ToList();
    }
    
    public void Follow(int followerId, int followeeId) {
        if(!followers.ContainsKey(followerId)) {
            followers[followerId] = new HashSet<int>();
        }
        followers[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if(followers.ContainsKey(followerId)) {
            followers[followerId].Remove(followeeId);
        }
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */

 // Cases:
class Program
{
    public static void Main()
    {
        Twitter twitter = new Twitter();
        
        //Case 1:
        twitter.postTweet(1, 5);
        twitter.getNewsFeed(1);
        twitter.follow(1, 2);
        twitter.postTweet(2, 6);
        twitter.getNewsFeed(1);
        twitter.unfollow(1, 2);
        twitter.getNewsFeed(1);
    }
}