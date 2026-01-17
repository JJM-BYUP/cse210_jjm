using System;

public class PromptGenerator
/* Other websites used for learning:
    https://www.geeksforgeeks.org/c-sharp/list-implementation-in-c-sharp/
    https://www.youtube.com/watch?v=HlMd6EXk6Ag
    https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
*/

{
    // Create a prompts list
    public List<string> _prompt = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you do today that gave you joy?",
        "What did you do to feel the Spirit today?",
        "What reminded you of God's love today?",
        "What difficult situation did you overcome today by turning to Christ?",
        "What did you learn about Heavenly Father, Jesus Christ, or the gospel today that helped you feel the Spirit?",
        "How did you overcome the natural man/woman today to make choices that brought you closer to God?",
        "What happened today to make you smile?",
        "What happened today to make you laugh?",
        "What happened today that gave you peace?",
        "What happened today that made you think about something you hadn't thought about before?",
        "What happened today that made you see a person, culture, or experience in a new positive way?",
        "What happened today that changed how you see yourself?",
        "How did you deal with another's differences in a positive way today?",
        "How did you deal with the negative words or actions that someone said or did to you today?"
    };

    // Create GetRandomPrompt() of strings
    public string GetRandomPrompt()
    {
        Random indexNum = new Random();
        int indexRandom = indexNum.Next(0, _prompt.Count);
        string newPrompt = _prompt[indexRandom];
        return newPrompt;
    }

}


