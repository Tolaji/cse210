using System;

public class PromptGenerator
{
	// Attributes
	public List<string> _prompts = new List<string>();
	
	
	public PromptGenerator()
	{  // Constructor
	}
	
	public void StorePrompts()
	{
		// Source out Prompt and save it

		// The constant prompts to add
		string prompt1 = "Who was the most interesting person I interacted with today?";
		string prompt2 = "What was the best part of my day?";
		string prompt3 = "How did I see the hand of the Lord in my life today?";
		string prompt4 = "What was the strongest emotion I felt today?";
		string prompt5 = "If I had one thing I could do over today, what would it be?";

		_prompts.Add(prompt1);
		_prompts.Add(prompt2);
		_prompts.Add(prompt3);
		_prompts.Add(prompt4);
		_prompts.Add(prompt5);
	}

	public string GetRandomPrompt()
	{
		// Get Random Prompt
		Random random_prompt = new Random();
		int random_number;

		StorePrompts();

		random_number = random_prompt.Next(0, _prompts.Count);

		return (_prompts[random_number]);
	}
}